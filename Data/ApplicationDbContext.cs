using CFMS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CFMS.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
                public DbSet<Feedback> FeedbackList { get; set; }
                public DbSet<Response> ResponseList { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Feedback>()
                .HasKey(c => c.FeedbackId);
            modelBuilder.Entity<Response>()
                .HasOne(r => r.Feedback)
                .WithMany(f => f.Responses)
                .HasForeignKey(r => r.FeedbackId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
