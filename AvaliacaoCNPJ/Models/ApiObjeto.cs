using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoCNPJ.Models
{
    public class ApiObjeto
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public Billing Billing { get; set; }
        public string Cnpj { get; set; }
        public string Tipo { get; set; }
        public string Abertura { get; set; }
        public string Nome { get; set; }
        public string Fantasia { get; set; }
        public string Natureza_juridica { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemnto { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string Uf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Efr { get; set; }
        public string Situacao { get; set; }
        public string Data_situacao { get; set; }
        public string Motivo_situacao { get; set; }
        public string Situacao_especial { get; set; }
        public string Data_situacao_especial { get; set; }
        public string Capital_social { get; set; }
        public ICollection<Qsa> Qsa { get; set; } = new List<Qsa>();
        public ICollection<Atividade_principal> Atividade_principal { get; set; } = new List<Atividade_principal>();
        public ICollection<Atividades_secundarias> atividades_secundarias { get; set; } = new List<Atividades_secundarias>();
        public object Extra { get; set; }

        public ApiObjeto()
        {
        }

        public ApiObjeto(string status, string message, Billing billing, string cnpj, string tipo, string abertura, string nome, string fantasia, string natureza_juridica, string logradouro, string numero, string complemnto, string cep, string bairro, string municipio, string uf, string email, string telefone, string efr, string situacao, string data_situacao, string motivo_situacao, string situacao_especial, string data_situacao_especial, string capital_social, object extra)
        {
            Status = status;
            Message = message;
            Billing = billing;
            Cnpj = cnpj;
            Tipo = tipo;
            Abertura = abertura;
            Nome = nome;
            Fantasia = fantasia;
            Natureza_juridica = natureza_juridica;
            Logradouro = logradouro;
            Numero = numero;
            Complemnto = complemnto;
            Cep = cep;
            Bairro = bairro;
            Municipio = municipio;
            Uf = uf;
            Email = email;
            Telefone = telefone;
            Efr = efr;
            Situacao = situacao;
            Data_situacao = data_situacao;
            Motivo_situacao = motivo_situacao;
            Situacao_especial = situacao_especial;
            Data_situacao_especial = data_situacao_especial;
            Capital_social = capital_social;
            Extra = extra;
        }
    }   
}
