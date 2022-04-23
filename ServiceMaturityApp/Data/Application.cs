namespace ServiceMaturityApp.Data;

public class Application
{
    public int Id { get; set; }
    public String Name { get; set; }
    public Domain Owner { get; set; }
    public String Description { get; set; }
    public String Url { get; set; }
    public String Repo { get; set; }
    public String FrameworkVersion { get; set; }
    public String LanguageVersion { get; set; }
    public IEnumerable<string> Contributors { get; set; }
    public ServiceMaturityAudit Audit  { get; set; }
}
