using GameStore.Api.Data;
using GameStore.Api.Entities;
using GameStore.Api.Repositories.Contracts;
using GameStore.Models.Dtos;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private readonly GameStoreDbContext gameStoreDbContext;

        public ShoppingCartRepository(GameStoreDbContext gameStoreDbContext)
        {
            this.gameStoreDbContext = gameStoreDbContext;
        }

        private async Task<bool> CartItemExists(int cartId, int productId)
        {
            return await this.gameStoreDbContext.CartItems.AnyAsync(c => c.CartId == cartId && 
                                                                     c.ProductId == productId);
        }
        
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.ProductId) == false) 
            {
                var item = await (from product in this.gameStoreDbContext.Products
                                  where product.Id == cartItemToAddDto.ProductId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      ProductId = product.Id,
                                      Qty = cartItemToAddDto.Qty
                                  }).SingleOrDefaultAsync();

                if (item != null)
                {
                    var result = await this.gameStoreDbContext.CartItems.AddAsync(item);
                    await this.gameStoreDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }
            return null;
        }
            

        public async Task<CartItem> DeleteItem(int id)
        {
            var item = await this.gameStoreDbContext.CartItems.FindAsync(id);
            if (item != null)
            {
                this.gameStoreDbContext.CartItems.Remove(item);
                await this.gameStoreDbContext.SaveChangesAsync();
            }
            return item;
        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in this.gameStoreDbContext.Carts
                          join cartItem in this.gameStoreDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in this.gameStoreDbContext.Carts
                          join cartItem in this.gameStoreDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              ProductId = cartItem.ProductId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).ToListAsync();
        }

        public async Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            var item = await this.gameStoreDbContext.CartItems.FindAsync(id);
            if (item != null)
            {
                item.Qty = cartItemQtyUpdateDto.Qty;
                await this.gameStoreDbContext.SaveChangesAsync();
                return item;
            }
            return null;
        }
    }
}
