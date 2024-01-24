namespace Domain.Entity
{
    public class MenuDish : BaseEntity
    {
        public int MenuId { get; set; }
        public int DishId { get; set; }
        public virtual Menu Menu { get; set; }
        public virtual Dish Dish { get; set; }
    }
}
