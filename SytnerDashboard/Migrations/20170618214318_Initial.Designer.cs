using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SytnerDashboard.Models;

namespace SytnerDashboard.Migrations
{
    [DbContext(typeof(SytnerDashboardContext))]
    [Migration("20170618214318_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SytnerDashboard.Models.StaffReview", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Attendance");

                    b.Property<int>("CommunicationSkills");

                    b.Property<int>("Creativity");

                    b.Property<DateTime>("DateOfReview");

                    b.Property<string>("Forename");

                    b.Property<int>("Productivity");

                    b.Property<string>("Surenamename");

                    b.Property<int>("TechnicalSkills");

                    b.Property<int>("WorkQuality");

                    b.HasKey("ID");

                    b.ToTable("StaffReview");
                });
        }
    }
}
