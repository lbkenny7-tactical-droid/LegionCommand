using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LegionCommand.Models;

public class Unit
{
    public int Id { get; set; }
    //public string? Faction { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Rank { get; set; }
    public int? Points { get; set; }
    [Display(Name = "Unit Card")]
    public string? UnitCard { get; set; }
    public string? Portrait { get; set; }
    public string? Upgrades { get; set; }
}