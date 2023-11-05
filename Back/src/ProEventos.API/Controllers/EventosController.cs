using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventosController : ControllerBase
{
    private readonly DataContext _context;
    
    public EventosController(DataContext context)
    {
        this._context = context;
    }

    // public IEnumerable<Evento> _evento = new Evento[]
    // {
    //     new Evento()
    //     {
    //         EventoId = 1,
    //         Tema = "Angular 11 e .NET 5",
    //         Local = "Belo Horizonte",
    //         Lote = "1 lote",
    //         QtdPessoas = 25,
    //         DataEvento = DateTime.Now.AddDays(2).ToString()
    //     },
    //     new Evento()
    //     {
    //         EventoId = 2,
    //         Tema = "Angular e suas novidades",
    //         Local = "São Paulo",
    //         Lote = "2 lote",
    //         QtdPessoas = 350,
    //         DataEvento = DateTime.Now.AddDays(3).ToString(),
    //         ImagemURL = "Foto3.png"
    //     }
    // };

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento Get(int id)
    {
        return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "valor de POST"; 
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"valor de Put {id}"; 
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"valor de Delete {id}"; 
    }
}
