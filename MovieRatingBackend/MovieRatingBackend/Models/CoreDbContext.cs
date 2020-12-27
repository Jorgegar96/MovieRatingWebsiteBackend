using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MovieRatingBackend.Models
{
    public partial class CoreDbContext : DbContext
    {
        public CoreDbContext()
        {
        }

        public CoreDbContext(DbContextOptions<CoreDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Reaction> Reactions { get; set; }
        public virtual DbSet<Watchlist> Watchlists { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=movieratingsdatabase.cetjh61vdebf.us-east-2.rds.amazonaws.com,1433;Initial Catalog=MovieRatingsDB;User ID=mrdbadmin;Password=devdb2020#;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.Eventdate).IsUnicode(false);

                entity.Property(e => e.ImdbId).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<Reaction>(entity =>
            {
                entity.Property(e => e.Eventdate).IsUnicode(false);

                entity.Property(e => e.ImdbId).IsUnicode(false);

                entity.Property(e => e.Reaction1).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            modelBuilder.Entity<Watchlist>(entity =>
            {
                entity.Property(e => e.Eventdate).IsUnicode(false);

                entity.Property(e => e.ImdbId).IsUnicode(false);

                entity.Property(e => e.Poster).IsUnicode(false);

                entity.Property(e => e.UserId).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
