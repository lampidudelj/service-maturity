namespace ServiceMaturityApp.Data;

public class AuditService
{
    public Task<Application> GetApplicationInfoAsync(int id)
    {
        return Task.FromResult(new Application(){
            Id = id,
            Name = "Foo"
        });
    }

    public Task<bool> SaveChanges(Application app)
    {
        return Task.FromResult(true);
    }
}
