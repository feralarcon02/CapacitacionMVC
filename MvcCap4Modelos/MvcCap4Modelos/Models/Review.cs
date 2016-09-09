namespace MvcCap4Modelos.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public virtual Album Album { get; set; }

        public string Contente { get; set; }

        public string ReviewEmail { get; set; }
    }
}