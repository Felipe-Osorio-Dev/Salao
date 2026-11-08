using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositorys.Service
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly AppDbContext _dbContext;

        public ServiceRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteServiceAsync(Services service, CancellationToken ct = default)
        {
            _dbContext.Services.Remove(service);
            await _dbContext.SaveChangesAsync(ct);
        }

        public async Task<List<Services>> GetAllServicesAsync(CancellationToken ct = default)
        {
            return await _dbContext.Services.AsNoTracking().ToListAsync(ct);
        }

        public async Task<Services?> GetServiceByIdAsync(long id, CancellationToken ct = default)
        {
            return await _dbContext.Services.AsNoTracking().FirstOrDefaultAsync(s => s.Id == id, ct);
        }

        public async Task SaveServiceAsync(Services service, CancellationToken ct = default)
        {
            _dbContext.Services.Add(service);
            await _dbContext.SaveChangesAsync(ct);
        }

        public async Task UpdateServiceAsync(Services service, CancellationToken ct = default)
        {
            _dbContext.Services.Update(service);
            await _dbContext.SaveChangesAsync(ct);
        }
    }
}
