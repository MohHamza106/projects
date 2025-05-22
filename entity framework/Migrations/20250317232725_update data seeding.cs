using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace entity_framework.Migrations
{
    /// <inheritdoc />
    public partial class updatedataseeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_Employee_manger_id",
                table: "department");

            migrationBuilder.DropIndex(
                name: "IX_department_manger_id",
                table: "department");

            migrationBuilder.AlterColumn<int>(
                name: "manger_id",
                table: "department",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_department_manger_id",
                table: "department",
                column: "manger_id",
                unique: true,
                filter: "[manger_id] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_department_Employee_manger_id",
                table: "department",
                column: "manger_id",
                principalTable: "Employee",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_department_Employee_manger_id",
                table: "department");

            migrationBuilder.DropIndex(
                name: "IX_department_manger_id",
                table: "department");

            migrationBuilder.AlterColumn<int>(
                name: "manger_id",
                table: "department",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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
        }
    }
}
