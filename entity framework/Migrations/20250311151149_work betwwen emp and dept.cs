using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entity_framework.Migrations
{
    /// <inheritdoc />
    public partial class workbetwwenempanddept : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "dep_id",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "empaddress_City",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "empaddress_country",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "empaddress_id",
                table: "Employee",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "empaddress_street",
                table: "Employee",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "manger_id",
                table: "department",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Employee_dep_id",
                table: "Employee",
                column: "dep_id");

            migrationBuilder.CreateIndex(
                name: "IX_department_manger_id",
                table: "department",
                column: "manger_id",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_department_Employee_manger_id",
                table: "department",
                column: "manger_id",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_department_dep_id",
                table: "Employee",
                column: "dep_id",
                principalTable: "department",
                principalColumn: "depId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_Employee_manger_id",
                table: "department");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_department_dep_id",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_dep_id",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_department_manger_id",
                table: "department");

            migrationBuilder.DropColumn(
                name: "dep_id",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "empaddress_City",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "empaddress_country",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "empaddress_id",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "empaddress_street",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "manger_id",
                table: "department");
        }
    }
}
