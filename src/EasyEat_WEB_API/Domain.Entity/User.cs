namespace Domain.Entity
{
    public class User : BaseEntity
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public virtual Userinfo Userinfo { get; set; }
    }
}
