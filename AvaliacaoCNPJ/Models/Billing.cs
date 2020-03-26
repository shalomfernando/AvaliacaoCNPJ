namespace AvaliacaoCNPJ.Models
{
    public class Billing
    {
        public int Id { get; set; }
        public bool Free { get; set; }
        public bool database { get; set; }

        public Billing()
        {
        }

        public Billing(int id, bool free, bool database)
        {
            Id = id;
            Free = free;
            this.database = database;
        }
    }
}