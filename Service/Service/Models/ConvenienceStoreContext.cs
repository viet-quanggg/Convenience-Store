 using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

#nullable disable

namespace Service.Models
{
    public partial class ConvenienceStoreContext : DbContext
    {
        public ConvenienceStoreContext()
        {
        }

        public ConvenienceStoreContext(DbContextOptions<ConvenienceStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Bill> Bills { get; set; }  
        public virtual DbSet<BillDetail> BillDetails { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<ExportBill> ExportBills { get; set; }
        public virtual DbSet<ImportBill> ImportBills { get; set; }
        public virtual DbSet<Merchandise> Merchandises { get; set; }
        public virtual DbSet<Provider> Providers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        private string GetConnectionString()
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true)
                .Build();
            var strConn = config["ConnectionStrings:ConvenienceStore"];
            return strConn;
        }
 

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.AccId)
                    .HasName("PK__Account__A471AFDA1AC3E71F");

                entity.ToTable("Account");

                entity.Property(e => e.AccId).HasColumnName("accId");

                entity.Property(e => e.AccAddress)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("accAddress");

                entity.Property(e => e.AccCreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("accCreatedTime");

                entity.Property(e => e.AccDob)
                    .HasColumnType("date")
                    .HasColumnName("accDOB");

                entity.Property(e => e.AccName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("accName");

                entity.Property(e => e.AccPass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accPass");

                entity.Property(e => e.AccPhone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("accPhone");

                entity.Property(e => e.AccRole).HasColumnName("accRole");
            });

            modelBuilder.Entity<Bill>(entity =>
            {
                entity.ToTable("Bill");

                entity.Property(e => e.BillId).HasColumnName("billId");

                entity.Property(e => e.AccId).HasColumnName("accId");

                entity.Property(e => e.BillCreatedTime)
                    .HasColumnType("datetime")
                    .HasColumnName("billCreatedTime");

                entity.Property(e => e.MerId).HasColumnName("merId");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.AccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__accId__1FCDBCEB");

                entity.HasOne(d => d.Mer)
                    .WithMany(p => p.Bills)
                    .HasForeignKey(d => d.MerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bill__merId__20C1E124");
            });

            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BillDetail");

                entity.Property(e => e.BillDetailId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("billDetailId");

                entity.Property(e => e.BillId).HasColumnName("billId");

                entity.Property(e => e.BillMerPrice).HasColumnName("billMerPrice");

                entity.Property(e => e.BillMerQuanity).HasColumnName("billMerQuanity");

                entity.Property(e => e.MerId).HasColumnName("merId");

                entity.HasOne(d => d.Bill)
                    .WithMany()
                    .HasForeignKey(d => d.BillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillDetai__billI__22AA2996");

                entity.HasOne(d => d.Mer)
                    .WithMany()
                    .HasForeignKey(d => d.MerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BillDetai__merId__239E4DCF");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CusId)
                    .HasName("PK__Customer__BA9897F3D711702E");

                entity.ToTable("Customer");

                entity.Property(e => e.CusId).HasColumnName("cusId");

                entity.Property(e => e.CusDob)
                    .HasColumnType("date")
                    .HasColumnName("cusDOB");

                entity.Property(e => e.CusGender).HasColumnName("cusGender");

                entity.Property(e => e.CusName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("cusName");

                entity.Property(e => e.CusPhone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("cusPhone");
            });

            modelBuilder.Entity<ExportBill>(entity =>
            {
                entity.HasKey(e => e.ExId)
                    .HasName("PK__ExportBi__38F47E584503E6A0");

                entity.ToTable("ExportBill");

                entity.Property(e => e.ExId).HasColumnName("exId");

                entity.Property(e => e.AccId).HasColumnName("accId");

                entity.Property(e => e.CusId).HasColumnName("cusId");

                entity.Property(e => e.ExDate)
                    .HasColumnType("datetime")
                    .HasColumnName("exDate");

                entity.Property(e => e.ExManager)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("exManager");

                entity.HasOne(d => d.Acc)
                    .WithMany(p => p.ExportBills)
                    .HasForeignKey(d => d.AccId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ExportBil__accId__182C9B23");

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.ExportBills)
                    .HasForeignKey(d => d.CusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ExportBil__cusId__1920BF5C");
            });

            modelBuilder.Entity<ImportBill>(entity =>
            {
                entity.HasKey(e => e.ImId)
                    .HasName("PK__ImportBi__9BF4082F37221A6B");

                entity.ToTable("ImportBill");

                entity.Property(e => e.ImId).HasColumnName("imId");

                entity.Property(e => e.ImDate)
                    .HasColumnType("datetime")
                    .HasColumnName("imDate");

                entity.Property(e => e.ImName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("imName");

                entity.Property(e => e.ImProvider)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("imProvider");

                entity.Property(e => e.MerId).HasColumnName("merId");

                entity.Property(e => e.ProId).HasColumnName("proId");

                entity.HasOne(d => d.Mer)
                    .WithMany(p => p.ImportBills)
                    .HasForeignKey(d => d.MerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ImportBil__merId__1BFD2C07");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.ImportBills)
                    .HasForeignKey(d => d.ProId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ImportBil__proId__1CF15040");
            });

            modelBuilder.Entity<Merchandise>(entity =>
            {
                entity.HasKey(e => e.MerId)
                    .HasName("PK__Merchand__31EEDA21CA29ED36");

                entity.ToTable("Merchandise");

                entity.Property(e => e.MerId).HasColumnName("merId");

                entity.Property(e => e.MerDescription)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("merDescription");

                entity.Property(e => e.MerName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("merName");

                entity.Property(e => e.MerPrice).HasColumnName("merPrice");

                entity.Property(e => e.MerQuantity).HasColumnName("merQuantity");

                entity.Property(e => e.MerUnit)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("merUnit");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasKey(e => e.ProId)
                    .HasName("PK__Provider__5BBBEEF5A6093BF3");

                entity.ToTable("Provider");

                entity.Property(e => e.ProId).HasColumnName("proId");

                entity.Property(e => e.ProDob)
                    .HasColumnType("date")
                    .HasColumnName("proDOB");

                entity.Property(e => e.ProGender).HasColumnName("proGender");

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("proName");

                entity.Property(e => e.ProPhone)
                    .IsRequired()
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("proPhone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
