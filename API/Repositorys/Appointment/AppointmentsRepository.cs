using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositorys.Appointment
{
    public class AppointmentsRepository : IAppointmentRepository
    {
        private readonly AppDbContext _dbContext;

        public AppointmentsRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task DeleteAppointmentAsync(Appointments appointment, CancellationToken ct = default)
        {
            _dbContext.Appointments.Remove(appointment);
            await _dbContext.SaveChangesAsync(ct);
        }

        public async Task<List<Appointments>> GetAllAppointmentsAsync(CancellationToken ct = default)
        {
            return await _dbContext.Appointments.AsNoTracking().ToListAsync(ct);
        }

        public async Task<Appointments?> GetAppointmentByIdAsync(long id, CancellationToken ct = default)
        {
            return await _dbContext.Appointments.AsNoTracking().FirstOrDefaultAsync(a => a.Id == id, ct);
        }

        public async Task SaveAppointmentAsync(Appointments appointment, CancellationToken ct = default)
        {
            _dbContext.Appointments.Add(appointment);
            await _dbContext.SaveChangesAsync(ct);
        }

        public async Task UpdateAppointmentAsync(Appointments appointment, CancellationToken ct = default)
        {
            _dbContext.Appointments.Update(appointment);
            await _dbContext.SaveChangesAsync(ct);
        }
    }
}
