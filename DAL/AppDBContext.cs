using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Toomeet_Pos.Entites;
using Toomeet_Pos.Entites.orders;
using Toomeet_Pos.Entites.Products;
using Toomeet_Pos.Entites.Roles;

namespace Toomeet_Pos.DAL
{
    public class AppDBContext : DbContext 
    {
        public AppDBContext() : base  ( nameOrConnectionString: "Default")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");

        
            // Mỗi cửa hàng có thể có nhiều nhân viên
            modelBuilder.Entity<Store>()
               .HasMany(s => s.Staffs)
               .WithRequired(staff => staff.Workplace)
               .HasForeignKey(staff => staff.WorkplaceId)
               .WillCascadeOnDelete(true);


            // Mỗi nhân viên chỉ có thể làm việc tại 1 cửa hàng
            modelBuilder.Entity<Staff>()
               .HasRequired(staff => staff.Workplace)
               .WithMany()
               .HasForeignKey(staff => staff.WorkplaceId)
               .WillCascadeOnDelete(false);


            // Mỗi role là duy nhất trong 1 cửa hàng
            modelBuilder.Entity<Role>()
                .HasIndex(r => new { r.StoreId, r.Name })
                .IsUnique(true);


            // Mỗi danh mục sản phẩm là duy nhất trong cửa hàng
            modelBuilder.Entity<Category>()
                .HasIndex(c => new { c.StoreId, c.Code })
                .IsUnique(true);

            // Mỗi thương hiệu là duy nhất trong 1 cửa hàng
            modelBuilder.Entity<Brand>()
             .HasIndex(b => new { b.StoreId, b.Name })
             .IsUnique(true);
        }


        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync()
        {
            AddTimestamps();
            return await base.SaveChangesAsync();
        }   


        public DbSet<Store> Store { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<RoleCustomer> RoleCustomer { get; set; }
        public DbSet<RoleInvetoryInspection> RoleInvetoryInspection { get; set; }
        public DbSet<RoleManage> RoleManage { get; set; }
        public DbSet<RoleOrder> RoleOrder { get; set; }
        public DbSet<RoleProduct> RoleProduct { get; set; }
        public DbSet<RoleStaff> RoleStaff { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Order> Order { get; set; }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    BaseEntity e = (BaseEntity)entity.Entity;

                   e.CreatedAt = now;
                }
                ((BaseEntity)entity.Entity).UpdatedAt = now;
            }
        }
    }
}
