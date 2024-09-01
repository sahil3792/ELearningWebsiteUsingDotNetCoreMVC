using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELearningWebAppUsingMVCArchitecture.Migrations
{
    /// <inheritdoc />
    public partial class Addcolumninordertable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PaymentOrderId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentOrderId",
                table: "Orders");
        }
    }
}
