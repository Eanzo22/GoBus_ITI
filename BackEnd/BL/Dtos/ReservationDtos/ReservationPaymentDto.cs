﻿namespace BL.Dtos.ReservationDtos;

public class ReservationPaymentDto
{
    public int Id { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public string UserId { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public List<int> SeatNumbers { get; set; } = new List<int>();
    public DateTime DepartureDate { get; set; }
    public DateTime ArrivalDate { get; set; }
    public string BusClassName { get; set; } = string.Empty;
    public string StartBranchName { get; set; } = string.Empty;
    public string EndBranchName { get; set; } = string.Empty;
    public string ClientSecret { get; set; } = string.Empty;
    public string PaymentIntentId { get; set; } = string.Empty;
}
