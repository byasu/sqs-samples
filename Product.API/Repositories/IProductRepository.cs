namespace Product.API.Repositories;

public interface IProductRepository
{
    Task<IEnumerable<Domain.Product>> GetAllAsync();
    Task<Domain.Product> GetByIdAsync(Guid id);
    Task AddAsync(Domain.Product product);
    Task UpdateAsync(Domain.Product product);
    Task DeleteAsync(int id);
}