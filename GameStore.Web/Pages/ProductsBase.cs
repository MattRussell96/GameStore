﻿using GameStore.Models.Dtos;
using GameStore.Web.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace GameStore.Web.Pages
{
    public class ProductsBase : ComponentBase
    {
        [Inject]
        public IProductService ProductService { get; set; }
        [Inject]
        public IShoppingCartService ShoppingCartService { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public string ErrorMessage { get; set; }


        protected override async Task OnInitializedAsync()
        {
            try
            {
                Products = await ProductService.GetItems();

                var shoppingCartItem = await ShoppingCartService.GetItems(HardCoded.UserId);
                var totalQty = shoppingCartItem.Sum(i => i.Qty);

                ShoppingCartService.RaiseEventOnShoppingCartChange(totalQty);
            }
            catch (Exception ex)
            {

                ErrorMessage = ex.Message;
            }
        }

        protected IOrderedEnumerable<IGrouping<int, ProductDto>> GetGroupedProductsByCategory()
        {
            return from product in Products
                   group product by product.CategoryId into prodByCatGroup
                   orderby prodByCatGroup.Key
                   select prodByCatGroup;
        }

        protected string GetCategoryName(IGrouping<int, ProductDto> groupedProductDtos)
        {
            return groupedProductDtos.FirstOrDefault(pg => pg.CategoryId == groupedProductDtos.Key).CategoryName;
        }
    }
}
