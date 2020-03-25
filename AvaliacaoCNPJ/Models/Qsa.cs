namespace AvaliacaoCNPJ.Models
{
    public class Qsa
    {
        public string Nome { get; set; }
        public string Qual { get; set; }
        public string pais_origem { get; set; }
        public string Nome_rep_legal { get; set; }
        public string Qual_rep_legal { get; set; }

        public Qsa()
        {
        }

        public Qsa(string nome, string qual, string pais_origem, string nome_rep_legal, string qual_rep_legal)
        {
            Nome = nome;
            Qual = qual;
            this.pais_origem = pais_origem;
            Nome_rep_legal = nome_rep_legal;
            Qual_rep_legal = qual_rep_legal;
        }
    }
}