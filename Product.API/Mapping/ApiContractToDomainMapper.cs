using Product.API.Contracts.Requests;

namespace Product.API.Mapping;

public static class ContractToDomainMapper
{
    public static Domain.Product ToProduct(this ProductRequest productRequest)
    {
        return new Domain.Product
        {
            Name = productRequest.Name,
            Description = productRequest.Description,
            Price = productRequest.Price,
            GTIN = productRequest.GTIN,
        };
    }
}