namespace AvaliacaoCNPJ.Models
{
    public class Atividade_principal
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Text { get; set; }
        public ApiObjeto ApiObjeto { get; set; }


        public Atividade_principal()
        {
        }

        public Atividade_principal(int id,string code, string text)
        {
            Id = id;
            Code = code;
            Text = text;
        }
    }
}