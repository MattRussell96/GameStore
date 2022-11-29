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

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await gameStoreDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);

            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await gameStoreDbContext.Products.FindAsync(id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.gameStoreDbContext.Products.ToListAsync();

            return products;
        }
    }
}
