using MiniShop.Api.Dtos;

namespace MiniShop.Api.Services;

public interface IProductService
{
    List<ProductDto> GetAvailableProducts();
}