using Microsoft.EntityFrameworkCore;
using LegionCommand.Data;

namespace LegionCommand.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new LegionCommandContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<LegionCommandContext>>()))
            {
                if (context == null || context.Unit == null)
                {
                    throw new ArgumentNullException("Null LegionCommandContext");
                }

                // Look for any Units.
                if (context.Unit.Any())
                {
                    return;   // DB has been seeded
                }

                context.Unit.AddRange(
                    new Unit
                    {
                        Name = "Count Dooku",
                        Description = "Darth Tyranus",
                        Rank = "Commander",
                        Points = 165,
                        UnitCard = "count_dooku_unitcard.jpeg",
                        Portrait = "count_dooku_portrait.jpeg",
                        Upgrades = "force,force,force,command"
                    },

                    new Unit
                    {
                        Name = "General Grievous",
                        Description = "Sinister Cyborg",
                        Rank = "Commander",
                        Points = 130,
                        UnitCard = "general_grievous_unitcard.jpeg",
                        Portrait = "general_grievous_portrait.jpeg",
                        Upgrades = "command,command,training,gear"
                    },

                    new Unit
                    {
                        Name = "Poggle The Lesser",
                        Description = "Public Leader of the Geonocians",
                        Rank = "Commander",
                        Points = 80,
                        UnitCard = "poggle_unitcard.jpeg",
                        Portrait = "poggle_portrait.jpeg",
                        Upgrades = "command,command,comms,gear"
                    },

                    new Unit
                    {
                        Name = "Super Tactical Droid",
                        Description = "Kalani",
                        Rank = "Commander",
                        Points = 85,
                        UnitCard = "poggle_unitcard.jpeg",
                        Portrait = "poggle_portrait.jpeg",
                        Upgrades = "command,command,command,comms,gear"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
