using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.WebAPI.Model;
using ProAgil.WebAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace ProAgil.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]

    
    public class ValuesController : ControllerBase
    {
        public DataContext _context {get;}
        public ValuesController(DataContext context)
        {
            _context = context;   
        }
     [HttpGet]
     public async Task<IActionResult> Get()
     {
         try
         {
            var results = await _context.Eventos.ToListAsync();

            return Ok(results);
         }
         catch (System.Exception)
         {
             return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou");
         }
         
     }

     [HttpGet("{id}")]
     public async Task<IActionResult> Get(int id)
     {
         try
         {
            var results = await _context.Eventos.FirstOrDefaultAsync(x =>x.EventoId == id);
            return Ok(results);
         }
         catch (System.Exception)
         {
             return this.StatusCode(StatusCodes.Status500InternalServerError, "Banco Dados Falhou");
         }
     }
    }
}