using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChitFundAPI.Migrations
{
    public partial class queenplandetailtableadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlanAssigns",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlanAssigns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlanAssigns_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlanAssigns_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PlanAssigns_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Plandetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlanId = table.Column<int>(type: "int", nullable: false),
                    Due = table.Column<int>(type: "int", nullable: false),
                    SettleAmount = table.Column<float>(type: "real", nullable: false),
                    ActualAmount = table.Column<float>(type: "real", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plandetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plandetails_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Plandetails_Plans_PlanId",
                        column: x => x.PlanId,
                        principalTable: "Plans",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlanAssigns_CompanyId",
                table: "PlanAssigns",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanAssigns_ContactId",
                table: "PlanAssigns",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_PlanAssigns_PlanId",
                table: "PlanAssigns",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_Plandetails_CompanyId",
                table: "Plandetails",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Plandetails_PlanId",
                table: "Plandetails",
                column: "PlanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlanAssigns");

            migrationBuilder.DropTable(
                name: "Plandetails");
        }
    }
}
