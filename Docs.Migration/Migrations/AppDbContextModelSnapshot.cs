﻿// <auto-generated />
using System;
using Docs.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Docs.Migrations.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Docs.Core.Package", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(600);

                    b.Property<string>("GitRepo")
                        .HasMaxLength(100);

                    b.Property<bool>("HasDocumentation");

                    b.Property<bool>("IsDisplayed");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Packages");
                });

            modelBuilder.Entity("Docs.Core.PackageTag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PackageId")
                        .IsRequired();

                    b.Property<int?>("TagId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PackageId");

                    b.HasIndex("TagId");

                    b.ToTable("PackageTags");
                });

            modelBuilder.Entity("Docs.Core.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Importance");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("Docs.Core.PackageTag", b =>
                {
                    b.HasOne("Docs.Core.Package", "Package")
                        .WithMany()
                        .HasForeignKey("PackageId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Docs.Core.Tag", "Tag")
                        .WithMany()
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
