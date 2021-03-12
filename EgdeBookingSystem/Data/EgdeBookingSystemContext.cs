﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using EgdeBookingSystem.Models;

namespace EgdeBookingSystem.Data
{
    public class EgdeBookingSystemContext : IdentityDbContext
    {
        public EgdeBookingSystemContext(DbContextOptions<EgdeBookingSystemContext> options)
            : base(options)
        {
        }
        public DbSet<EgdeBookingSystem.Models.Equipment> Equipment { get; set; }
        public DbSet<EgdeBookingSystem.Models.Category> Category { get; set; }
        public DbSet<EgdeBookingSystem.Models.Location> Location { get; set; }
        public DbSet<EgdeBookingSystem.Models.Booking> Booking { get; set; }
    }
}
