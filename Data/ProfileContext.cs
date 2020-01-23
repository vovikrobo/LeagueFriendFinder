using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace LeagueFriendFinder.Models
{
    public class ProfileContext : DbContext
    {
        public ProfileContext(DbContextOptions<ProfileContext> options)
            :base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }
        public DbSet<Profile> Profiles { get; set; }
    }
}
