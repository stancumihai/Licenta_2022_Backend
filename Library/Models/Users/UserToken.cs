﻿using Library.Enums;

namespace Library.Models.Users
{
    public class UserToken
    {
        public Guid Uid { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Roles Role { get; set; }
        public DateTime TokenCreated { get; set; }
        public DateTime TokenExpires { get; set; }
        public string RefreshToken { get; set; }
    }
}