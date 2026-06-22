namespace MiniShop.Api.Dtos;

public class UpdateProductRequestDto
{
    public string Name { get; set; } = string.Empty;
    public decimal Price { get; set; }

    public bool IsAvailable { get; set; }
}