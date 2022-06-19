namespace SmallsOnline.Web.Lib.Models.Blog;

public interface IBlogListEntry
{
    string? Id { get; set; }
    string? PartitionKey { get; set; }
    string? Title { get; set; }
    DateTimeOffset? PostedDate { get; set; }
    List<string>? Tags { get; set; }
}