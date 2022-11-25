using GameStore.Models.Dtos;
using Microsoft.AspNetCore.Components;

namespace GameStore.Web.Pages
{
    public class DisplayProductsBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
