﻿using System.ComponentModel.DataAnnotations;

namespace JWTAuth.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string Username { get; set; } = string.Empty;

        public string Password { get; set; } = string.Empty;

        public string Role { get; set; } = string.Empty;
    }
}
