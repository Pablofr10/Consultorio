using System.Collections.Generic;

namespace Consultorio.Models.Entities
{
    public class Especialidade : Base
    {
        public string Nome { get; set; }
        public bool Ativa { get; set; }
        public virtual List<Profissional> Profissionais { get; set; }
        public List<Consulta> Consultas { get; set; }
    }
}
