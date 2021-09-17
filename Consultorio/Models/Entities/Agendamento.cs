using System;

namespace Consultorio.Models.Entities
{
    public class Agendamento
    {
        public int Id { get; set; }
        public string NomePaciente { get; set; }
        public DateTime Horario { get; set; }
    }
}
