namespace SmallsOnline.Web.Lib.Models.Projects;

public class ProjectItem : IProjectItem
{
    public ProjectItem()
    {}

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    [JsonPropertyName("projectName")]
    public string? Name { get; set; }

    [JsonPropertyName("projectDescription")]
    public string? Description { get; set; }

    [JsonPropertyName("projectType")]
    public string? Type { get; set; }

    [JsonPropertyName("projectUrl")]
    public Uri? Url { get; set; }

    [JsonPropertyName("projectUrlIsRepo")]
    public bool UrlIsRepo { get; set; }
}