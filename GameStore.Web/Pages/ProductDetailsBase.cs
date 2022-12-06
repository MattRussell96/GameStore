using GameStore.Models.Dtos;
using GameStore.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace GameStore.Web.Pages
{
    public class ProductDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }
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

        protected async Task AddToCart_Click(CartItemToAddDto cartItemToAddDto)
        {
            try
            {
                var cartItem = await ShoppingCartService.AddItem(cartItemToAddDto);
            }
            catch (Exception)
            {
                // Log Exception
            }
        }
    }
}
