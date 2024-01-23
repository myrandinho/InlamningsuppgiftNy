

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities;



[Index(nameof(Email), IsUnique = true)]
public class UserEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "varchar(100)")]
    public string Email { get; set; } = null!;

    [Required]
    [Column(TypeName = "varchar(100)")]
    public string Password { get; set; } = null!;



    [Required]
    [ForeignKey(nameof(RoleEntity))]
    public int RoleId { get; set; }

    [Required]
    [ForeignKey(nameof(LanguageEntity))]
    public int LanguageId { get; set; }

    public virtual RoleEntity Role { get; set; } = null!;
    public virtual LanguageEntity Language { get; set; } = null!;
    public virtual ICollection<SkillEntity> Skills { get; set; }

}
