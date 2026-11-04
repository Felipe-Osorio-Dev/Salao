namespace API.Models
{
    public class Customers
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        //Collection para os agendamentos do cliente
        public ICollection<Appointments> Appointments { get; set; } = new List<Appointments>();
    }
}
