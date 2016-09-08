using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorldBlog.Migrations
{
    public partial class MakeTableNamesPlural : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(name: "FK_Experience_Location_LocationId", table: "Experience");
            migrationBuilder.RenameTable(
                name: "Experience",
                newName: "Experiences");
            migrationBuilder.RenameTable(
                name: "Location",
                newName: "Locations");
            migrationBuilder.AddForeignKey(
                name: "FK_Experience_Loaction_LocationId",
                table: "Experiences",
                column: "LocationId",
                principalTable: "Locations",
                principalColumn: "LocationId",
                onDelete: ReferentialAction.Cascade);
            migrationBuilder.DropForeignKey(name: "FK_Person_Experience_ExperienceId", table: "Person");
            migrationBuilder.RenameTable(
                name: "Person",
                newName: "Persons");
            migrationBuilder.RenameTable(
                name: "Experience",
                newName: "Experiences");
            migrationBuilder.AddForeignKey(
                name: "FK_Person_Experience_ExperienceId",
                table: "Persons",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
