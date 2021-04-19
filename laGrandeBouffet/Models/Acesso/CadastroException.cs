using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laGrandeBouffet.Models.Acesso
{
    public class CadastroException : Exception
    {
        public IEnumerable<IdentityError> Erros { get; set; }

        public CadastroException (IEnumerable<IdentityError> erros)
        {
            Erros = erros;
        }
    }
}
