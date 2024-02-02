using gym_management.Models.Entites;
using Microsoft.EntityFrameworkCore;

namespace gym_management.Context
{
    public class GymMangagementDbContext : DbContext
    {
       
        public GymMangagementDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.
        }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Client>Clients { get; set; }
        public virtual DbSet<ClientCoach> ClientCoaches { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Employee>Employees { get; set; }
        public virtual DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }
        public virtual DbSet<Subscription>Subscriptions { get; set; }
        public virtual DbSet<SubscriptionCoach>SubscriptionCoaches { get; set; }
        public virtual DbSet<User> Users { get; set; }


    }
}
