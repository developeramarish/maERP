﻿#nullable disable

namespace maERP.Shared.Dtos.User;

public class LoginResponseDto
{
	// public string UserId { get; set; }
	// public string Token { get; set; }
	// public string RefreshToken { get; set; }

    public bool Succeeded { get; set; }
    public string Message { get; set; }
    public TokenDTO Token { get; set; }
}