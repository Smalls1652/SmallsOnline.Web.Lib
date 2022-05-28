using Markdig;

namespace SmallsOnline.Web.Lib.Models.Blog;

public class BlogEntry : IBlogEntry
{
    public BlogEntry()
    { }

    public BlogEntry(string? blogTitle, DateTimeOffset? blogPostedDate, string? blogContent, List<string>? blogTags)
    {
        BlogTitle = blogTitle;
        BlogPostedDate = blogPostedDate;
        BlogContent = blogContent;
        BlogTags = blogTags;
    }

    [JsonPropertyName("blogTitle")]
    public string? BlogTitle { get; set; }

    [JsonPropertyName("blogPostedDate")]
    public DateTimeOffset? BlogPostedDate { get; set; }

    [JsonPropertyName("blogContent")]
    public string? BlogContent { get; set; }

    [JsonPropertyName("blogTags")]
    public List<string>? BlogTags { get; set; }
    
    [JsonPropertyName("blogIsPublished")]
    public bool BlogIsPublished { get; set; }

    public string? BlogContentHtml
    {
        get
        {
            if (BlogContent is not null)
            {
                return Markdown.ToHtml(
                    markdown: BlogContent,
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