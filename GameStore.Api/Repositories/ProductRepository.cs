using GameStore.Api.Data;
using GameStore.Api.Entities;
using GameStore.Api.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace GameStore.Api.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly GameStoreDbContext gameStoreDbContext;
        public ProductRepository(GameStoreDbContext gameStoreDbContext)
        {
            this.gameStoreDbContext = gameStoreDbContext;
        }
        
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.gameStoreDbContext.ProductCategories.ToListAsync();

            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.gameStoreDbContext.Products.ToListAsync();

            return products;
        }
    }
}
