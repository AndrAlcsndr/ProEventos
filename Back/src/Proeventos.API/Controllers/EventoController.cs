using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Proeventos.API.Models;

namespace Proeventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {

        public EventoController(ILogger<EventoController> logger)
        {
            
        }

        [HttpGet]
       public List<Evento>Get(){
           return new List<Evento>() {
               new Evento {
                   EventoId= 1,
               Tema = "Encontro turma olhos de aguia",
               Local = "Brasília-DF",
               QtdPessoas = "40",
               DataEvento = "20/11/2021",
               Lote = "E22",
               ImageUrl = "FotoDeParceiradaToda.jpg"
               },

               new Evento {
                   EventoId= 2,
               Tema = "Encontro turma olhos de aguia",
               Local = "Araraquara-DF",
               QtdPessoas = "40",
               DataEvento = "25/11/2021",
               Lote = "E23",
               ImageUrl = "FotoDeParceiradaToda.jpg"
               }
           };
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
