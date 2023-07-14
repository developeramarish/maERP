﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace maERP.Shared.Dtos.User;

public class UserUpdateDto
{
    [Required]
	public string FirstName { get; set; } = string.Empty;

	[Required]
	public string LastName { get; set; } = string.Empty;

    [Required]
	[DataType(DataType.EmailAddress)]
	public string Email { get; set; } = string.Empty;

	// [StringLength(15, ErrorMessage = "Das Passwort muss {2} bis {1} Zeichen haben.", MinimumLength = 8)]
	public string Password { get; set; } = string.Empty;

	[JsonIgnore]
	[Compare("Password", ErrorMessage = "Die Passwörter stimmen nicht überein.")]
	public string PasswordConfirm { get; set; } = string.Empty;
}