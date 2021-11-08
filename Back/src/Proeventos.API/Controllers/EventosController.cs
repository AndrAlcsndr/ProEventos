using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.Api.Data;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {   
        private readonly DataContext _context;
        public EventosController (DataContext context) 
        {
            _context = context;
        }

        [HttpGet]
       public IEnumerable <Evento> Get (){
           return _context.Eventos;

       }

       [HttpPost]
       public string Post (){
           return "Metodo Post";
       }

       [HttpDelete("{id}")]
       public string Delete (int id){
           return $"Deletou ID:{id}";
       }

    }
}
