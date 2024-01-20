namespace Domain.Entity
{
    public class Dish : BaseEntity
    {
        public string Name { get; set; }
        public string Structure { get; set; }
        public string Numberofcalories { get; set; }
        public string Typeofdish { get; set; }
        public string Typeofdiet { get; set; }
        public string ImagePath { get; set; }
    }
}
