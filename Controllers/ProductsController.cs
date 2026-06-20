using Microsoft.AspNetCore.Mvc;
using MiniShop.Api.Services;

namespace MiniShop.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(
    IProductService productService
) : ControllerBase
{
    [HttpGet("available")]
    public IActionResult GetAvailableProducts()
    {
        var products = productService.GetAvailableProducts();
        return Ok(products);
    }
}