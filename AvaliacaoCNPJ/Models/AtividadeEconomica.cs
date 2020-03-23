namespace AvaliacaoCNPJ.Models
{
    public class AtividadeEconomica
    {
        public int Codigo { get; set; }
        public string Descricao { get; set; }

        public AtividadeEconomica()
        {
        }
        public AtividadeEconomica(int codigo, string descricao)
        {
            Codigo = codigo;
            Descricao = descricao;
        }
    }
}