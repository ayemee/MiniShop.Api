using MiniShop.Api.Dtos;
using MiniShop.Api.Models;

namespace MiniShop.Api.Services;

public interface IProductService
{
    List<ProductDto> GetAvailableProducts();

    ProductDto? GetProductById(int id);
}