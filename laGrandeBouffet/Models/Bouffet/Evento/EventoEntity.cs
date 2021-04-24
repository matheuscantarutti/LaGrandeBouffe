using System;
using Buffet.Models.Buffet.Cliente;
using La_Grande_Bouffe.Models;
using laGrandeBouffet.Models.Bouffet.Situacao;
using laGrandeBouffet.Models.Bouffet.Tipos;

namespace Buffet.Models.Buffet.Evento
{
    public class EventoEntity
    {
        public Guid Id { get; set; }
        public ClienteEntity Cliente { get; set; }
        public TipoEvento Tipo { get; set; }
        public string Descricao { get; set; }
        public DateTime EventoInicio{ get; set; }
        public DateTime EventoFim{ get; set; }
        public SituacaoEvento SituacaoEvento { get; set; }
        public string LocalNome{ get; set; }
        public string LocalEndereco{ get; set; }
        public string Obs{ get; set; }
        public DateTime Criacao { get; set; }
        public DateTime LastUpdate { get; set; }

        public EventoEntity(ClienteEntity cliente, TipoEvento tipo, string descricao, DateTime eventoInicio, DateTime eventoFim, SituacaoEvento situacaoEvento, 
                                string localNome, string localEndereco, string obs)
        {
            Id = new Guid();
            Criacao = DateTime.Now;
            Cliente = Cliente;
            Tipo = tipo;
            Descricao = descricao;
            EventoInicio = eventoInicio;
            EventoFim = eventoFim;
            SituacaoEvento = situacaoEvento;
            LocalNome = localNome;
            LocalEndereco = localEndereco;
            Obs = obs;
            
        }
    }
}