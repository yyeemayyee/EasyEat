namespace Infrastructure.SeedData;

public interface IDbCreator
{
    void Create();
}

public class DbCreator : IDbCreator
{
    private readonly DataContext _dataContext;

    public DbCreator(DataContext dataContext)
    {
        _dataContext = dataContext;
    }

    public void Create()
    {
        var canConnect = _dataContext.Database.CanConnect();
        if (!canConnect)
        {
            _dataContext.Database.EnsureCreated();

            _dataContext.AddRange(FakeDataFactory.Users);
            _dataContext.SaveChanges();
            
            _dataContext.AddRange(FakeDataFactory.Dishes);
            _dataContext.SaveChanges();
            
            _dataContext.AddRange(FakeDataFactory.Menus);
            _dataContext.SaveChanges();
        }
    }
}