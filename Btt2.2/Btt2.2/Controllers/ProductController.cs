using Microsoft.AspNetCore.Mvc;
using Btt2._2.Models;

namespace Btt2._2.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult LatestProducts()
        {
            
            var productModel = new Product();
            var products = productModel.GetProductList();

            return PartialView("_LatestProducts", products);
        }

    }
}
