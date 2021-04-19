using System.Collections;
using System.Collections.Generic;

namespace Buffet.ViewModels.Home
{
    public class IndexViewModel
    {
        public ICollection<Cliente> Clientes  { get; set; }

        public IndexViewModel()
        {
            Clientes = new List<Cliente>();
        }
    }

    public class Usuario
    {
        public string Nome { get; set; }
        public string Idade { get; set; }
    }

    public class Cliente
    {
        public string Id { get; set; }
        public string Nome { get; set; }
    }
}