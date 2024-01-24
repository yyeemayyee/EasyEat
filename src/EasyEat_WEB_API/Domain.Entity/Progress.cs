namespace Domain.Entity
{
    public class Progress : BaseEntity
    {
        public int Value { get; set; }
        
        public DateTime Date { get; set; }
        
        public int UserinfoId { get; set; }
        
        public virtual Userinfo Userinfo { get; set; }
    }
}
