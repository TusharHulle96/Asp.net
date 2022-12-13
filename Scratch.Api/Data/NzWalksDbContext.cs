using Microsoft.EntityFrameworkCore;
using Scratch.Api.Models.Domain;
using ScratchDbContext.Api.Models.Domain;

namespace Scratch.Api.Data
{
    public class NzWalksDbContext : DbContext
    {
        public NzWalksDbContext(DbContextOptions<NzWalksDbContext> options) : base(options) 
        {
                    
        }
        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalksDifficulty { get; set; } 
    }
}


