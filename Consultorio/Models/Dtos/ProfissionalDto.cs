using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Models.Dtos
{
    public class ProfissionalDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
