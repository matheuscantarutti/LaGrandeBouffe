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
        public DateTime DataNasicmento { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime LastUpdate { get; set; }
        public ICollection<EventoEntity> Eventos { get; set; }

        public ClienteEntity(TipoCliente pessoa, string nome, string email, string endereco, int cpf, DateTime dataNascimento)
        {
            Id = new Guid();
            this.Criacao = DateTime.Now;
            this.Nome = nome;
            this.Email = email;
            this.Endereco = endereco;
            this.Cpf = cpf;
            this.DataNasicmento = dataNascimento;

        }
        
        public ClienteEntity(TipoCliente pessoa, string nome, string email, string endereco, int cnpj)
        {
            Id = new Guid();
            this.Criacao = DateTime.Now;
            this.Nome = nome;
            this.Email = email;
            this.Endereco = endereco;
            this.Cnpj = cnpj;
            

        }

    }
}
