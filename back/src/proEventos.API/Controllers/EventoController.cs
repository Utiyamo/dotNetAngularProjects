using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using proEventos.API.Models;

namespace proEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento() {
                    EventId = 1,
                    Tema = "Angular e dotNET 5",
                    Local = "São Paulo",
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    QtdPessoas = 2,
                    Lote = "1o Lote",
                    ImageUrl = "https://localhost:5001/Image"
                },
                new Evento() {
                    EventId = 2,
                    Tema = "Angular e dotNET 5",
                    Local = "São Paulo",
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    QtdPessoas = 4,
                    Lote = "2o Lote",
                    ImageUrl = "https://localhost:5001/Image"
                }
            };

        public EventoController()
        {
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id){
            return _evento.Where(evento => evento.EventId == id);
        }

        [HttpPost]
        public IEnumerable<Evento> Post(Evento eventoItem){
            _evento = _evento.Append(eventoItem);

            return _evento;
        }
    }
}
