namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NamiraDbContext : DbContext
    {
        public NamiraDbContext()
            : base("name=NamiraDbContext")
        {
        }

        public virtual DbSet<categories> categories { get; set; }
        public virtual DbSet<colors> colors { get; set; }
        public virtual DbSet<OrderForm> OrderForm { get; set; }
        public virtual DbSet<OrderItem> OrderItem { get; set; }
        public virtual DbSet<pictures> pictures { get; set; }
        public virtual DbSet<products> products { get; set; }
        public virtual DbSet<productVariants> productVariants { get; set; }
        public virtual DbSet<reviews> reviews { get; set; }
        public virtual DbSet<sizes> sizes { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<wishlists> wishlists { get; set; }
        public virtual DbSet<vproduct> vproduct { get; set; }
        public virtual DbSet<vproducts> vproducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderItem>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<products>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<products>()
                .Property(e => e.Thumb)
                .IsUnicode(false);

            modelBuilder.Entity<productVariants>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<productVariants>()
                .Property(e => e.OutPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<users>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Gmail)
                .IsUnicode(false);

            modelBuilder.Entity<users>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<vproduct>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<vproduct>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vproduct>()
                .Property(e => e.OutPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vproduct>()
                .Property(e => e.Thumb)
                .IsUnicode(false);

            modelBuilder.Entity<vproducts>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<vproducts>()
                .Property(e => e.Thumb)
                .IsUnicode(false);

            modelBuilder.Entity<vproducts>()
                .Property(e => e.InPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<vproducts>()
                .Property(e => e.OutPrice)
                .HasPrecision(19, 4);
        }
    }
}
