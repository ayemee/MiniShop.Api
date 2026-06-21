using MiniShop.Api.Dtos;
using MiniShop.Api.Repositories;

namespace MiniShop.Api.Services;

public class ProductService(
    IProductRepository productRepository
) : IProductService
{
    public List<ProductDto> GetAvailableProducts()
    {
        var products = productRepository.GetAvailableProducts();

        return products.Select(product => new ProductDto {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price
        }).ToList();
    }

    public ProductDto? GetProductById(int id)
    {
        var product = productRepository.GetProductById(id);

        if(product == null)
        {
            return null;
        }
        return new ProductDto
        {
            Id = product.Id,
            Name = product.Name,
            Price = product.Price
        };
    }
}