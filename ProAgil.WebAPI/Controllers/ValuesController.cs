using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]

    
    public class ValuesController : ControllerBase
    {
     [HttpGet]
     public ActionResult<IEnumerable<Evento>> Get()
     {
         return new Evento[] {
             new Evento() {
                 EventoId = 1,
                 Tema = "Angular e .Net Core",
                 Local = "Belo Horizonte",
                 Lote = "1 lote",
                 QtdPessoas = 250,
                 DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
             },
             new Evento() {
                 EventoId = 2,
                 Tema = "Angular",
                 Local = "João Pessoa",
                 Lote = "2 lote",
                 QtdPessoas = 350,
                 DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
             }
         };
     }

     [HttpGet("{id}")]
     public ActionResult<Evento> Get(int id)
     {
         return new Evento[] {
             new Evento() {
                 EventoId = 1,
                 Tema = "Angular e .Net Core",
                 Local = "Belo Horizonte",
                 Lote = "1 lote",
                 QtdPessoas = 250,
                 DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
             },
             new Evento() {
                 EventoId = 2,
                 Tema = "Angular",
                 Local = "João Pessoa",
                 Lote = "2 lote",
                 QtdPessoas = 350,
                 DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy")
             }
         }.FirstOrDefault(x =>x.EventoId == id);
     }

    }
}