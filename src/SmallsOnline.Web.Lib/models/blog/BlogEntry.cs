using Markdig;

namespace SmallsOnline.Web.Lib.Models.Blog;

public class BlogEntry : IBlogEntry
{
    public BlogEntry()
    { }

    public BlogEntry(string? title, DateTimeOffset? postedDate, string? content, List<string>? tags)
    {
        Title = title;
        PostedDate = postedDate;
        Content = content;
        Tags = tags;
    }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    [JsonPropertyName("blogTitle")]
    public string? Title { get; set; }

    [JsonPropertyName("blogPostedDate")]
    public DateTimeOffset? PostedDate { get; set; }

    [JsonPropertyName("blogContent")]
    public string? Content { get; set; }

    [JsonPropertyName("blogTags")]
    public List<string>? Tags { get; set; }
    
    [JsonPropertyName("blogIsPublished")]
    public bool IsPublished { get; set; }

    public string? ContentHtml
    {
        get
        {
            if (Content is not null)
            {
                return Markdown.ToHtml(
                    markdown: Content,
                    pipeline: new MarkdownPipelineBuilder()
                        .UsePipeTables()
                        .UseBootstrap()
                        .Build()
                );
            }
            else
            {
                return null;
            }
        }
    }
}