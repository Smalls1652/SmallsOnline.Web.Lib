namespace SmallsOnline.Web.Lib.Models.Blog;

public class BlogListEntry : IBlogListEntry
{
    public BlogListEntry()
    {}

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    [JsonPropertyName("blogTitle")]
    public string? Title { get; set; }

    [JsonPropertyName("blogPostedDate")]
    public DateTimeOffset? PostedDate { get; set; }

    [JsonPropertyName("blogTags")]
    public List<string>? Tags { get; set; }
}