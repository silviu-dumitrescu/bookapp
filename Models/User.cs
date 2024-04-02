﻿using Microsoft.Extensions.Hosting;

namespace mybookapp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Bio { get; set; }
        public ICollection<UserBook>? UserBooks { get; set; }
    }
}
