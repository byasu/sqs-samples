namespace Product.API.Contracts.Requests;

public class ProductRequest
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string GTIN { get; set; }
}