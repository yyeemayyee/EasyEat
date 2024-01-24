namespace Domain.Entity
{
    public class Menu : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Startdate { get; set; }
        public DateTime EndDate { get; set; }
        
        public List<MenuDish> MenuDishes { get; } = new List<MenuDish>();
    }
}
