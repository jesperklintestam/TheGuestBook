﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TheGuestBook.Models;

namespace TheGuestBook.Migrations
{
    [DbContext(typeof(TheGuestBookContext))]
    [Migration("20190616164423_UpdateDb2")]
    partial class UpdateDb2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TheGuestBook.Models.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Author");

                    b.Property<string>("AuthorId");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("MessageBody");

                    b.Property<int>("NumberOfLikes");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Message");
                });
#pragma warning restore 612, 618
        }
    }
}
