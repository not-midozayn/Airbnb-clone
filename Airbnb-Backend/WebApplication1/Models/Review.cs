﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApplication1.Models;

public partial class Review
{
    public Guid Id { get; set; }

    public Guid BookingId { get; set; }

    public Guid ReviewerId { get; set; }

    public Guid HostId { get; set; }

    public Guid ListingId { get; set; }

    public decimal Rating { get; set; }

    public string Comment { get; set; }

    public string HostReply { get; set; }
    public DateTime? HostReplyDate { get; set; }
    public DateTime? CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public decimal CleanlinessRating { get; set; }

    public decimal AccuracyRating { get; set; }
    public decimal CommunicationRating { get; set; }
    public decimal LocationRating { get; set; }
    public decimal CheckInRating { get; set; }
    public decimal ValueRating { get; set; }

    [JsonIgnore]
    public virtual Booking Booking { get; set; }
    [JsonIgnore]
    public virtual ApplicationUser Host { get; set; }
    [JsonIgnore]
    public virtual Listing Listing { get; set; }
    [JsonIgnore]
    public virtual ApplicationUser Reviewer { get; set; }
}