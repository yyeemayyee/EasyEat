namespace Domain.Entity
{
    public class Progress : BaseEntity
    {
        public string Value { get; set; }
        public string Date { get; set; }
        public int IdUserinfo { get; set; }
    }
}
