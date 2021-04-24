using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laGrandeBouffet.Models.Bouffet.Situacao
{
    public class SituacaoEvento
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public SituacaoEvento()
        {
            Id = new Guid();
        }
    }
}
