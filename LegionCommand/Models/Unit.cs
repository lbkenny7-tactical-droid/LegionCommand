using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegionCommand.Models;

public class Unit
{
    public int Id { get; set; }
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Name { get; set; }
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Description { get; set; }
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Rank { get; set; }
    [Range(1, 500)]
    public int? Points { get; set; }
    public string? UnitCard { get; set; }
    public string? Portrait { get; set; }
    [StringLength(60, MinimumLength = 3)]
    public string? Upgrades { get; set; }
    [StringLength(10, MinimumLength = 3)]
    [Required]
    public string Faction { get; set; } = string.Empty;
}