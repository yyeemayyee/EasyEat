using Domain.Entity.Enum;

namespace Domain.Entity
{
    public class Userinfo : BaseEntity
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int Height { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public TypeOfGender Gender { get; set; }
        public Typeofdiet Typeofdiet { get; set; }
        
        public virtual User User { get; set; }
        public virtual Progress Progress { get; set; }
    }
}
