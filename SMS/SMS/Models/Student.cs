using System.ComponentModel.DataAnnotations;

namespace SMS.Models;

public class Student
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "First Name is required")]
    public string FirstName { get; set; } = string.Empty;


}
