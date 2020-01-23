﻿// <auto-generated />
using System;
using LeagueFriendFinder.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LeagueFriendFinder.Migrations
{
    [DbContext(typeof(ProfileContext))]
    [Migration("20191209012931_migration10")]
    partial class migration10
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LeagueFriendFinder.Models.Profile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentAboutHimself")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateOfLastModify")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfRegistrationInService")
                        .HasColumnType("datetime2");

                    b.Property<string>("InGameAccountNickname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActiveProfile")
                        .HasColumnType("bit");

                    b.Property<bool>("IsLicenseAccepted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSearchingForPlayingInTeam")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSearchingForPlayingRankeds")
                        .HasColumnType("bit");

                    b.Property<bool>("IsSearchingJustToFindNewFriends")
                        .HasColumnType("bit");

                    b.Property<string>("MostPlayedChampions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrefferedRole1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrefferedRole2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RankedDivision")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RankedLeague")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServerOfInGameAccount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VkontakteUserID")
                        .HasColumnType("int");

                    b.Property<string>("WhoIAmSearchingForComment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });
#pragma warning restore 612, 618
        }
    }
}
