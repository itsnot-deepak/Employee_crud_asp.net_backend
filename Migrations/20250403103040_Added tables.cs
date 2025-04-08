using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee_Main.Migrations
{
    /// <inheritdoc />
    public partial class Addedtables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Client",
                columns: table => new
                {
                    clientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    contactPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    companyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    address = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pincode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    state = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    employeeStrength = table.Column<int>(type: "int", nullable: false),
                    gstNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contactNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    regNo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Client", x => x.clientId);
                });

            migrationBuilder.CreateTable(
                name: "Designments",
                columns: table => new
                {
                    departmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designments", x => x.departmentId);
                });

            migrationBuilder.CreateTable(
                name: "Emp",
                columns: table => new
                {
                    empId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    empName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    empCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    empEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emp", x => x.empId);
                    table.ForeignKey(
                        name: "FK_Emp_Designments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Designments",
                        principalColumn: "departmentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Emp_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    clientId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    empId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.ProjectId);
                    table.ForeignKey(
                        name: "FK_Project_Client_clientId",
                        column: x => x.clientId,
                        principalTable: "Client",
                        principalColumn: "clientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Project_Emp_empId",
                        column: x => x.empId,
                        principalTable: "Emp",
                        principalColumn: "empId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Emp_DepartmentId",
                table: "Emp",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Emp_RoleId",
                table: "Emp",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_clientId",
                table: "Project",
                column: "clientId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_empId",
                table: "Project",
                column: "empId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "Client");

            migrationBuilder.DropTable(
                name: "Emp");

            migrationBuilder.DropTable(
                name: "Designments");
        }
    }
}
