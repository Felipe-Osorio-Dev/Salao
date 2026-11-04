namespace API.Models
{
    public class Services
    {
        public long Id  { get; set; }
        public string Name  { get; set; }
        public string Description { get; set; }

        //Referencia a tabela de agendamentos
        public ICollection<AppointmentServices> AppointmentServices { get; set; } = new List<AppointmentServices>();
    }
}
