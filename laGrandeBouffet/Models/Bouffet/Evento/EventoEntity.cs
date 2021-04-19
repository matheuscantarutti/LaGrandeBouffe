using System;
using Buffet.Models.Buffet.Cliente;
using La_Grande_Bouffe.Models;

namespace Buffet.Models.Buffet.Evento
{
    public class EventoEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public ClienteEntity Cliente { get; set; }

        public EventoEntity()
        {
            Id = new Guid();
        }
    }
}