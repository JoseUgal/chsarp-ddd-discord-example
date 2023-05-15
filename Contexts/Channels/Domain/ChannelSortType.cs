using System.ComponentModel.DataAnnotations;

namespace Discord.Contexts.Channels.Domain;

public enum ChannelSortType
{
    [Display(Description = "Sort forum posts by activity")]
    LATEST_ACTIVITY = 0,
    
    [Display(Description = "Sort forum posts by creation time (from most recent to oldest)")]
    CREATION_DATE = 1
}