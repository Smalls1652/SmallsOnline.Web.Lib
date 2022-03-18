using Microsoft.AspNetCore.Components;

using SmallsOnline.Web.Lib.Models.FavoritesOf.Tracks;

namespace SmallsOnline.Web.Lib.Components.FavoritesOf.Tracks;

public partial class TrackItem : ComponentBase
{
    [Parameter, EditorRequired]
    public ITrackData ItemData { get; set; } = null!;
}