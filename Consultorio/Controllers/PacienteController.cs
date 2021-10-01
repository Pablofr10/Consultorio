using Consultorio.Models.Entities;
using Consultorio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        private readonly IPacienteRepository _repository;

        public PacienteController(IPacienteRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var pacientes = _repository.GetPacientes();
            return pacientes.Any()
                    ? Ok(pacientes)
                    : BadRequest("Paciente não encontrado.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var paciente = _repository.GetPacientesById(id);
            return paciente != null
                    ? Ok(paciente)
                    : BadRequest("Paciente não encontrado.");
        }

    }
}
