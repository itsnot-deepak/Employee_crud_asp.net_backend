using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_Main.Migrations
{
    /// <inheritdoc />
    public partial class Addedtables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emp_Designments_DepartmentId",
                table: "Emp");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Client_clientId",
                table: "Project");

            migrationBuilder.DropForeignKey(
                name: "FK_Project_Emp_empId",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Project",
                table: "Project");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Designments",
                table: "Designments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Client",
                table: "Client");

            migrationBuilder.RenameTable(
                name: "Project",
                newName: "Projects");

            migrationBuilder.RenameTable(
                name: "Designments",
                newName: "Deartment");

            migrationBuilder.RenameTable(
                name: "Client",
                newName: "Clients");

            migrationBuilder.RenameIndex(
                name: "IX_Project_empId",
                table: "Projects",
                newName: "IX_Projects_empId");

            migrationBuilder.RenameIndex(
                name: "IX_Project_clientId",
                table: "Projects",
                newName: "IX_Projects_clientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Projects",
                table: "Projects",
                column: "ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Deartment",
                table: "Deartment",
                column: "departmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clients",
                table: "Clients",
                column: "clientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emp_Deartment_DepartmentId",
                table: "Emp",
                column: "DepartmentId",
                principalTable: "Deartment",
                principalColumn: "departmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Clients_clientId",
                table: "Projects",
                column: "clientId",
                principalTable: "Clients",
                principalColumn: "clientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Emp_empId",
                table: "Projects",
                column: "empId",
                principalTable: "Emp",
                principalColumn: "empId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Emp_Deartment_DepartmentId",
                table: "Emp");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Clients_clientId",
                table: "Projects");

            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Emp_empId",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Projects",
                table: "Projects");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Deartment",
                table: "Deartment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clients",
                table: "Clients");

            migrationBuilder.RenameTable(
                name: "Projects",
                newName: "Project");

            migrationBuilder.RenameTable(
                name: "Deartment",
                newName: "Designments");

            migrationBuilder.RenameTable(
                name: "Clients",
                newName: "Client");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_empId",
                table: "Project",
                newName: "IX_Project_empId");

            migrationBuilder.RenameIndex(
                name: "IX_Projects_clientId",
                table: "Project",
                newName: "IX_Project_clientId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Project",
                table: "Project",
                column: "ProjectId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Designments",
                table: "Designments",
                column: "departmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Client",
                table: "Client",
                column: "clientId");

            migrationBuilder.AddForeignKey(
                name: "FK_Emp_Designments_DepartmentId",
                table: "Emp",
                column: "DepartmentId",
                principalTable: "Designments",
                principalColumn: "departmentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Client_clientId",
                table: "Project",
                column: "clientId",
                principalTable: "Client",
                principalColumn: "clientId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Project_Emp_empId",
                table: "Project",
                column: "empId",
                principalTable: "Emp",
                principalColumn: "empId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
