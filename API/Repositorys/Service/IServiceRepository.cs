using API.Models;

namespace API.Repositorys.Service
{
    public interface IServiceRepository
    {
        Task SaveServiceAsync(Services service, CancellationToken ct = default);
        Task<Services?> GetServiceByIdAsync(long id, CancellationToken ct = default);
        Task<List<Services>> GetAllServicesAsync(CancellationToken ct = default);
        Task UpdateServiceAsync(Services service, CancellationToken ct = default);
        Task DeleteServiceAsync(Services service, CancellationToken ct = default);
    }
}
