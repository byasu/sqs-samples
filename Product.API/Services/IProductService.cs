namespace Product.API.Services;

public interface IProductService
{
    Task<IEnumerable<Domain.Product>> GetAllAsync();
    Task<Domain.Product> GetByIdAsync(int id);
    Task AddAsync(Domain.Product product);
    Task UpdateAsync(Domain.Product product);
    Task DeleteAsync(int id);
}