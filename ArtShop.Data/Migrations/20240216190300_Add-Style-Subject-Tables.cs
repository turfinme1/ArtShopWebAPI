using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArtShop.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddStyleSubjectTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "OverallRatingScore",
                table: "Artworks",
                newName: "Width");

            migrationBuilder.AddColumn<double>(
                name: "Depth",
                table: "Artworks",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Height",
                table: "Artworks",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<bool>(
                name: "IsFramed",
                table: "Artworks",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StyleId",
                table: "Artworks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SubjectId",
                table: "Artworks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "YearMade",
                table: "Artworks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Styles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Styles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_StyleId",
                table: "Artworks",
                column: "StyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Artworks_SubjectId",
                table: "Artworks",
                column: "SubjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Artworks_Styles_StyleId",
                table: "Artworks",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Artworks_Subjects_SubjectId",
                table: "Artworks",
                column: "SubjectId",
                principalTable: "Subjects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Artworks_Styles_StyleId",
                table: "Artworks");

            migrationBuilder.DropForeignKey(
                name: "FK_Artworks_Subjects_SubjectId",
                table: "Artworks");

            migrationBuilder.DropTable(
                name: "Styles");

            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.DropIndex(
                name: "IX_Artworks_StyleId",
                table: "Artworks");

            migrationBuilder.DropIndex(
                name: "IX_Artworks_SubjectId",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "Depth",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "Height",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "IsFramed",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "StyleId",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "SubjectId",
                table: "Artworks");

            migrationBuilder.DropColumn(
                name: "YearMade",
                table: "Artworks");

            migrationBuilder.RenameColumn(
                name: "Width",
                table: "Artworks",
                newName: "OverallRatingScore");
        }
    }
}
