using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Week6.Migrations
{
    /// <inheritdoc />
    public partial class mig_2_modifiedOn_added : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedOn",
                table: "JobPosts",
                type: "timestamp with time zone",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedOn",
                table: "JobPosts");
        }
    }
}
