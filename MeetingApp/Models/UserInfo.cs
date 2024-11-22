using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
  public class UserInfo
  {
    public int Id { get; set; }
    [Required(ErrorMessage = "Lütfen Adınızı ve Soyadınızı Giriniz")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Lütfen E-Posta Adresinizi Giriniz")]
    [EmailAddress(ErrorMessage = "Lütfen Geçerli Bir E-Posta Adresi Giriniz")]
    public string? Email { get; set; }
    [Required(ErrorMessage = "Lütfen Telefon Numaranızı Giriniz")]
    public string? Phone { get; set; }

    public bool WillAttend { get; set; }
  }
}