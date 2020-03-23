using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoCNPJ.Models
{
    public class Empresa
    {
        public string NumeroInscricao { get; set; }
        public string UltimaAtualizacao { get; set; }
        public string NomeEmpresa { get; set; }
        public string NomeFantasia { get; set; }
        public AtividadeEconomica atividadeEconomicaPrimaria { get; set; }
        public string CodigoDescricaoNaturezaJuridica { get; set; }
        public Endereco endereco { get; set; }
        public SocioAdm socioAdm { get; set; }
        public string SituacaoCadastral { get; set; }
        public DateTime DataSituacaoCadastral { get; set; }

        public Empresa()
        {
        }

        public Empresa(
            string numeroInscricao, 
            string ultimaAtualizacao, 
            string nomeEmpresa, 
            string nomeFantasia, 
            AtividadeEconomica atividadeEconomicaPrimaria, 
            string codigoDescricaoNaturezaJuridica, 
            Endereco endereco, SocioAdm socioAdm, 
            string situacaoCadastral, 
            DateTime dataSituacaoCadastral)
        {
            NumeroInscricao = numeroInscricao;
            UltimaAtualizacao = ultimaAtualizacao;
            NomeEmpresa = nomeEmpresa;
            NomeFantasia = nomeFantasia;
            this.atividadeEconomicaPrimaria = atividadeEconomicaPrimaria;
            CodigoDescricaoNaturezaJuridica = codigoDescricaoNaturezaJuridica;
            this.endereco = endereco;
            this.socioAdm = socioAdm;
            SituacaoCadastral = situacaoCadastral;
            DataSituacaoCadastral = dataSituacaoCadastral;
        }
    }
}
