using Buffet.Models.Buffet.Evento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace La_Grande_Bouffe.Models
{
    public class ClienteEntity
    {
        public Guid Id { get; set; }

        public String Nome { get; set; }

        public string Email { get; set; }
        public ICollection<EventoEntity> Eventos { get; set; }

        public ClienteEntity()
        {
            Id = new Guid();
        }

    }
}
