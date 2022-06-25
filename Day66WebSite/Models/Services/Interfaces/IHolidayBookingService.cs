namespace Day66WebSite.Models.Services.Interfaces;

public interface IHolidayBookingService
{
    Task<FlightSearchResultViewModel> GetAll(string locationFrom,
        string locationTo,
        DateTime departureDate,
        DateTime? returnDate = null);
}