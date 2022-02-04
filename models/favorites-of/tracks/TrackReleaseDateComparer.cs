namespace SmallsOnline.Web.Lib.Models.FavoritesOf.Tracks;

public class TrackReleaseDateComparer : IComparer<TrackData>
{
    public int Compare(TrackData? track1, TrackData? track2)
    {
        if (track1 != null && track2 != null && track1.ReleaseDate.HasValue == true && track2.ReleaseDate.HasValue == true)
        {
            return DateTimeOffset.Compare(track1.ReleaseDate.Value, track2.ReleaseDate.Value);
        }
        else
        {
            return default;
        }
    }
}