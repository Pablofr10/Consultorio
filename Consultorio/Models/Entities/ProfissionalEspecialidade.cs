namespace Consultorio.Models.Entities
{
    public class ProfissionalEspecialidade
    {
        public int ProfissionalId { get; set; }
        public Profissional Profissionais { get; set; }
        public int EspecialidadeId { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}
