using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using WorldBlog.Models;

namespace WorldBlog.Migrations
{
    [DbContext(typeof(WorldBlogContext))]
    [Migration("20160908174438_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rc2-20901")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WorldBlog.Models.Experience", b =>
                {
                    b.Property<int>("ExperienceId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("LocationId");

                    b.Property<string>("Name");

                    b.HasKey("ExperienceId");

                    b.HasIndex("LocationId");

                    b.ToTable("Experiences");
                });

            modelBuilder.Entity("WorldBlog.Models.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("LocationId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("WorldBlog.Models.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ExperienceId");

                    b.Property<string>("Name");

                    b.HasKey("PersonId");

                    b.HasIndex("ExperienceId");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("WorldBlog.Models.Experience", b =>
                {
                    b.HasOne("WorldBlog.Models.Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("WorldBlog.Models.Person", b =>
                {
                    b.HasOne("WorldBlog.Models.Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
