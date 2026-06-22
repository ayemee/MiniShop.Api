using Microsoft.EntityFrameworkCore;
using MiniShop.Api.Data;
using MiniShop.Api.Models;

namespace MiniShop.Api.Repositories;

public class ProductRepository(AppDbContext context): IProductRepository
  
  
  {
    public List<Product> GetAvailableProducts()
    {
        return context.Products.Where(p => p.IsAvailable).ToList();
    }

    public Product? GetProductById(int id)
    {
      return context.Products.FirstOrDefault(p => p.Id == id);
    }

    public Product CreateProduct(Product product)
    {
        context.Products.Add(product);
        context.SaveChanges();
        return product;
    }

    public Product? UpdateProduct(int id, Product product)
    {
        var existingProduct = context.Products.FirstOrDefault(p => p.Id == id);
        if (existingProduct == null)
        {
            return null;
        }

        existingProduct.Name = product.Name;
        existingProduct.Price = product.Price;
        existingProduct.IsAvailable = product.IsAvailable;

        context.SaveChanges();
        return existingProduct;
    }

    public bool DeleteProduct(int id)
    {
        var product = context.Products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return false;
        }

        context.Products.Remove(product);
        context.SaveChanges();
        return true;
    }
}