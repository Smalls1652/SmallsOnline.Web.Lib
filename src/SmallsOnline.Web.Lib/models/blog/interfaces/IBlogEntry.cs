namespace SmallsOnline.Web.Lib.Models.Blog;

public interface IBlogEntry
{
    string? Id { get; set; }
    string? PartitionKey { get; set; }
    string? BlogTitle { get; set; }
    DateTimeOffset? BlogPostedDate { get; set; }
    string? BlogContent { get; set; }
    List<string>? BlogTags { get; set; }
    bool BlogIsPublished { get; set; }
    string? BlogContentHtml { get; }
}