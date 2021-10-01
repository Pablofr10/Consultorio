using Consultorio.Context;
using Consultorio.Models.Entities;
using Consultorio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Repository
{
    public class PacienteRepository : BaseRepository, IPacienteRepository
    {
        private readonly ConsultorioContext _context;

        public PacienteRepository(ConsultorioContext context) : base(context)
        {
            _context = context;
        }
        public IEnumerable<Paciente> GetPacientes()
        {
            return _context.Pacientes.Include(x => x.Consultas).ToList();
        }

        public Paciente GetPacientesById(int id)
        {
            return _context.Pacientes.Include(x => x.Consultas).Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
