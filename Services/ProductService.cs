using MiniShop.Api.Dtos;
using MiniShop.Api.Repositories;
using MiniShop.Api.Models;

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

    public ProductDto CreateProduct(CreateProductRequestDto request)
    {
        var product = new Product
        {
            Name = request.Name,
            Price = request.Price,
            IsAvailable = request.IsAvailable
        };

        var createdProduct = productRepository.CreateProduct(product);

        return new ProductDto
        {
            Id = createdProduct.Id,
            Name = createdProduct.Name,
            Price = createdProduct.Price
        };
    }

    public ProductDto? UpdateProduct(int id, UpdateProductRequestDto request)
    {
        var product = new Product
        {
            Name = request.Name,
            Price = request.Price,
            IsAvailable = request.IsAvailable
        };

        var updatedProduct = productRepository.UpdateProduct(id, product);

        if (updatedProduct == null)
        {
            return null;
        }

        return new ProductDto
        {
            Id = updatedProduct.Id,
            Name = updatedProduct.Name,
            Price = updatedProduct.Price
        };
    }

    public bool DeleteProduct(int id)
    {
        return productRepository.DeleteProduct(id);
    }
}