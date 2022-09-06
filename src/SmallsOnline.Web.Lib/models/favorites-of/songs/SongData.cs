namespace SmallsOnline.Web.Lib.Models.FavoritesOf.Songs;

public class SongData : ISongData
{
    public SongData() {}

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("partitionKey")]
    public string? PartitionKey { get; set; }

    [JsonPropertyName("trackTitle")]
    public string? Title { get; set; }

    [JsonPropertyName("trackArtist")]
    public string? Artist { get; set; }

    [JsonPropertyName("trackArtUrl")]
    public string? TrackArtUrl { get; set; }

    [JsonPropertyName("trackUrl")]
    public string? TrackUrl { get; set; }

    [JsonPropertyName("trackReleaseDate")]
    public DateTimeOffset? ReleaseDate { get; set; }

    [JsonPropertyName("trackComments")]
    public string? Comments { get; set; }

    [JsonPropertyName("listYear")]
    public string? ListYear { get; set; }
}