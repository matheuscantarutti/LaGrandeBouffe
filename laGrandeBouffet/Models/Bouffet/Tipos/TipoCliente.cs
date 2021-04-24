using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laGrandeBouffet.Models.Bouffet.Tipos
{
    public class TipoCliente
    {
        public Guid Id { get; set; }
        public string Descricao{ get; set; }

        public TipoCliente()
        {
            Id = new Guid();
        }
    }
}
