using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laGrandeBouffet.Models.Bouffet.Situacao
{
    public class SituacaoConvidado
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }

        public SituacaoConvidado()
        {
            Id = new Guid();
        }
    }
}
