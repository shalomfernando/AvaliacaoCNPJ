namespace AvaliacaoCNPJ.Models
{
    public class Atividade_principal
    {
        public string Code { get; set; }
        public string Text { get; set; }

        public Atividade_principal()
        {
        }

        public Atividade_principal(string code, string text)
        {
            Code = code;
            Text = text;
        }
    }
}