﻿using WebApplication1.Models;
namespace WebApplication1.DTOS.Authentication

{
    public class RegisterDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public DateTime? DateOfBirth { get; set; }
    }
}
