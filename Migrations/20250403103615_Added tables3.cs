using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_Main.Migrations
{
    /// <inheritdoc />
    public partial class Addedtables3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emp_Deartment_DepartmentId",
                table: "Emp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deartment",
                table: "Deartment");

            migrationBuilder.RenameTable(
                name: "Deartment",
                newName: "Department");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emp_Department_DepartmentId",
                table: "Emp",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "departmentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emp_Department_DepartmentId",
                table: "Emp");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Deartment");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deartment",
                table: "Deartment",
                column: "departmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emp_Deartment_DepartmentId",
                table: "Emp",
                column: "DepartmentId",
                principalTable: "Deartment",
                principalColumn: "departmentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
