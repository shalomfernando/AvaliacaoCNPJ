namespace AvaliacaoCNPJ.Models
{
    public class Atividades_secundarias
    {
        public string Code { get; set; }
        public string Tex { get; set; }

        public Atividades_secundarias()
        {
        }

        public Atividades_secundarias(string code, string tex)
        {
            Code = code;
            Tex = tex;
        }
    }
}