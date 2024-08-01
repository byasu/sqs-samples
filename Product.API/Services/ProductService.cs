using Product.API.Repositories;

namespace Product.API.Services;

public class ProductService : IProductService
{
    private readonly IProductRepository _productRepository;
    
    public ProductService(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }
    
    public async Task<IEnumerable<Domain.Product>> GetAllAsync()
    {
        var productsDtos = await _productRepository.GetAllAsync();
        return productsDtos;
    }

    public Task<Domain.Product> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Domain.Product product)
    {
        var existingProduct = await _productRepository.GetByIdAsync(product.Id);
        if (existingProduct is not null)
        {
            throw new Exception($"Product with id: {product.Id} already exists");
        }

        await _productRepository.AddAsync(product);
    }

    public Task UpdateAsync(Domain.Product product)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}