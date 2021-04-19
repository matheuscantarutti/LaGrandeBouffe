using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laGrandeBouffet.ViewModels.Home
{
    public class CadastroViewModel
    {
        public string ErroEmail { get; set; }
        public string ErroSenha { get; set; }
        public string ErroConfirmaSenha { get; set; }
        public string[] ErroCadastro { get; set; }
        public string SucessoCadastro { get; set; }

    }
}
