using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MusicManagamentSystem.Models;

namespace MusicManagamentSystem.Data
{
    public class MusicManagamentSystemContext : DbContext
    {
        public MusicManagamentSystemContext (DbContextOptions<MusicManagamentSystemContext> options)
            : base(options)
        {
        }

        public DbSet<MusicManagamentSystem.Models.User> User { get; set; } = default!;

        public DbSet<MusicManagamentSystem.Models.Playlist>? Playlist { get; set; }

        public DbSet<MusicManagamentSystem.Models.Song>? Song { get; set; }
    }
}
