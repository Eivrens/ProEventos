using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{
    public IEnumerable<Evento> _evento = new Evento[]
    {
        new Evento() {
            EventoId = 1,
            Local = "Recife - PE",
            Tema = "Angular e .NET Core 6",
            Lote = "1º Lote",
            QtdPessoas = 250,
        DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
            ImagemURL = "foto1.png"
        },
        new Evento() {
            EventoId = 2,
            Local = "Olinda - PE",
            Tema = "Java e C#",
            Lote = "1º Lote",
            QtdPessoas = 250,
            DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
            ImagemURL = "foto2.png"
        }
    };

// GET:

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

// POST:

    [HttpPost]
    public string Post()
    {
        return "Exemplo de PUT";
    }

// PUT:

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"Exemplo de PUT com id = {id}";
    }

// DELETE:

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Exemplo de DELETE com id = {id}";
    }

}