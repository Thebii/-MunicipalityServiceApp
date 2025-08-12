namespace MunicipalityServiceApp.Models;

public class ReportIssueModel
{
    public string Location { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public IFormFile mediaAttachment { get; set; }
    public DateTime ReportedDate { get; set; } = DateTime.Now;
}