using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SytnerDashboard.Models
{
    public class SytnerDashboardContext : DbContext
    {
        public SytnerDashboardContext (DbContextOptions<SytnerDashboardContext> options)
            : base(options)
        {
        }

        public DbSet<SytnerDashboard.Models.StaffReview> StaffReview { get; set; }
    }
}
