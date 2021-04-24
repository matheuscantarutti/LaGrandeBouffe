using Buffet.Models.Buffet.Evento;
using laGrandeBouffet.Models.Bouffet.Situacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace laGrandeBouffet.Models.Bouffet.Convidado
{
    public class ConvidadoEntity
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public EventoEntity Evento { get; set; }
        public SituacaoConvidado SituacaoConvidado { get; set; }
        public string Obs { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime LastUpdate { get; set; }

        public ConvidadoEntity(string nome, string email, int cpf, DateTime dataNascimento, EventoEntity evento, SituacaoConvidado situacaoConvidado, string obs)
        {
            Id = new Guid();
            Criacao = DateTime.Now;
            Evento = evento;
            Nome = nome;
            Email = email;
            Cpf = cpf;
            DataNascimento = dataNascimento;
            SituacaoConvidado = situacaoConvidado;
            Obs = obs;

        }
    }
}
