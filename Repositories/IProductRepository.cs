using MiniShop.Api.Models;

namespace MiniShop.Api.Repositories;

public interface IProductRepository
{
    List<Product> GetAvailableProducts();

    Product? GetProductById(int id);

    Product CreateProduct(Product product);

    Product? UpdateProduct(int id, Product product);

    bool DeleteProduct(int id);

}