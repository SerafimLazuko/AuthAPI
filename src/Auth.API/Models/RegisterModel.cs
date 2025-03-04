using System.ComponentModel.DataAnnotations;

namespace Auth.Models;

public class RegisterModel
{
    [Required(ErrorMessage = "Email обязателен")]
    [EmailAddress(ErrorMessage = "Некорректный Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Пароль обязателен")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "Пароль и подтверждение не совпадают")]
    public string ConfirmPassword { get; set; }
}
