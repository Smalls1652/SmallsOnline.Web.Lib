namespace SmallsOnline.Web.Lib.Models.Blog;

public interface IBlogEntry
{
    string? BlogTitle { get; set; }
    DateTimeOffset? BlogPostedDate { get; set; }
    string? BlogContent { get; set; }
    List<string>? BlogTags { get; set; }
    bool BlogIsPublished { get; set; }
    string? BlogContentHtml { get; }
}