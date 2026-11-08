using API.Models;

namespace API.Repositorys.Appointment
{
    public interface IAppointmentRepository
    {
        Task SaveAppointmentAsync(Appointments appointment, CancellationToken ct = default);
        Task<Appointments?> GetAppointmentByIdAsync(long id, CancellationToken ct = default);
        Task<List<Appointments>> GetAllAppointmentsAsync(CancellationToken ct = default);
        Task UpdateAppointmentAsync(Appointments appointment, CancellationToken ct = default);
        Task DeleteAppointmentAsync(Appointments appointment, CancellationToken ct = default);
    }
}
