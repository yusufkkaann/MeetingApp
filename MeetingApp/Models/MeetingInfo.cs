namespace MeetingApp.Models
{
  public class MeetingInfo
  {
    public int? MeetingId { get; set; }
    public int? NumberOfPeople { get; set; }
    public string? MeetingDescription { get; set; }
    public DateTime MeetingDate { get; set; }
    public string? MeetingLocation { get; set; }

  }
}