using AvaliacaoCNPJ.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvaliacaoCNPJ.Models
{
    public class ApiObjeto
    {
        public int Id { get; set; }
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

        public ApiObjeto()
        {
        }


        public ApiObjeto(CnpjFormViewModel cnpjForm)
        {
            Status = cnpjForm.Empresa.Status;
            Message = cnpjForm.Empresa.Message;
            Billing = cnpjForm.Empresa.Billing;
            Cnpj = cnpjForm.Empresa.Cnpj;
            Tipo = cnpjForm.Empresa.Tipo;
            Abertura = cnpjForm.Empresa.Abertura;
            Nome = cnpjForm.Empresa.Nome;
            Fantasia = cnpjForm.Empresa.Fantasia;
            Natureza_juridica = cnpjForm.Empresa.Natureza_juridica;
            Logradouro = cnpjForm.Empresa.Logradouro;
            Numero = cnpjForm.Empresa.Numero;
            Complemnto = cnpjForm.Empresa.Complemnto;
            Cep = cnpjForm.Empresa.Cep;
            Bairro = cnpjForm.Empresa.Bairro;
            Municipio = cnpjForm.Empresa.Municipio;
            Uf = cnpjForm.Empresa.Uf;
            Email = cnpjForm.Empresa.Email;
            Telefone = cnpjForm.Empresa.Telefone;
            Efr = cnpjForm.Empresa.Efr;
            Situacao = cnpjForm.Empresa.Situacao;
            Data_situacao = cnpjForm.Empresa.Data_situacao;
            Motivo_situacao = cnpjForm.Empresa.Motivo_situacao;
            Situacao_especial = cnpjForm.Empresa.Situacao_especial;
            Data_situacao_especial = cnpjForm.Empresa.Data_situacao_especial;
            Capital_social = cnpjForm.Empresa.Capital_social;
        }

        public void AddAtividadePrincipal(Atividade_principal atividade)
        {
            Atividade_principal.Add(atividade);
        }
        public void AddAtividadesSecundarias(Atividades_secundarias atividade)
        {
            atividades_secundarias.Add(atividade);
        }
        public void AddQsa(Qsa qsa)
        {
            Qsa.Add(qsa);
        }

    }   
}
