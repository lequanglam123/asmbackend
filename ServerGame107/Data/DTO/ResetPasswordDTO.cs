﻿namespace ServerGame107.Data.DTO
{
    public class ResetPasswordDTO
    {
        public string Email { get; set; }
        public int OTP { get; set; }
        public string NewPassword { get; set; }
    }
}
