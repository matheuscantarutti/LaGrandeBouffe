using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace La_Grande_Bouffe.RequestModels
{
    public class RequestModelCadastro
    { 
        public string EmailCadastro{ get; set; }
        public string SenhaCadastro{ get; set; }
        public string ConfirmaSenhaCadastro { get; set; } 
    }
}
