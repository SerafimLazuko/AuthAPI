using System.ComponentModel.DataAnnotations;

namespace Auth.Models;

public class LoginModel
{
    [Required(ErrorMessage = "Email обязателен")]
    [EmailAddress(ErrorMessage = "Некорректный Email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Пароль обязателен")]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public bool RememberMe { get; set; }
}