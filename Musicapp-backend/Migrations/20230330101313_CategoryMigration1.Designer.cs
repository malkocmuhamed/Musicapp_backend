﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Musicapp_backend.Models;

#nullable disable

namespace Musicapp_backend.Migrations
{
    [DbContext(typeof(musicappDBContext))]
    [Migration("20230330101313_CategoryMigration1")]
    partial class CategoryMigration1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("Latin1_General_CI_AI")
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Musicapp_backend.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("category_name");

                    b.HasKey("CategoryId");

                    b.ToTable("category", (string)null);
                });

            modelBuilder.Entity("Musicapp_backend.Models.Song", b =>
                {
                    b.Property<int>("SongId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("song_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SongId"));

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("created_date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("EditedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("edited_date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("IsFavourite")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("is_favourite");

                    b.Property<string>("SongArtist")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("song_artist");

                    b.Property<string>("SongName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("song_name");

                    b.Property<int?>("SongRating")
                        .HasColumnType("int")
                        .HasColumnName("song_rating");

                    b.Property<string>("SongUrl")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("song_url");

                    b.HasKey("SongId");

                    b.HasIndex("CategoryId");

                    b.ToTable("song", (string)null);
                });

            modelBuilder.Entity("Musicapp_backend.Models.Song", b =>
                {
                    b.HasOne("Musicapp_backend.Models.Category", "Category")
                        .WithMany("Songs")
                        .HasForeignKey("CategoryId")
                        .HasConstraintName("fk_song_category");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Musicapp_backend.Models.Category", b =>
                {
                    b.Navigation("Songs");
                });
#pragma warning restore 612, 618
        }
    }
}
