﻿// <auto-generated />
using System;
using Computer_Component_Store.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Computer_Component_Store.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Computer_Component_Store.Data.ComputerComponentCart", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("CookieID");

                    b.Property<DateTime?>("Created");

                    b.Property<DateTime?>("LastModified");

                    b.HasKey("ID");

                    b.ToTable("ComputerComponentCarts");
                });

            modelBuilder.Entity("Computer_Component_Store.Data.ComputerComponentCartItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ComputerComponentCartID");

                    b.Property<int?>("ComputerComponentProductID1");

                    b.Property<DateTime?>("Created");

                    b.Property<DateTime?>("LastModified");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("ComputerComponentCartID");

                    b.HasIndex("ComputerComponentProductID1");

                    b.ToTable("ComputerComponentCartItems");
                });

            modelBuilder.Entity("Computer_Component_Store.Data.ComputerComponentOrder", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ContactEmail");

                    b.Property<DateTime?>("Created");

                    b.Property<string>("FirstName");

                    b.Property<DateTime?>("LastModified");

                    b.Property<string>("LastName");

                    b.Property<string>("ShippingCity");

                    b.Property<string>("ShippingPostalCode");

                    b.Property<string>("ShippingState");

                    b.Property<string>("ShippingStreet");

                    b.HasKey("ID");

                    b.ToTable("ComputerComponentOrders");
                });

            modelBuilder.Entity("Computer_Component_Store.Data.ComputerComponentOrderItem", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<Guid?>("ComputerComponentOrderID");

                    b.Property<DateTime?>("Created");

                    b.Property<DateTime?>("LastModified");

                    b.Property<string>("ProductDescription");

                    b.Property<int?>("ProductID");

                    b.Property<string>("ProductName");

                    b.Property<decimal?>("ProductPrice");

                    b.Property<int>("Quantity");

                    b.HasKey("ID");

                    b.HasIndex("ComputerComponentOrderID");

                    b.ToTable("ComputerComponentOrderItems");
                });

            modelBuilder.Entity("Computer_Component_Store.Data.ComputerComponentProduct", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category");

                    b.Property<string>("CompatibilityType");

                    b.Property<DateTime?>("Created");

                    b.Property<string>("Description");

                    b.Property<string>("ImageURL");

                    b.Property<DateTime?>("LastModified");

                    b.Property<string>("Name");

                    b.Property<decimal?>("Price");

                    b.HasKey("ID");

                    b.ToTable("ComputerComponentProducts");
                });

            modelBuilder.Entity("Computer_Component_Store.Data.ComputerUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<int?>("ComputerComponentCartID");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("ComputerComponentCartID");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Computer_Component_Store.Data.ComputerComponentCartItem", b =>
                {
                    b.HasOne("Computer_Component_Store.Data.ComputerComponentCart", "ComputerComponentCart")
                        .WithMany("ComputerComponentCartItems")
                        .HasForeignKey("ComputerComponentCartID");

                    b.HasOne("Computer_Component_Store.Data.ComputerComponentProduct", "ComputerComponentProduct")
                        .WithMany("ComputerComponentCartItems")
                        .HasForeignKey("ComputerComponentProductID1");
                });

            modelBuilder.Entity("Computer_Component_Store.Data.ComputerComponentOrderItem", b =>
                {
                    b.HasOne("Computer_Component_Store.Data.ComputerComponentOrder", "ComputerComponentOrder")
                        .WithMany("ComputerComponentOrderItems")
                        .HasForeignKey("ComputerComponentOrderID");
                });

            modelBuilder.Entity("Computer_Component_Store.Data.ComputerUser", b =>
                {
                    b.HasOne("Computer_Component_Store.Data.ComputerComponentCart", "ComputerComponentCart")
                        .WithMany()
                        .HasForeignKey("ComputerComponentCartID");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Computer_Component_Store.Data.ComputerUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Computer_Component_Store.Data.ComputerUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Computer_Component_Store.Data.ComputerUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Computer_Component_Store.Data.ComputerUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
