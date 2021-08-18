using Microsoft.EntityFrameworkCore;
using InvenTory.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace InvenTory.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<InvenTory.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<InvenTory.Models.Bill> Bill { get; set; }

        public DbSet<InvenTory.Models.BillType> BillType { get; set; }

        public DbSet<InvenTory.Models.Branch> Branch { get; set; }

        public DbSet<InvenTory.Models.CashBank> CashBank { get; set; }

        public DbSet<InvenTory.Models.Currency> Currency { get; set; }

        public DbSet<InvenTory.Models.Customer> Customer { get; set; }

        public DbSet<InvenTory.Models.CustomerType> CustomerType { get; set; }

        public DbSet<InvenTory.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<InvenTory.Models.Invoice> Invoice { get; set; }

        public DbSet<InvenTory.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<InvenTory.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<InvenTory.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<InvenTory.Models.PaymentType> PaymentType { get; set; }

        public DbSet<InvenTory.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<InvenTory.Models.Product> Product { get; set; }

        public DbSet<InvenTory.Models.ProductType> ProductType { get; set; }

        public DbSet<InvenTory.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<InvenTory.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<InvenTory.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<InvenTory.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<InvenTory.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<InvenTory.Models.SalesType> SalesType { get; set; }

        public DbSet<InvenTory.Models.Shipment> Shipment { get; set; }

        public DbSet<InvenTory.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<InvenTory.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<InvenTory.Models.Vendor> Vendor { get; set; }

        public DbSet<InvenTory.Models.VendorType> VendorType { get; set; }

        public DbSet<InvenTory.Models.Warehouse> Warehouse { get; set; }

        public DbSet<InvenTory.Models.UserProfile> UserProfile { get; set; }
    }
}
