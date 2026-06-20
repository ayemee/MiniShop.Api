using MiniShop.Api.Repositories;

namespace MiniShop.Api.Services;

public class ProductService(
    IProductRepository productRepository
) : IProductService
{
    public object GetAvailableProducts()
    {
        return productRepository.GetAvailableProducts();
    }
}