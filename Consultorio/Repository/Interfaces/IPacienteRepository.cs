
using Consultorio.Models.Entities;
using System.Collections.Generic;

namespace Consultorio.Repository.Interfaces
{
    public interface IPacienteRepository : IBaseRepository
    {
        IEnumerable<Paciente> GetPacientes();
        Paciente GetPacientesById(int id);
    }
}
