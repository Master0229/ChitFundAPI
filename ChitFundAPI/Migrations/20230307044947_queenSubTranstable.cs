using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ChitFundAPI.Migrations
{
    public partial class queenSubTranstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubTrans",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<float>(type: "real", nullable: false),
                    TransDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false),
                    ContactId = table.Column<int>(type: "int", nullable: false),
                    ReferedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubTrans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubTrans_Contacts_ContactId",
                        column: x => x.ContactId,
                        principalTable: "Contacts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubTrans_PaymentTypes_PaymentTypeId",
                        column: x => x.PaymentTypeId,
                        principalTable: "PaymentTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubTrans_Transactions_TransactionId",
                        column: x => x.TransactionId,
                        principalTable: "Transactions",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SubTrans_Users_ReferedBy",
                        column: x => x.ReferedBy,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubTrans_ContactId",
                table: "SubTrans",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTrans_PaymentTypeId",
                table: "SubTrans",
                column: "PaymentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SubTrans_ReferedBy",
                table: "SubTrans",
                column: "ReferedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SubTrans_TransactionId",
                table: "SubTrans",
                column: "TransactionId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubTrans");
        }
    }
}
