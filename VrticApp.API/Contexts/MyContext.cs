using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VrticApp.API.Models;

namespace VrticApp.API.Contexts
{
    public class MyContext: IdentityDbContext
                            <
                                User,
                                Role,
                                int,
                                IdentityUserClaim<int>,
                                UserRole,
                                IdentityUserLogin<int>,
                                IdentityRoleClaim<int>,
                                IdentityUserToken<int>
                            >
    {

        public MyContext(DbContextOptions<MyContext> options): base(options)
        {

        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Kindergarten> Kindergartens { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<KindergartenOffice> KindergartenOffices { get; set; }
        public DbSet<OfficeDepartment> OfficeDepartments { get; set; }




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<UserRole>(userRole =>
            {
                userRole.HasKey(ur => new { ur.UserId, ur.RoleId });

                userRole.HasOne(ur => ur.Role)
                                       .WithMany(r => r.UserRoles)
                                       .HasForeignKey(ur => ur.RoleId)
                                       .IsRequired();


                userRole.HasOne(ur => ur.User)
                      .WithMany(r => r.UserRoles)
                      .HasForeignKey(ur => ur.UserId)
                      .IsRequired();
            });

            foreach (var relationship in builder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }


    }
}
