using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace La_Grande_Bouffe.RequestModels
{
    public class RequestModelCadastro
    { 
        public string EmailLogin{ get; set; }
        public string SenhaLogin{ get; set; }
        public string ConfirmaSenhaLogin { get; set; } 
    }
}
