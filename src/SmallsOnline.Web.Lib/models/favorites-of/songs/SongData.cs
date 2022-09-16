using System.Text;

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

    [JsonIgnore]
    public string? SongId
    {
        get
        {
            StringBuilder stringBuilder = new();

            if (Artist is not null)
            {
                stringBuilder.Append(BuildIdentifierText(Artist));
            }

            if (Title is not null)
            {
                stringBuilder.Append("_");
                stringBuilder.Append(BuildIdentifierText(Title));
            }

            return stringBuilder.ToString().ToLower();
        }
    }

    private static string BuildIdentifierText(string input)
    {
        StringBuilder stringBuilder = new();

        foreach (char character in input.ToCharArray())
        {
            if (!char.IsSymbol(character) && !char.IsPunctuation(character))
            {
                if (char.IsWhiteSpace(character))
                {
                    stringBuilder.Append("-");
                }
                else
                {
                    stringBuilder.Append(character);
                }
            }
        }

        return stringBuilder.ToString();
    }
}