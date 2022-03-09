namespace SmallsOnline.Web.Lib.Models.Projects;

public interface IProjectItem
{
    string? Name { get; set; }
    string? Description { get; set; }
    string? Type { get; set; }
    Uri? Url { get; set; }
    bool UrlIsRepo { get; set; }
}