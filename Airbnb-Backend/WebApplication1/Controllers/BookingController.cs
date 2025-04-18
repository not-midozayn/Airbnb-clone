﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTOS.Booking;
using WebApplication1.DTOS.Listing;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        #region Dependency Injection
        private readonly IBooking _bookingRepository;
        private readonly IMapper _mapper;
        private readonly ListingsRepository _listingsRepository;
        public BookingController(IBooking bookingRepository, IMapper mapper, ListingsRepository listingsRepository)
        {
            _bookingRepository = bookingRepository;
            _mapper = mapper;
            _listingsRepository = listingsRepository;
        }
        #endregion

        #region Post Methods
        [HttpPost]
        public async Task<ActionResult> CreateBooking([FromBody] CreateBookingDTO dto)
        {
            if (dto == null)
            {
                return BadRequest("Booking data is required.");
            }
            try
            {
                var newbooking = await _bookingRepository.CreateBooking(dto);
                return CreatedAtAction(nameof(CreateBooking), new { id = newbooking.Id }, newbooking);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }
        #endregion
    }
}
        //[HttpGet("{id}")]
        //public IActionResult GetBookingById(Guid id)
        //{
        //    var booking = _bookingRepository.GetUserBookings(id);
        //    if (booking == null)
        //        return NotFound();

        //    return Ok(booking);
        //}


        //// GET: api/bookings/me
        //[HttpGet("me")]
        //public IActionResult GetUserBookings()
        //{
        //    var userId = Guid.Parse(User.FindFirst("sub")?.Value);
        //    var bookings = _bookingRepository.GetUserBookings(userId);
        //    return Ok(bookings);
        //}

        //// GET: api/bookings/{id}
        //[HttpGet("{id}")]
        //public IActionResult GetBookingDetails(Guid id)
        //{
        //    var booking = _bookingRepository.GetBookingDetails(id);
        //    if (booking == null)
        //        return NotFound();

        //    var userId = Guid.Parse(User.FindFirst("sub")?.Value);
        //    if (booking.GuestId != userId && booking.Listing.HostId != userId)
        //        return Forbid();

        //    return Ok(booking);
        //}

        //// PUT: api/bookings/{id}/status
        //[HttpPut("{id}/status")]
        //public IActionResult UpdateBookingStatus(Guid id, [FromBody] string status)
        //{
        //    var booking = _bookingRepository.GetBookingDetails(id);
        //    if (booking == null)
        //        return NotFound();

        //    var userId = Guid.Parse(User.FindFirst("sub")?.Value);
        //    if (booking.Listing.HostId != userId)
        //        return Forbid();

        //    if (!_bookingRepository.UpdateBookingStatus(id, status))
        //        return BadRequest("Failed to update booking status");

        //    return NoContent();
        //}

        //// DELETE: api/bookings/{id}
        //[HttpDelete("{id}")]
        //public IActionResult CancelBooking(Guid id)
        //{
        //    var booking = _bookingRepository.GetBookingDetails(id);
        //    if (booking == null)
        //        return NotFound();

        //    var userId = Guid.Parse(User.FindFirst("sub")?.Value);
        //    if (booking.GuestId != userId)
        //        return Forbid();

        //    _bookingRepository.Delete(booking);
        //    _bookingRepository.Save();

        //    return NoContent();
        //}

        //// GET: api/listings/{id}/bookings
        //[HttpGet("~/api/listings/{id}/bookings")]
        //public IActionResult GetListingBookings(Guid id)
        //{
        //    var listing = _listingRepository.GetListingWithDetailsbyId(id);
        //    if (listing == null)
        //        return NotFound("Listing not found");

        //    var userId = Guid.Parse(User.FindFirst("sub")?.Value);

        //    //' ADD THIS IF CONTIDTION WHEN YOU ADD LISTING HOST ID TO BOOKING
        //    //if (listing.HostId != userId)
        //    // return Forbid();

        //    var bookings = _bookingRepository.GetListingBookings(id);
        //    return Ok(bookings);
        //}