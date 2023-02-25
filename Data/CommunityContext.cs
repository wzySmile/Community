using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Community.Models;

namespace Community.Data
{
    public class CommunityContext : DbContext
    {
        public CommunityContext (DbContextOptions<CommunityContext> options)
            : base(options)
        {
        }

        public DbSet<Community.Models.News> News { get; set; }
    }
}
