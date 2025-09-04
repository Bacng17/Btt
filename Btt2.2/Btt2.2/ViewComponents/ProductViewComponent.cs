using Microsoft.AspNetCore.Mvc;
using Btt2._2.Models;

namespace Btt2._2.ViewComponents
{
    public class ProductViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var productModel = new Product();
            var products = productModel.GetProductList();

            return View(products);
        }
    }
}
