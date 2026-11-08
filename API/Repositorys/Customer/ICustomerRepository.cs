using API.Models;

namespace API.Repositorys.Customer
{
    public interface ICustomerRepository
    {
        Task SaveCustomerAsync(Customers customer, CancellationToken ct = default);
        Task<Customers?> GetCustomerByIdAsync(long id, CancellationToken ct = default);
        Task<List<Customers>> GetAllCustomersAsync(CancellationToken ct = default);
        Task UpdateCustomerAsync(Customers customer, CancellationToken ct = default);
        Task DeleteCustomerAsync(Customers customer, CancellationToken ct = default);

        //Serao adicionados mais metodos de acordo com a necessidade do projeto
        //Task<List<Customers>> GetAllCustomersWithAppointments();
        //Task<List<Customers>> GetAllCustomersWithAppointmentsByDate(DateTime date);
        //Task<List<Customers>> GetAllCustomersWithAppointmentsByDateRange(DateTime startDate, DateTime endDate);
    }
}
