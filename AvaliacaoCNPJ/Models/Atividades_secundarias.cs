namespace AvaliacaoCNPJ.Models
{
    public class Atividades_secundarias
    {
        public string Code { get; set; }
        public string Text { get; set; }

        public Atividades_secundarias()
        {
        }

        public Atividades_secundarias(string code, string text)
        {
            Code = code;
            Text = text;
        }
    }
}