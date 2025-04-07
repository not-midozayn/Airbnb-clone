﻿using Microsoft.AspNetCore.Identity;

namespace WebApplication1.Models
{
    public class ApplicationUser:IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string ProfilePictureUrl { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public string Bio { get; set; }

        public bool? IsHost { get; set; }

        public bool? IsVerified { get; set; }

        public int VerificationStatusId { get; set; }

        public bool? IsAdmin { get; set; }

        public DateTime? LastLogin { get; set; }

        public string PreferredLanguage { get; set; }

        public int? CurrencyId { get; set; }

        public virtual ICollection<Booking> Bookings { get; set; } = new List<Booking>();

        public virtual Currency Currency { get; set; }

        public virtual ICollection<Listing> Listings { get; set; } = new List<Listing>();

        public virtual ICollection<Message> MessageRecipients { get; set; } = new List<Message>();

        public virtual ICollection<Message> MessageSenders { get; set; } = new List<Message>();

        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();

        public virtual ICollection<Review> ReviewHosts { get; set; } = new List<Review>();

        public virtual ICollection<Review> ReviewReviewers { get; set; } = new List<Review>();

        public virtual VerificationStatus VerificationStatus { get; set; }

        public virtual ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
    }
}
