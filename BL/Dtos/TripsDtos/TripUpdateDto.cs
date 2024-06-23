namespace BL.Dtos.TripsDtos;

public class TripUpdateDto
{
    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }
    public decimal Price { get; set; }
    public int BusId { get; set; }
    public int StartBranchId { get; set; }
    public int EndBranchId { get; set; }
}
