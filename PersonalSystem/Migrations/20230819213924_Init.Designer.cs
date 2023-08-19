﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PersonalSystem;

#nullable disable

namespace PersonalSystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230819213924_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PersonalSystem.Shared.Avdelning", b =>
                {
                    b.Property<int>("AvdelningId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AvdelningId"));

                    b.Property<string>("AvdelningName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AvdelningId");

                    b.ToTable("Avdelning");
                });

            modelBuilder.Entity("PersonalSystem.Shared.Personal", b =>
                {
                    b.Property<int>("PersonalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PersonalId"));

                    b.Property<int>("AvdelningId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ManNumber")
                        .HasColumnType("int");

                    b.HasKey("PersonalId");

                    b.HasIndex("AvdelningId");

                    b.ToTable("Personal");
                });

            modelBuilder.Entity("PersonalSystem.Shared.Personal", b =>
                {
                    b.HasOne("PersonalSystem.Shared.Avdelning", "Avdelning")
                        .WithMany("Personals")
                        .HasForeignKey("AvdelningId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avdelning");
                });

            modelBuilder.Entity("PersonalSystem.Shared.Avdelning", b =>
                {
                    b.Navigation("Personals");
                });
#pragma warning restore 612, 618
        }
    }
}