using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models.Entities
{
    public class ProfissionalEspecialidade : Base
    {
        public int ProfissionalId { get; set; }
        public Profissional Profissional { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}
