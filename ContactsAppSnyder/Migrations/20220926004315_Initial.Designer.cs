﻿// <auto-generated />
using ContactsAppSnyder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ContactsAppSnyder.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20220926004315_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ContactsAppSnyder.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.ToTable("Contact");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Address = "123 Sunshine Lane",
                            Name = "Christi",
                            Phone = "123-456-7890"
                        },
                        new
                        {
                            ContactId = 2,
                            Address = "346 Sunshine Lane",
                            Name = "Sam",
                            Phone = "234-567-8901"
                        },
                        new
                        {
                            ContactId = 3,
                            Address = "346 Sunshine Lane",
                            Name = "George",
                            Phone = "234-567-8901"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
