namespace API.Models
{
    public class Appointments
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }

        // Collection para os serviços associados ao agendamento
        public ICollection<AppointmentServices> AppointmentServices { get; set; } = new List<AppointmentServices>();

        // Foreign key para o cliente
        public long CustomerId { get; set; }

        //Navegação para o cliente
        public Customers Customer { get; set; }
    }
}
