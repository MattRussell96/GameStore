using GameStore.Models.Dtos;
using GameStore.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace GameStore.Web.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        public IProductService ProductService { get; set; }
        public ProductDto Product { get; set; }
        public string ErrorMessage { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {

                Product = await ProductService.GetItem(Id);
                
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;

            }
        }
    }
}
