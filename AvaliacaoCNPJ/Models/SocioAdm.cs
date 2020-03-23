namespace AvaliacaoCNPJ.Models
{
    public class SocioAdm
    {
        public string Nome { get; set; }
        public string Qualificacao { get; set; }

        public SocioAdm()
        {
        }

        public SocioAdm(string nome, string qualificacao)
        {
            Nome = nome;
            Qualificacao = qualificacao;
        }
    }
}