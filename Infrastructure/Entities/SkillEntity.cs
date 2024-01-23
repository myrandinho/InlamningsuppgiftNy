

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Entities;



[Index(nameof(Skill), IsUnique = true)]
public class SkillEntity
{
    [Key]
    public int Id { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string Skill { get; set; } = null!;

    public virtual ICollection<UserEntity> Users { get; set; }
}
