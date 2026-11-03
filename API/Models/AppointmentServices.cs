namespace API.Models
{
    public class AppointmentServices
    {
        // Foreign key para o agendamento
        public long AppointmentId { get; set; }
        public Appointments Appointment { get; set; }

        // Foreign key para o serviço
        public long ServiceId { get; set; }
        public Services Service { get; set; }

        //Propriedade que ira armazenar os valores dos serviços selecionados para o agendamento
        public decimal ServiceValue { get; set; }
    }
}
