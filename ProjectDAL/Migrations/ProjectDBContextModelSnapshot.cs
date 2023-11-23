﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectDAL;

#nullable disable

namespace ProjectDAL.Migrations
{
    [DbContext(typeof(ProjectDBContext))]
    partial class ProjectDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ProjectDAL.Facility", b =>
                {
                    b.Property<int>("FacilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilityId"), 1L, 1);

                    b.Property<string>("FacilityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAvailable")
                        .HasColumnType("bit");

                    b.HasKey("FacilityId");

                    b.ToTable("Facilities");
                });

            modelBuilder.Entity("ProjectDAL.GatePass", b =>
                {
                    b.Property<int>("GatePassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GatePassId"), 1L, 1);

                    b.Property<int>("FlatNumber")
                        .HasColumnType("int");

                    b.Property<int?>("OwnerFlatNumber")
                        .HasColumnType("int");

                    b.Property<string>("VisitorsName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GatePassId");

                    b.HasIndex("OwnerFlatNumber");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("ProjectDAL.Owner", b =>
                {
                    b.Property<int>("FlatNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FlatNumber"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FlatNumber");

                    b.ToTable("FlatOwner");
                });

            modelBuilder.Entity("ProjectDAL.GatePass", b =>
                {
                    b.HasOne("ProjectDAL.Owner", null)
                        .WithMany("gatePasses")
                        .HasForeignKey("OwnerFlatNumber");
                });

            modelBuilder.Entity("ProjectDAL.Owner", b =>
                {
                    b.Navigation("gatePasses");
                });
#pragma warning restore 612, 618
        }
    }
}
