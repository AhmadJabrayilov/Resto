﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestoBackEnd.DAL;

namespace RestoBackEnd.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RestoBackEnd.Models.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutImagrUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutTxt")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("About");
                });

            modelBuilder.Entity("RestoBackEnd.Models.AboutCard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AboutCardImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AboutCardtitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AboutCard");
                });

            modelBuilder.Entity("RestoBackEnd.Models.Beef", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryMealName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealPrice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("BeefMeal");
                });

            modelBuilder.Entity("RestoBackEnd.Models.PageIntro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("IntroTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PageIntro");
                });

            modelBuilder.Entity("RestoBackEnd.Models.Salmon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryMeal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MealPrice")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SalmonMeal");
                });

            modelBuilder.Entity("RestoBackEnd.Models.Slider", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Slider");
                });
#pragma warning restore 612, 618
        }
    }
}
