using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace D2Codex
{
    public partial class D2ItemsContext : DbContext
    {
        public D2ItemsContext()
        {
        }

        public D2ItemsContext(DbContextOptions<D2ItemsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BaseTypes> BaseTypes { get; set; } = null!;
        public virtual DbSet<Items> Items { get; set; } = null!;
        public virtual DbSet<ItemMods> ItemMods { get; set; } = null!;
        public virtual DbSet<ItemTypes> ItemTypes { get; set; } = null!;
        public virtual DbSet<Mods> Mods { get; set; } = null!;
        public virtual DbSet<Runes> Runes { get; set; } = null!;
        public virtual DbSet<Sets> Sets { get; set; } = null!;
        public virtual DbSet<Skills> Skills { get; set; } = null!;
        public virtual DbSet<SubTypes> SubTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Initial Catalog=D2Items;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseTypes>(entity =>
            {
                entity.ToTable("T_BaseTypes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsMelee).HasColumnName("isMelee");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Items>(entity =>
            {
                entity.ToTable("T_Items");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseType1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("baseType1");

                entity.Property(e => e.BaseType2)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("baseType2");

                entity.Property(e => e.BaseType3)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("baseType3");

                entity.Property(e => e.Class)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("class");

                entity.Property(e => e.Dex).HasColumnName("dex");

                entity.Property(e => e.Ladder).HasColumnName("ladder");

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.Resurrected).HasColumnName("resurrected");

                entity.Property(e => e.Rune1)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("rune1");

                entity.Property(e => e.Rune2)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("rune2");

                entity.Property(e => e.Rune3)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("rune3");

                entity.Property(e => e.Rune4)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("rune4");

                entity.Property(e => e.Rune5)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("rune5");

                entity.Property(e => e.Rune6)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("rune6");

                entity.Property(e => e.Sockets).HasColumnName("sockets");

                entity.Property(e => e.Str).HasColumnName("str");

                entity.Property(e => e.SubType).HasColumnName("subType");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<ItemMods>(entity =>
            {
                entity.ToTable("T_ItemMods");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ItemId).HasColumnName("itemID");

                entity.Property(e => e.ModId).HasColumnName("modID");

                entity.Property(e => e.SetBonusId).HasColumnName("setBonusID");

                entity.Property(e => e.SetId).HasColumnName("setID");

                entity.Property(e => e.Skill)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("skill");

                entity.Property(e => e.Value1).HasColumnName("value1");

                entity.Property(e => e.Value2).HasColumnName("value2");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.TItemMods)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_ItemMods_T_Items");

                entity.HasOne(d => d.Mod)
                    .WithMany(p => p.TItemMods)
                    .HasForeignKey(d => d.ModId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_T_ItemMods_T_Mods");
            });

            modelBuilder.Entity<ItemTypes>(entity =>
            {
                entity.ToTable("T_ItemTypes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseTypeId).HasColumnName("baseTypeID");

                entity.Property(e => e.ItemId).HasColumnName("itemID");
            });

            modelBuilder.Entity<Mods>(entity =>
            {
                entity.ToTable("T_Mods");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("amountType");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Runes>(entity =>
            {
                entity.ToTable("T_Runes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Sets>(entity =>
            {
                entity.ToTable("T_Sets");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.ToTable("T_Skills");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Class)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("class");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SubTypes>(entity =>
            {
                entity.ToTable("T_SubTypes");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseType)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("baseType");

                entity.Property(e => e.Class)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("class");

                entity.Property(e => e.Dex).HasColumnName("dex");

                entity.Property(e => e.Lvl).HasColumnName("lvl");

                entity.Property(e => e.MaxSockets).HasColumnName("maxSockets");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Quality).HasColumnName("quality");

                entity.Property(e => e.Str).HasColumnName("str");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
