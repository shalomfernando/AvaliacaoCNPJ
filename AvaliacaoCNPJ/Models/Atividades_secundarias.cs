namespace AvaliacaoCNPJ.Models
{
    public class Atividades_secundarias
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }
        public ApiObjeto ApiObjeto { get; set; }

        public Atividades_secundarias()
        {
        }

        public Atividades_secundarias(int id, string code, string text)
        {
            Id = id;
            Code = code;
            Text = text;
        }
    }
}