using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

using WebApplication1.Models;

namespace WebApplication1.DataAccesLayer
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Services> Services { get; set; }
        public DbSet<TeamMembers> TeamMembers { get; set; }
    }
}
