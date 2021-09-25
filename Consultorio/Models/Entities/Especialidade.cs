using System.Collections.Generic;

namespace Consultorio.Models.Entities
{
    public class Especialidade : Base
    {
        public string Nome { get; set; }
        public bool Ativa { get; set; }
        //public List<ProfissionalEspecialidade> MyProperty { get; set; }
    }
}
