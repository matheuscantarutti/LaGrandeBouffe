using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laGrandeBouffet.Models.Bouffet.Tipos
{
    public class TipoEvento
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public TipoEvento()
        {
            Id = new Guid();
        }
    }
}
