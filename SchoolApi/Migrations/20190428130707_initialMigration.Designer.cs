﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchoolApi.SchoolContext;

namespace SchoolApi.Migrations
{
    [DbContext(typeof(BooksContext))]
    [Migration("20190428130707_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.2-servicing-10034")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SchoolApi.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AuthorId");

                    b.Property<string>("Description")
                        .HasMaxLength(255);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<Guid?>("developerAuthorId");

                    b.HasKey("Id");

                    b.HasIndex("developerAuthorId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5b1c2b4d-48c7-402a-80c3-cc796ad49c6b"),
                            AuthorId = new Guid("d28888e9-2ba9-473e-a40f-e38cb54f9b35"),
                            Description = "Backend developers, i wish to work for Amazon South Africa",
                            Title = "C# and Java"
                        },
                        new
                        {
                            Id = new Guid("d8663e5e-7494-4f81-8739-6e0de1bea7ee"),
                            AuthorId = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            Description = "Backend developers, i wish to work for Amazon South Africa",
                            Title = "C# and Java"
                        });
                });

            modelBuilder.Entity("SchoolApi.Entities.DeveloperAuthor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = new Guid("d28888e9-2ba9-473e-a40f-e38cb54f9b35"),
                            FirstName = "Sydney",
                            LastName = "Hadebe"
                        },
                        new
                        {
                            Id = new Guid("da2fd609-d754-4feb-8acd-c4f9ff13ba96"),
                            FirstName = "C# Developer",
                            LastName = "Back-end Developer"
                        });
                });

            modelBuilder.Entity("SchoolApi.Entities.Book", b =>
                {
                    b.HasOne("SchoolApi.Entities.DeveloperAuthor", "developerAuthor")
                        .WithMany()
                        .HasForeignKey("developerAuthorId");
                });
#pragma warning restore 612, 618
        }
    }
}
