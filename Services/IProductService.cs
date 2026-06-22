using MiniShop.Api.Dtos;
using MiniShop.Api.Models;

namespace MiniShop.Api.Services;

public interface IProductService
{
    List<ProductDto> GetAvailableProducts();

    ProductDto? GetProductById(int id);

    ProductDto CreateProduct(CreateProductRequestDto request);

    ProductDto? UpdateProduct(
        int id,
        UpdateProductRequestDto request
    );

    bool DeleteProduct(int id);
}