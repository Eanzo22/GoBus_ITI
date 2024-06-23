using BL.Dtos.ReportDtos;
using BL.Dtos.ReservationDtos;

namespace BL.Dtos.ApplicationUserDtos;

public class UserWithDetailsDto
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public bool Blocked { get; set; }
    public IEnumerable<ReservationUserDto> ReservationUserDtos { get; set; } = new List<ReservationUserDto>();
    public IEnumerable<ReportUserDto> ReportUserDtos { get; set; } = new List<ReportUserDto>();
}
