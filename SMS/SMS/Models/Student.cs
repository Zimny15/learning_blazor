using System.ComponentModel.DataAnnotations;

namespace SMS.Models;

public class Student
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "First Name is required")]
    public string FirstName { get; set; } = string.Empty;

    [StringLength(50, ErrorMessage = "Middle Name cannot be longer than 50 characters")]
    public string? MiddleName { get; set; } = string.Empty;

    [Required(ErrorMessage = "Last Name is required")]
    public string LastName { get; set; } = string.Empty;

    [Required(ErrorMessage = "EmailAddress is required")]
    public string EmailAddress { get; set; } = string.Empty;
    public string? Address { get; set; } = string.Empty;

    [Required(ErrorMessage = "Phone Number is required")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "Country is required")]
    public string Country { get; set; } = string.Empty;
}
