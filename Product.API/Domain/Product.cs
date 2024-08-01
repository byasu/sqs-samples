namespace Product.API.Domain;

public class Product
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string GTIN { get; set; }
}