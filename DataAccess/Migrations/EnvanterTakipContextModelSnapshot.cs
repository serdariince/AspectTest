﻿// <auto-generated />

using DataAccess.Concrete.EntitiyRepository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace DataAccess.Migrations
{
    [DbContext(typeof(EnvanterTakipContext))]
    internal class EnvanterTakipContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("Entities.Ip", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("IpName")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Ipler");
            });

            modelBuilder.Entity("Entities.Kamera", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<int?>("IpId")
                    .HasColumnType("INTEGER");

                b.Property<string>("Marka")
                    .HasColumnType("TEXT");

                b.Property<string>("Model")
                    .HasColumnType("TEXT");

                b.Property<string>("SeriNo")
                    .HasColumnType("TEXT");

                b.Property<int?>("TesisId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("IpId")
                    .IsUnique();

                b.HasIndex("TesisId");

                b.ToTable("Kameralar");
            });

            modelBuilder.Entity("Entities.KayitProgrami", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Ad")
                    .HasColumnType("TEXT");

                b.Property<string>("Kanal")
                    .HasColumnType("TEXT");

                b.Property<int?>("TesisId")
                    .HasColumnType("INTEGER");

                b.HasKey("Id");

                b.HasIndex("TesisId")
                    .IsUnique();

                b.ToTable("KayitProgramlari");
            });

            modelBuilder.Entity("Entities.Tesis", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<string>("Adres")
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Tesisler");
            });

            modelBuilder.Entity("Entities.Kamera", b =>
            {
                b.HasOne("Entities.Ip", "Ip")
                    .WithOne("Kamera")
                    .HasForeignKey("Entities.Kamera", "IpId");

                b.HasOne("Entities.Tesis", "Tesis")
                    .WithMany("Kameralar")
                    .HasForeignKey("TesisId");

                b.Navigation("Ip");

                b.Navigation("Tesis");
            });

            modelBuilder.Entity("Entities.KayitProgrami", b =>
            {
                b.HasOne("Entities.Tesis", "Tesis")
                    .WithOne("KayitProgrami")
                    .HasForeignKey("Entities.KayitProgrami", "TesisId");

                b.Navigation("Tesis");
            });

            modelBuilder.Entity("Entities.Ip", b => { b.Navigation("Kamera"); });

            modelBuilder.Entity("Entities.Tesis", b =>
            {
                b.Navigation("Kameralar");

                b.Navigation("KayitProgrami");
            });
#pragma warning restore 612, 618
        }
    }
}