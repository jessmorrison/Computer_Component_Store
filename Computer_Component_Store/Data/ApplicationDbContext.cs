using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Computer_Component_Store.Data
{
    public class ApplicationDbContext : IdentityDbContext<ComputerUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<ComputerComponentProduct> ComputerComponentProducts { get; set; }
        public DbSet<ComputerComponentCart> ComputerComponentCarts { get; set; }
        public DbSet<ComputerComponentCartItem> ComputerComponentCartItems { get; set; }
        public DbSet<ComputerComponentOrder> ComputerComponentOrders { get; set; }
        public DbSet<ComputerComponentOrderItem> ComputerComponentOrderItems { get; set; }
    }

    public class ComputerUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ComputerComponentCart ComputerComponentCart { get; set; }
    }

    public class ComputerComponentProduct
    {
        public ComputerComponentProduct()
        {
            this.ComputerComponentCartItems = new HashSet<ComputerComponentCartItem>();
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public decimal? Price { get; set; }
        public string Category { get; set; }
        public string CompatibilityType { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastModified { get; set; }
        public ICollection<ComputerComponentCartItem> ComputerComponentCartItems { get; set; }
    }

    public class ComputerComponentCart
    {
        public ComputerComponentCart()
        {
            this.ComputerComponentCartItems = new HashSet<ComputerComponentCartItem>();
        }
        public int ID { get; set; }
        public Guid? CookieID { get; set; }
        public ICollection<ComputerComponentCartItem> ComputerComponentCartItems { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastModified { get; set; }       
    }
    public class ComputerComponentCartItem
    {
        public int ID { get; set; }
        public ComputerComponentCart ComputerComponentCart { get; set; }
        public int Quantity { get; set; }
        public ComputerComponentProduct ComputerComponentProduct { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastModified { get; set; }
    }

    public class ComputerComponentOrder
    {
        public ComputerComponentOrder()
        {
            this.ComputerComponentOrderItems = new HashSet<ComputerComponentOrderItem>();
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid ID { get; set; }
        public string ContactEmail { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ShippingStreet { get; set; }
        public string ShippingCity { get; set; }
        public string ShippingState { get; set; }
        public string ShippingPostalCode { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastModified { get; set; }
        public ICollection<ComputerComponentOrderItem> ComputerComponentOrderItems { get; set; }
    }
    public class ComputerComponentOrderItem
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal? ProductPrice { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? LastModified { get; set; }
        public ComputerComponentOrder ComputerComponentOrder { get; set; }
    }
}