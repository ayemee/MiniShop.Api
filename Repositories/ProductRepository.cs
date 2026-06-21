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
}