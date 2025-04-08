using Employee_Main.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Employee_Main.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
            
        }
        public DbSet<role> Role { get; set; }
        public DbSet<departments> Department { get; set; }
        public DbSet<employee> Emp {  get; set; }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Project> Projects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) // this is used when i have foregin keys and want to change the structure of the table 
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<employee>()
                .HasOne(e => e.Role)
                .WithMany(e => e.Employees)
                .HasForeignKey(e => e.RoleId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<employee>()
                .HasOne(e => e.Department)
                .WithMany(d => d.Employees)
                .HasForeignKey(e => e.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Project>()
                .HasOne(p=>p.emp)
                .WithMany(d=>d.Projects)
                .HasForeignKey(e=>e.empId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Project>()
             .HasOne(p => p.client)
             .WithMany(d => d.Projects)
             .HasForeignKey(e => e.clientId)
             .OnDelete(DeleteBehavior.Cascade);
        }
    }
               
            

    }
