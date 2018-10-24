using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Computer_Component_Store.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}
        public DbSet<ComputerComponentProduct> ComputerComponentProducts { get; set; }
        public DbSet<ComputerComponentCart> ComputerComponentCarts { get; set; }
        public DbSet<ComputerComponentCartItem> ComputerComponentCartItems { get; set; }
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
}