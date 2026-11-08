using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositorys.Customer
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _dbContext;

        public CustomerRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteCustomerAsync(Customers customer, CancellationToken ct = default)
        {
            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync(ct);
        }

        public async Task<List<Customers>> GetAllCustomersAsync(CancellationToken ct = default)
        {
            return await _dbContext.Customers.AsNoTracking().ToListAsync(ct);
        }

        public async Task<Customers?> GetCustomerByIdAsync(long id, CancellationToken ct = default)
        {
            return await _dbContext.Customers.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id, ct);
        }

        public async Task SaveCustomerAsync(Customers customer, CancellationToken ct = default)
        {
            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync(ct);
        }

        public async Task UpdateCustomerAsync(Customers customer, CancellationToken ct = default)
        {
            _dbContext.Customers.Update(customer);
            await _dbContext.SaveChangesAsync(ct);
        }
    }
}
