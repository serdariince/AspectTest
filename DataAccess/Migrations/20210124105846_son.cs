using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class son : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ipler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IpName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ipler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tesisler",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Adres = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tesisler", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kameralar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marka = table.Column<string>(type: "TEXT", nullable: true),
                    Model = table.Column<string>(type: "TEXT", nullable: true),
                    SeriNo = table.Column<string>(type: "TEXT", nullable: true),
                    IpId = table.Column<int>(type: "INTEGER", nullable: true),
                    TesisId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kameralar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Kameralar_Ipler_IpId",
                        column: x => x.IpId,
                        principalTable: "Ipler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Kameralar_Tesisler_TesisId",
                        column: x => x.TesisId,
                        principalTable: "Tesisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KayitProgramlari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>(type: "TEXT", nullable: true),
                    Kanal = table.Column<string>(type: "TEXT", nullable: true),
                    TesisId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KayitProgramlari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KayitProgramlari_Tesisler_TesisId",
                        column: x => x.TesisId,
                        principalTable: "Tesisler",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kameralar_IpId",
                table: "Kameralar",
                column: "IpId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Kameralar_TesisId",
                table: "Kameralar",
                column: "TesisId");

            migrationBuilder.CreateIndex(
                name: "IX_KayitProgramlari_TesisId",
                table: "KayitProgramlari",
                column: "TesisId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kameralar");

            migrationBuilder.DropTable(
                name: "KayitProgramlari");

            migrationBuilder.DropTable(
                name: "Ipler");

            migrationBuilder.DropTable(
                name: "Tesisler");
        }
    }
}
