using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace TestEfNToN;

public class TimeSlot
{
    public int TimeSlotId { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public List<Tag> TagList { get; set; }
}