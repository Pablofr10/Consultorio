using AutoMapper;
using Consultorio.Models.Dtos;
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
        private readonly IMapper _mapper;

        public PacienteController(IPacienteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pacientes = await _repository.GetPacientesAsync();

            return pacientes.Any()
                    ? Ok(pacientes)
                    : BadRequest("Paciente não encontrado.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var paciente = await _repository.GetPacientesByIdAsync(id);

            var pacienteRetorno = _mapper.Map<PacienteDetalhesDto>(paciente);

            return pacienteRetorno != null
                    ? Ok(pacienteRetorno)
                    : BadRequest("Paciente não encontrado.");
        }

        [HttpPost]
        public async Task<IActionResult> Post(PacienteAdicionarDto paciente)
        {
            if (paciente == null) return BadRequest("Dados Inválidos");

            var pacienteAdicionar = _mapper.Map<Paciente>(paciente);

            _repository.Add(pacienteAdicionar);

            return await _repository.SaveChangesAsync()
                ? Ok("Paciente adicionado com sucesso")
                : BadRequest("Erro ao salvar o paciente");

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, PacienteAtualizarDto paciente)
        {
            if (id <= 0) return BadRequest("Usuário não informado");

            var pacienteBanco = await _repository.GetPacientesByIdAsync(id);

            var pacienteAtualizar = _mapper.Map(paciente, pacienteBanco);

            _repository.Update(pacienteAtualizar);

            return await _repository.SaveChangesAsync()
                 ? Ok("Paciente atualizado com sucesso")
                 : BadRequest("Erro ao atualizar o paciente");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0) return BadRequest("Paciente inválido");

            var pacienteExclui = await _repository.GetPacientesByIdAsync(id);

            if (pacienteExclui == null) return NotFound("Paciente não encontrado");

            _repository.Delete(pacienteExclui);

            return await _repository.SaveChangesAsync()
                 ? Ok("Paciente deletado com sucesso")
                 : BadRequest("Erro ao deletar o paciente");
        }
    }
}
