using System.ComponentModel.DataAnnotations;

public class Admin
{
    public int Id { get; set; }

    [Required]
    [StringLength(50, MinimumLength = 3)]
    public string Name { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}
