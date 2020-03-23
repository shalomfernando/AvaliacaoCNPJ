namespace AvaliacaoCNPJ.Models
{
    public class Endereco
    {
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public string Municipio { get; set; }
        public string UF { get; set; }
        public string EnderecoEletronico { get; set; }
        public string Telefone { get; set; }

        public Endereco()
        {
        }

        public Endereco(
            string logradouro, 
            int numero, 
            string complemento, 
            string cep, 
            string bairro, 
            string municipio, 
            string uF, 
            string enderecoEletronico, 
            string telefone)
        {
            Logradouro = logradouro;
            Numero = numero;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Municipio = municipio;
            UF = uF;
            EnderecoEletronico = enderecoEletronico;
            Telefone = telefone;
        }
    }
}