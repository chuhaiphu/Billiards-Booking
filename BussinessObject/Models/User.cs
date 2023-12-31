﻿using System;
using System.Collections.Generic;

namespace BussinessObject.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? AvatarLink { get; set; }
        public string? Role { get; set; }
    }
}
