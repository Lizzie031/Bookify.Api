using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankApp.Api.Migrations
{
    public partial class Added_amount_Currency_Qty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "Books",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Books",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Books");
        }
    }
}
