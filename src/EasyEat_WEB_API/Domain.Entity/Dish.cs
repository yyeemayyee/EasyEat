using Domain.Entity.Enum;

namespace Domain.Entity
{
    public class Dish : BaseEntity
    {
        public string Name { get; set; }
        public string Structure { get; set; } // состав
        public int Numberofcalories { get; set; }
        public Typeofdish Typeofdish { get; set; }
        public Typeofdiet Typeofdiet { get; set; }
        public string ImagePath { get; set; }
        
        
        public List<MenuDish> MenuDishes { get; } = new List<MenuDish>();
    }
}
