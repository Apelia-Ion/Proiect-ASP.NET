using Microsoft.EntityFrameworkCore.Migrations;

namespace RecipesApp.Migrations
{
    public partial class AddedAdressToChef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Chef_ChefId",
                table: "Recipes");

            migrationBuilder.DropForeignKey(
                name: "FK_Recipes_Review_ReviewId",
                table: "Recipes");

            migrationBuilder.DropTable(
                name: "Adresses");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_ChefId",
                table: "Recipes");

            migrationBuilder.DropIndex(
                name: "IX_Recipes_ReviewId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ChefId",
                table: "Recipes");

            migrationBuilder.DropColumn(
                name: "ReviewId",
                table: "Recipes");

            migrationBuilder.AddColumn<int>(
                name: "RecipeId1",
                table: "Review",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChefId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Chef_ChefId",
                        column: x => x.ChefId,
                        principalTable: "Chef",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ChefRecipe",
                columns: table => new
                {
                    ChefsId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RecipesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChefRecipe", x => new { x.ChefsId, x.RecipesId });
                    table.ForeignKey(
                        name: "FK_ChefRecipe_Chef_ChefsId",
                        column: x => x.ChefsId,
                        principalTable: "Chef",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChefRecipe_Recipes_RecipesId",
                        column: x => x.RecipesId,
                        principalTable: "Recipes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_RecipeId1",
                table: "Review",
                column: "RecipeId1");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ChefId",
                table: "Addresses",
                column: "ChefId",
                unique: true,
                filter: "[ChefId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_ChefRecipe_RecipesId",
                table: "ChefRecipe",
                column: "RecipesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Recipes_RecipeId1",
                table: "Review",
                column: "RecipeId1",
                principalTable: "Recipes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Recipes_RecipeId1",
                table: "Review");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "ChefRecipe");

            migrationBuilder.DropIndex(
                name: "IX_Review_RecipeId1",
                table: "Review");

            migrationBuilder.DropColumn(
                name: "RecipeId1",
                table: "Review");

            migrationBuilder.AddColumn<string>(
                name: "ChefId",
                table: "Recipes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ReviewId",
                table: "Recipes",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adresses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChefId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Adresses_Chef_ChefId",
                        column: x => x.ChefId,
                        principalTable: "Chef",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ChefId",
                table: "Recipes",
                column: "ChefId");

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_ReviewId",
                table: "Recipes",
                column: "ReviewId",
                unique: true,
                filter: "[ReviewId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Adresses_ChefId",
                table: "Adresses",
                column: "ChefId",
                unique: true,
                filter: "[ChefId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Chef_ChefId",
                table: "Recipes",
                column: "ChefId",
                principalTable: "Chef",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Recipes_Review_ReviewId",
                table: "Recipes",
                column: "ReviewId",
                principalTable: "Review",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
