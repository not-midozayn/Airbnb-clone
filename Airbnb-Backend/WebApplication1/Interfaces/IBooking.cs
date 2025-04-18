﻿using WebApplication1.DTOS.Booking;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IBooking : IRepository<Booking>
    {
        Task<Booking> CreateBooking(CreateBookingDTO dto);
        //IEnumerable<Booking> GetUserBookings(Guid userId);
        //Booking GetBookingDetails(Guid id);
        //IEnumerable<Booking> GetListingBookings(Guid listingId);
        //bool UpdateBookingStatus(Guid id, string status);
        //bool IsListingAvailable(Guid listingId, DateTime checkIn, DateTime checkOut);
    }
}
