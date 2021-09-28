namespace Consultorio.Models.Entities
{
    public class ProfissionalEspecialidade
    {
        public int ProfissionalId { get; set; }
        public virtual Profissional Profissionais { get; set; }
        public int EspecialidadeId { get; set; }
        public virtual Especialidade Especialidade { get; set; }
    }
}
