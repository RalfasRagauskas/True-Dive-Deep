using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace True_Dive_Deep.Migrations
{
    /// <inheritdoc />
    public partial class DiveDeepProductsInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PricePerDay = table.Column<int>(type: "int", nullable: false),
                    ImageFileName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "BCD",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sizes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BCD", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_BCD_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DivingSuit",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sizes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thickness = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DivingSuit", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_DivingSuit_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fin",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sizes = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fin", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Fin_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Mask_Snorkel",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mask_Snorkel", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Mask_Snorkel_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegulatorSet",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StepOne = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StepTwo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Octopus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegulatorSet", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_RegulatorSet_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tank",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Volume = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tank", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Tank_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Brand", "ImageFileName", "PricePerDay" },
                values: new object[,]
                {
                    { -33, "Scubapro", "", 180 },
                    { -32, "Scubapro", "", 170 },
                    { -31, "Scubapro", "", 160 },
                    { -30, "Scubapro", "", 150 },
                    { -29, "Scubapro", "Regulator-Set.png", 150 },
                    { -28, "Scubapro", "Regulator-Set.png", 100 },
                    { -27, "Scubapro", "Regulator-Set.png", 125 },
                    { -26, "Tusa", "Maske&Snorkel.png", 75 },
                    { -25, "Fourth Element", "Maske&Snorkel.png", 75 },
                    { -24, "Fourth Element", "Maske&Snorkel.png", 75 },
                    { -23, "Scubapro", "Maske&Snorkel.png", 75 },
                    { -22, "Scubapro", "Maske&Snorkel.png", 50 },
                    { -21, "Scubapro", "Maske&Snorkel.png", 60 },
                    { -20, "Scubapro", "Maske&Snorkel.png", 50 },
                    { -19, "Fourth Element", "finjetfn.jpg", 80 },
                    { -18, "Fourth Element", "finjetfn.jpg", 75 },
                    { -17, "Seac", "fingofin.jpg", 50 },
                    { -16, "Seac", "fingofin.jpg", 50 },
                    { -15, "Scubapro", "finjetfn.jpg", 60 },
                    { -14, "Scubapro", "fingofin.jpg", 50 },
                    { -13, "Scubapro", "finjetfn.jpg", 50 },
                    { -12, "Santi", "divingsuiteliteplus.jpg", 350 },
                    { -11, "Waterproof", "divingsuitd7evo.jpg", 320 },
                    { -10, "Scubapro", "divingsuitexodry.webp", 300 },
                    { -9, "Fourth Element", "divingsuitproteus.jpg", 120 },
                    { -8, "Waterproof", "divingsuitW5.jpg", 100 },
                    { -7, "Scubapro", "divingsuit7mm.webp", 100 },
                    { -6, "Scubapro", "divingsuit5mm.webp", 100 },
                    { -5, "Scubapro", "Dykkerdragter.webp", 100 },
                    { -4, "Seac", "bcdmodular.jpg", 145 },
                    { -3, "Scubapro", "bcdhydrospro.png", 200 },
                    { -2, "Scubapro", "bcd02.jpg", 140 },
                    { -1, "Scubapro", "navigatorliteblue.jpg", 125 }
                });

            migrationBuilder.InsertData(
                table: "BCD",
                columns: new[] { "ProductId", "Model", "Sizes" },
                values: new object[,]
                {
                    { -4, "BCD Modular", "[0,1,2]" },
                    { -3, "BCD Hydros Pro", "[0,1,2]" },
                    { -2, "BCD Glide", "[0,1,2]" },
                    { -1, "Navigator Lite BCD", "[0,1,2]" }
                });

            migrationBuilder.InsertData(
                table: "DivingSuit",
                columns: new[] { "ProductId", "Gender", "Model", "Sizes", "Thickness", "Type" },
                values: new object[,]
                {
                    { -12, "[0,1]", "E.Lite Plus", "[0,1,2,3,4]", 0.0, "Tørdragt" },
                    { -11, "[0,1]", "D7 Evo", "[0,1,2,3,4]", 0.0, "Tørdragt" },
                    { -10, "[0,1]", "Exodry 4.0", "[0,1,2,3,4]", 0.0, "Tørdragt" },
                    { -9, "[0,1]", "Proteus", "[0,1,2,3,4]", 5.0, "Våddragt" },
                    { -8, "[0,1]", "W5", "[0,1,2,3,4]", 3.5, "Våddragt" },
                    { -7, "[0,1]", "Definition", "[0,1,2,3,4]", 7.0, "Våddragt" },
                    { -6, "[0,1]", "Definition", "[0,1,2,3,4]", 5.0, "Våddragt" },
                    { -5, "[0,1]", "Definition", "[0,1,2,3,4]", 3.0, "Våddragt" }
                });

            migrationBuilder.InsertData(
                table: "Fin",
                columns: new[] { "ProductId", "Model", "Sizes" },
                values: new object[,]
                {
                    { -19, "Rec Fin", "[0,1,2,3,4]" },
                    { -18, "Tech", "[0,1,2,3,4]" },
                    { -17, "ALA", "[0,1,2,3,4]" },
                    { -16, "Propulsion", "[0,1,2,3,4]" },
                    { -15, "Seawing Supernova", "[0,1,2,3,4]" },
                    { -14, "GO Travel", "[0,1,2,3,4]" },
                    { -13, "Jet Fin", "[0,1,2,3,4]" }
                });

            migrationBuilder.InsertData(
                table: "Mask_Snorkel",
                columns: new[] { "ProductId", "Model" },
                values: new object[,]
                {
                    { -26, "Element" },
                    { -25, "Scout Enhance" },
                    { -24, "Scout Kontrast" },
                    { -23, "Crystal VU" },
                    { -22, "Spectra Mini" },
                    { -21, "D-Mask" },
                    { -20, "Ghost" }
                });

            migrationBuilder.InsertData(
                table: "RegulatorSet",
                columns: new[] { "ProductId", "Octopus", "StepOne", "StepTwo" },
                values: new object[,]
                {
                    { -29, "S270", "MK25EVO BT", "A700 Carbon BT" },
                    { -28, "R095", "MK17EVO", "C370" },
                    { -27, "R105", "MK25EVO", "S600" }
                });

            migrationBuilder.InsertData(
                table: "Tank",
                columns: new[] { "ProductId", "Volume" },
                values: new object[,]
                {
                    { -33, 15 },
                    { -32, 12 },
                    { -31, 10 },
                    { -30, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BCD");

            migrationBuilder.DropTable(
                name: "DivingSuit");

            migrationBuilder.DropTable(
                name: "Fin");

            migrationBuilder.DropTable(
                name: "Mask_Snorkel");

            migrationBuilder.DropTable(
                name: "RegulatorSet");

            migrationBuilder.DropTable(
                name: "Tank");

            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
