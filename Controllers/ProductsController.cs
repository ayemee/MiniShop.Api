using Microsoft.AspNetCore.Mvc;
using MiniShop.Api.Services;
using MiniShop.Api.Dtos;

namespace MiniShop.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController(
    IProductService productService
) : ControllerBase
{
    [HttpGet("available")]
    public ActionResult <List<ProductDto>> GetAvailableProducts()
    {
        var products = productService.GetAvailableProducts();
        return Ok(products);
    }
}