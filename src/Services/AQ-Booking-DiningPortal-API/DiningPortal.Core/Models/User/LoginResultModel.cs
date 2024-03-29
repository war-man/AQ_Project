﻿namespace AQDiningPortal.Core.Models.User
{
    public class LoginResultModel
    {
        public string UserId { get; set; }
        public string UniqueId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserRole { get; set; }
        public double Expired { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string Message { get; set; }
    }
}
