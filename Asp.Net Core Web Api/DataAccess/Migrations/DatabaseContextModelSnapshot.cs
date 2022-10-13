﻿// <auto-generated />
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Entities.Concrete.Ders", b =>
                {
                    b.Property<int>("DersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DersAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DersKontenjan")
                        .HasColumnType("int");

                    b.Property<bool>("DersStatus")
                        .HasColumnType("bit");

                    b.Property<int>("HocaId")
                        .HasColumnType("int");

                    b.HasKey("DersID");

                    b.HasIndex("HocaId");

                    b.ToTable("Ders");
                });

            modelBuilder.Entity("Entities.Concrete.Hoca", b =>
                {
                    b.Property<int>("HocaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("HocaAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HocaSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HocaID");

                    b.ToTable("Hocas");
                });

            modelBuilder.Entity("Entities.Concrete.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.Property<string>("OgrenciAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("OgrenciStatus")
                        .HasColumnType("bit");

                    b.Property<string>("OgrenciSınıf")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrenciID");

                    b.HasIndex("DersID");

                    b.ToTable("Ogrencis");
                });

            modelBuilder.Entity("Entities.Concrete.Ders", b =>
                {
                    b.HasOne("Entities.Concrete.Hoca", "Hoca")
                        .WithMany("Ders")
                        .HasForeignKey("HocaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Hoca");
                });

            modelBuilder.Entity("Entities.Concrete.Ogrenci", b =>
                {
                    b.HasOne("Entities.Concrete.Ders", "Ders")
                        .WithMany("Ogrencis")
                        .HasForeignKey("DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");
                });

            modelBuilder.Entity("Entities.Concrete.Ders", b =>
                {
                    b.Navigation("Ogrencis");
                });

            modelBuilder.Entity("Entities.Concrete.Hoca", b =>
                {
                    b.Navigation("Ders");
                });
#pragma warning restore 612, 618
        }
    }
}
