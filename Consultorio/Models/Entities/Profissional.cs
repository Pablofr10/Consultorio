using System.Collections.Generic;

namespace Consultorio.Models.Entities
{
    public class Profissional : Base
    {
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public List<Consulta> Consultas { get; set; }
        public List<Especialidade> Especialidades { get; set; }
    }
}
