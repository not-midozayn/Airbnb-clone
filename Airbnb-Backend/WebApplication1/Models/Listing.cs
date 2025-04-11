﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Models;

public partial class Listing
{
    public Guid Id { get; set; }
    public Guid HostId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int PropertyTypeId { get; set; }
    public int RoomTypeId { get; set; }
    public int? Capacity { get; set; }
    public int Bedrooms { get; set; }
    public int Bathrooms { get; set; }
    public decimal PricePerNight { get; set; }
    public decimal? ServiceFee { get; set; }
    public string AddressLine1 { get; set; }
    public string AddressLine2 { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public decimal? Latitude { get; set; }
    public decimal? Longitude { get; set; }
    public bool? InstantBooking { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public int? MinNights { get; set; }
    public int MaxNights { get; set; }
    public int? CancellationPolicyId { get; set; }
    public decimal? AverageRating { get; set; }
    public int? ReviewCount { get; set; }
    public bool? IsActive { get; set; }
    public int? CurrencyId { get; set; }
    public virtual ICollection<AvailabilityCalendar> AvailabilityCalendars { get; set; } = new List<AvailabilityCalendar>();
    public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    public virtual CancellationPolicy CancellationPolicy { get; set; }
    public virtual Currency Currency { get; set; }
    public virtual ApplicationUser Host { get; set; }
    public virtual ICollection<ListingAmenity> ListingAmenities { get; set; } = new List<ListingAmenity>();
    public virtual ICollection<ListingPhoto> ListingPhotos { get; set; } = new List<ListingPhoto>();
    public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
    public virtual PropertyType PropertyType { get; set; }
    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();
    public virtual RoomType RoomType { get; set; }
    public virtual ICollection<WishlistItem> WishlistItems { get; set; } = new List<WishlistItem>();
}