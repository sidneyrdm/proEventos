using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proeventos.api.Models;

namespace proeventos.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        public IEnumerable<Evento> _evento = 
        new Evento[]
        {
            new Evento()
        {
               EventoId = 1,
               Tema = "angular 11 e dotNet 5",
               Local = "Belo Horizonte",
               Lote = "primeiro lote",
               QtdPessoas = 250,
               DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
               ImagemURL = "foto.png"
            },
                        new Evento()
        {
               EventoId = 2,
               Tema = "angular news",
               Local = "sao paulo",
               Lote = "segundo lote",
               QtdPessoas = 300,
               DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
               ImagemURL = "foto1.png"
            }
        };

        public WeatherForecastController()
        {}

        [HttpGet]
        public IEnumerable<Evento> Get(){

        return _evento;
  }
  
          [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){

        return _evento.Where(evento => evento.EventoId == id);
  }
 }
}
