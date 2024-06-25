namespace BL.Dtos.ReportDtos;

public class ReportDetailsDto
{
    public int Id { get; set; }
    public int ReservationNumber { get; set; }
    public string MessageTitle { get; set; } = string.Empty;
    public string MessageContent { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string UserEmail { get; set; } = string.Empty;
    public string UserPhone { get; set; } = string.Empty;
    public string UserId { get; set; } = string.Empty;
}
