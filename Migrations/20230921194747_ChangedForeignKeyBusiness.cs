using Microsoft.EntityFrameworkCore.Migrations;

namespace pet_hotel.Migrations
{
    public partial class ChangedForeignKeyBusiness : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwners_petOwnerid",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "petOwnerid",
                table: "Pets",
                newName: "petOwnedByid");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_petOwnerid",
                table: "Pets",
                newName: "IX_Pets_petOwnedByid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwners_petOwnedByid",
                table: "Pets",
                column: "petOwnedByid",
                principalTable: "PetOwners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_PetOwners_petOwnedByid",
                table: "Pets");

            migrationBuilder.RenameColumn(
                name: "petOwnedByid",
                table: "Pets",
                newName: "petOwnerid");

            migrationBuilder.RenameIndex(
                name: "IX_Pets_petOwnedByid",
                table: "Pets",
                newName: "IX_Pets_petOwnerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_PetOwners_petOwnerid",
                table: "Pets",
                column: "petOwnerid",
                principalTable: "PetOwners",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
