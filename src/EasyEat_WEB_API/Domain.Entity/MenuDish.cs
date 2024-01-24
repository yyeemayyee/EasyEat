namespace Domain.Entity
{
    public class MenuDish : BaseEntity
    {
        public string MenuId { get; set; }
        public string DishId { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Dish Dish { get; set; }
    }
}
