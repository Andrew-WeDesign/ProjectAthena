﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjectAthena.Models;

namespace ProjectAthena.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IHttpContextAccessor httpContextAccessor) : base(options)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<CampaignUser> CampaignUsers { get; set; }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>().ToTable("ApplicationUser");
            modelBuilder.Entity<Campaign>().ToTable("Campaign");
            modelBuilder.Entity<CampaignUser>().ToTable("CampaignUser");
            modelBuilder.Entity<Report>().ToTable("Report");
            base.OnModelCreating(modelBuilder);
        }

    }
}
