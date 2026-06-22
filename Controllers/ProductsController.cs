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

    [HttpGet("{id}")]
    public ActionResult <ProductDto> GetProductById(int id)
    {
        var product = productService.GetProductById(id);
        if(product == null)
        {
            return NotFound();
        }

        return Ok(product);
    }

    [HttpPost]
    public ActionResult <ProductDto> CreateProduct(CreateProductRequestDto request)
    {
        var product = productService.CreateProduct(request);
        return CreatedAtAction(nameof(GetProductById), new { id = product.Id }, product);
    }

    [HttpPut("{id}")]
    public ActionResult <ProductDto> UpdateProduct(int id, UpdateProductRequestDto request)
    {
        var updatedProduct = productService.UpdateProduct(id, request);
        if(updatedProduct == null)
        {
            return NotFound();
        }

        return Ok(updatedProduct);
    }   

    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var isDeleted = productService.DeleteProduct(id);
        if(!isDeleted)
        {
            return NotFound();
        }

        return NoContent();
    }
}