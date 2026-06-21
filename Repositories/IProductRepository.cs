using MiniShop.Api.Models;

namespace MiniShop.Api.Repositories;

public interface IProductRepository
{
    List<Product> GetAvailableProducts();

    Product? GetProductById(int id);
}