using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsExamTest2.Migrations
{
    /// <inheritdoc />
    public partial class TestMigr : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Офисы",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Название = table.Column<string>(type: "TEXT", nullable: false),
                    Город = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Офисы", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Товары",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Название = table.Column<string>(type: "TEXT", nullable: false),
                    Кодификатор = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Товары", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Клиенты",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Имя = table.Column<string>(type: "TEXT", nullable: false),
                    Фамилия = table.Column<string>(type: "TEXT", nullable: false),
                    Возраст = table.Column<int>(type: "INTEGER", nullable: false),
                    ОфисId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Клиенты", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Клиенты_Офисы_ОфисId",
                        column: x => x.ОфисId,
                        principalTable: "Офисы",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ОфисТовар",
                columns: table => new
                {
                    ОфисыId = table.Column<int>(type: "INTEGER", nullable: false),
                    ТоварыId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ОфисТовар", x => new { x.ОфисыId, x.ТоварыId });
                    table.ForeignKey(
                        name: "FK_ОфисТовар_Офисы_ОфисыId",
                        column: x => x.ОфисыId,
                        principalTable: "Офисы",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ОфисТовар_Товары_ТоварыId",
                        column: x => x.ТоварыId,
                        principalTable: "Товары",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Клиенты_ОфисId",
                table: "Клиенты",
                column: "ОфисId");

            migrationBuilder.CreateIndex(
                name: "IX_ОфисТовар_ТоварыId",
                table: "ОфисТовар",
                column: "ТоварыId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Клиенты");

            migrationBuilder.DropTable(
                name: "ОфисТовар");

            migrationBuilder.DropTable(
                name: "Офисы");

            migrationBuilder.DropTable(
                name: "Товары");
        }
    }
}
