using Consultorio.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        List<Agendamento> agendamentos = new List<Agendamento>();
        public AgendamentoController()
        {
            agendamentos.Add(new Agendamento
            {
                Id = 1,
                NomePaciente = "Arian",
                Horario = new DateTime(2021, 03, 16)
            });
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(agendamentos);
        }

        [HttpGet("busca-agendamento/{id}")]
        public IActionResult GetById(int id)
        {
            var agendamentoSelecionado = agendamentos.FirstOrDefault(x => x.Id == id);

            return agendamentoSelecionado != null
                ? Ok(agendamentoSelecionado)
                : BadRequest("Erro ao buscar o agendamento");
        }
    }
}
