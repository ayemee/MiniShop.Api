using Microsoft.EntityFrameworkCore;
using MiniShop.Api.Models;

namespace MiniShop.Api.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options): DbContext(options)
{
    public DbSet<Product> Products { get; set; }
}