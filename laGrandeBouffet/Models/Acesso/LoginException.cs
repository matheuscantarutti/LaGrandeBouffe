using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laGrandeBouffet.Models.Acesso
{
    public class LoginException : Exception
    {
        public string Erro { get; set; }

        public LoginException (string erro)
        {
            Erro = erro;
        }
    }
}
