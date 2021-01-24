using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class son : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                "Ipler",
                table => new
                {
                    Id = table.Column<int>("INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IpName = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Ipler", x => x.Id); });

            migrationBuilder.CreateTable(
                "Tesisler",
                table => new
                {
                    Id = table.Column<int>("INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>("TEXT", nullable: true),
                    Adres = table.Column<string>("TEXT", nullable: true)
                },
                constraints: table => { table.PrimaryKey("PK_Tesisler", x => x.Id); });

            migrationBuilder.CreateTable(
                "Kameralar",
                table => new
                {
                    Id = table.Column<int>("INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Marka = table.Column<string>("TEXT", nullable: true),
                    Model = table.Column<string>("TEXT", nullable: true),
                    SeriNo = table.Column<string>("TEXT", nullable: true),
                    IpId = table.Column<int>("INTEGER", nullable: true),
                    TesisId = table.Column<int>("INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kameralar", x => x.Id);
                    table.ForeignKey(
                        "FK_Kameralar_Ipler_IpId",
                        x => x.IpId,
                        "Ipler",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        "FK_Kameralar_Tesisler_TesisId",
                        x => x.TesisId,
                        "Tesisler",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                "KayitProgramlari",
                table => new
                {
                    Id = table.Column<int>("INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ad = table.Column<string>("TEXT", nullable: true),
                    Kanal = table.Column<string>("TEXT", nullable: true),
                    TesisId = table.Column<int>("INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KayitProgramlari", x => x.Id);
                    table.ForeignKey(
                        "FK_KayitProgramlari_Tesisler_TesisId",
                        x => x.TesisId,
                        "Tesisler",
                        "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                "IX_Kameralar_IpId",
                "Kameralar",
                "IpId",
                unique: true);

            migrationBuilder.CreateIndex(
                "IX_Kameralar_TesisId",
                "Kameralar",
                "TesisId");

            migrationBuilder.CreateIndex(
                "IX_KayitProgramlari_TesisId",
                "KayitProgramlari",
                "TesisId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                "Kameralar");

            migrationBuilder.DropTable(
                "KayitProgramlari");

            migrationBuilder.DropTable(
                "Ipler");

            migrationBuilder.DropTable(
                "Tesisler");
        }
    }
}