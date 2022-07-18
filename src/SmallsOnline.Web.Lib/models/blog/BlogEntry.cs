using Markdig;

namespace SmallsOnline.Web.Lib.Models.Blog;

public class BlogEntry : IBlogEntry
{
    [JsonConstructor()]
    public BlogEntry()
    { }

    public BlogEntry(string filePath, string? title, DateTimeOffset? postedDate, List<string> tags)
    {
        string absoluteFilePath = Path.GetFullPath(filePath);

        bool fileExists = File.Exists(absoluteFilePath);
        if (!fileExists)
        {
            throw new FileNotFoundException($"The file at the path '{filePath}' does not exist.");
        }

        FileInfo fileInfo = new(absoluteFilePath);
        if (fileInfo.Extension != ".md" && fileInfo.Extension != ".txt")
        {
            throw new Exception("The provided file does not have an extension of '.md' or '.txt'.");
        }

        using (StreamReader streamReader = new(absoluteFilePath))
        {
            Content = streamReader.ReadToEnd();
        }

        Id = Guid.NewGuid().ToString();
        Title = title;
        PostedDate = postedDate;
        Tags = tags;
    }

    public BlogEntry(string? title, DateTimeOffset? postedDate, string? content, List<string>? tags)
    {
        Id = Guid.NewGuid().ToString();
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

    [JsonIgnore()]
    public string? ContentHtml
    {
        get
        {
            if (Content is not null)
            {
                return Markdown.ToHtml(
                    markdown: Content,
                    pipeline: new MarkdownPipelineBuilder()
                        .UseGenericAttributes()
                        .UsePipeTables()
                        .UseBootstrap()
                        .UseAutoLinks()
                        .Build()
                );
            }
            else
            {
                return null;
            }
        }
    }

    public string ConvertToJson() => JsonSerializer.Serialize(this);

    public static BlogEntry? ConvertFromJson(string jsonContent) => JsonSerializer.Deserialize<BlogEntry>(jsonContent);
}