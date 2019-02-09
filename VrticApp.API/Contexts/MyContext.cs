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
    //Context Test
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



        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityComment> ActivityComments { get; set; }
        public DbSet<ActivityGrade> ActivityGrades { get; set; }
        public DbSet<ActivityType> ActivityTypes { get; set; }
        public DbSet<Child> Children { get; set; }
        public DbSet<ChildAbsence> ChildAbsences { get; set; }
        public DbSet<ChildActivity> ChildActivities { get; set; }
        public DbSet<ChildMembership> ChildMemberships { get; set; }
        public DbSet<ChildPhoto> ChildPhotos { get; set; }
        public DbSet<Cost> Costs { get; set; }
        public DbSet<CostType> CostTypes { get; set; }
        public DbSet<DeletedMessage> DeletedMessages { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<DepartmentUser> DepartmentUsers { get; set; }
        public DbSet<DifficultyLevel> DifficultyLevels { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Kindergarten> Kindergartens { get; set; }
        public DbSet<KindergartenOffice> KindergartenOffices { get; set; }
        public DbSet<MembershipType> MembershipTypes { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Office> Offices { get; set; }
        public DbSet<OfficeDepartment> OfficeDepartments { get; set; }
        public DbSet<OfficeCost> OfficeCosts { get; set; }
        public DbSet<Settings> Settings { get; set; }
        public DbSet<UserActivity> UserActivities { get; set; }
        public DbSet<UserChild> UserChildren { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }



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
