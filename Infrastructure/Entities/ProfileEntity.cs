

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Entities;

public class ProfileEntity
{
    [Key, ForeignKey(nameof(UserEntity))]
    public int UserId { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string FirstName { get; set; } = null!;

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string LastName { get; set; } = null!;

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string? StreetName { get; set; }

    [Required]
    [Column(TypeName = "varchar(6)")]
    public string? PostalCode { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(50)")]
    public string? City { get; set; }

}

