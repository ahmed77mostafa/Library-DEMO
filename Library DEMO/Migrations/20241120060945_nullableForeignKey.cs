using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library_DEMO.Migrations
{
    /// <inheritdoc />
    public partial class nullableForeignKey : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_IdentityCards_IdentityCardId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_IdentityCardId",
                table: "Authors");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityCardId",
                table: "Authors",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_IdentityCardId",
                table: "Authors",
                column: "IdentityCardId",
                unique: true,
                filter: "[IdentityCardId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_IdentityCards_IdentityCardId",
                table: "Authors",
                column: "IdentityCardId",
                principalTable: "IdentityCards",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Authors_IdentityCards_IdentityCardId",
                table: "Authors");

            migrationBuilder.DropIndex(
                name: "IX_Authors_IdentityCardId",
                table: "Authors");

            migrationBuilder.AlterColumn<int>(
                name: "IdentityCardId",
                table: "Authors",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Authors_IdentityCardId",
                table: "Authors",
                column: "IdentityCardId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Authors_IdentityCards_IdentityCardId",
                table: "Authors",
                column: "IdentityCardId",
                principalTable: "IdentityCards",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
