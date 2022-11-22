using GameStore.Models.Dtos;
using GameStore.Web.Services.Contracts;
using System.Net.Http.Json;

namespace GameStore.Web.Services
{
    public class ProductService : IProductService
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<ProductDto>> GetItems()
        {
            try
            {
                var product = await this.httpClient.GetFromJsonAsync<IEnumerable<ProductDto>>("api/Product");
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
