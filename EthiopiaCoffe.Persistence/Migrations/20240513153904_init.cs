using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EthiopiaCoffe.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Description", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { new Guid("0e37f945-1e8b-4bdd-a47d-ebe651fc788a"), new DateTime(2024, 5, 13, 18, 39, 4, 323, DateTimeKind.Local).AddTicks(6583), "Kekler, kurabiyeler, muffinler, sandviçler ve daha fazlası", false, "Tatlılar ve Atıştırmalıklar" },
                    { new Guid("2c728509-57b5-4c66-ae3f-7f088d902e14"), new DateTime(2024, 5, 13, 18, 39, 4, 323, DateTimeKind.Local).AddTicks(6551), "Serinletici içeceklerle yazın sıcağında keyifli anlar yaşayın!", false, "Soğuk İçecekler" },
                    { new Guid("9db55c49-7b5a-436d-b99b-50b986e5af4a"), new DateTime(2024, 5, 13, 18, 39, 4, 323, DateTimeKind.Local).AddTicks(6659), "Mevsimlik özel içecekler, meyve suları, smoothie'ler, spesiyal tarifler", false, "Özel İçecekler" },
                    { new Guid("d76f24b0-f0e2-4a56-8386-0b7f8939e5f9"), new DateTime(2024, 5, 13, 18, 39, 4, 323, DateTimeKind.Local).AddTicks(6584), "Çeşitli kahve çekirdekleri özel karışımlar", false, "Kahve Çekirdekleri ve Çeşniler" },
                    { new Guid("dd316510-d189-4463-ae25-a73256d3da49"), new DateTime(2024, 5, 13, 18, 39, 4, 323, DateTimeKind.Local).AddTicks(6568), "Kahve tutkunları için enfes sıcak içecekler! ", false, "Sıcak İçecekler" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Offers_CategoryId",
                table: "Offers",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
