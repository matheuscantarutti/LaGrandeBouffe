using Buffet.Models.Buffet.Evento;
using laGrandeBouffet.Models.Bouffet.Tipos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace La_Grande_Bouffe.Models
{
    public class ClienteEntity
    {
        public Guid Id { get; set; }
        public TipoCliente Pessoa { get; set; }
        public String Nome { get; set; }
        public int Cpf { get; set; }
        public int Cnpj { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Obs { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<EventoEntity> Eventos { get; set; }

        public ClienteEntity(TipoCliente pessoa, string nome, string email, string endereco, string obs, int cpf, DateTime dataNascimento)
        {
            Id = new Guid();
            Criacao = DateTime.Now;
            Nome = nome;
            Email = email;
            Endereco = endereco;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            Obs = obs;

        }
        
        public ClienteEntity(TipoCliente pessoa, string nome, string email, string endereco, string obs, int cnpj)
        {
            Id = new Guid();
            Criacao = DateTime.Now;
            Nome = nome;
            Email = email;
            Endereco = endereco;
            Cnpj = cnpj;
            Obs = obs;

        }

    }
}
