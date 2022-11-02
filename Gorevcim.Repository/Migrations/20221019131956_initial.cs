using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gorevcim.Repository.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ExpirationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsMixture = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LogoBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LogoFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    TechnicalWebUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ExplanationWebUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "ProductFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductFeatures_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BrandsWebUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    LogoBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    LogoFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductBrands", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductBrands_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductColors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ColorBase64Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorFileName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ColorFilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductColors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductColors_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductCurrencyUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCurrencyUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductCurrencyUnits_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductMeasurementUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductMeasurementUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductMeasurementUnits_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductProjects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProjects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductProjects_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductVatUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsExemption = table.Column<int>(type: "int", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductVatUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductVatUnits_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductWeightUnits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ShortCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ProductFeaturesId = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateUserId = table.Column<int>(type: "int", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<int>(type: "int", nullable: false),
                    IsActiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUserId = table.Column<int>(type: "int", nullable: false),
                    ActiveDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActiveDateUpdateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDelete = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUserId = table.Column<int>(type: "int", nullable: false),
                    IsDeleteDateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleteDateUpdateUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductWeightUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductWeightUnits_ProductFeatures_ProductFeaturesId",
                        column: x => x.ProductFeaturesId,
                        principalTable: "ProductFeatures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "ActiveDateUpdate", "CreateDate", "CreateUserId", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "Name", "UpdateDate", "UpdateUserId" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Ofis Ürünleri", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Polen Haşere", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "İzolasyon", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Polen Delici", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Montaj Asma", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Tadilat", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Tamir", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Maskeleme ", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Kaydırmaz", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "İç Cephe Boyalar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Dış Cephe Boyalar", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, "Tinerler", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "ActiveDateUpdate", "Barcode", "CategoryId", "Code", "CreateDate", "CreateUserId", "ExpirationDate", "Explanation", "ExplanationWebUrl", "IsActive", "IsActiveDate", "IsActiveDateUpdateUserId", "IsActiveDateUserId", "IsDelete", "IsDeleteDate", "IsDeleteDateUpdate", "IsDeleteDateUpdateUserId", "IsDeleteDateUserId", "IsMixture", "LogoBase64Content", "LogoFileName", "LogoFilePath", "Name", "PurchasePrice", "SalePrice", "Stock", "TechnicalWebUrl", "UpdateDate", "UpdateUserId" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AS123", 1, "123AS", new DateTime(2022, 10, 19, 16, 19, 56, 156, DateTimeKind.Local).AddTicks(3359), 0, new DateTime(2022, 10, 19, 16, 19, 56, 156, DateTimeKind.Local).AddTicks(3344), "hghghgh", "dlld", 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, 1, "ad", "sdf", "sdsdf", "Test Ürün1", 10m, 15m, 1, "dfsd", new DateTime(2022, 10, 19, 16, 19, 56, 156, DateTimeKind.Local).AddTicks(3360), 0 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductBrands_ProductFeaturesId",
                table: "ProductBrands",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductColors_ProductFeaturesId",
                table: "ProductColors",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductCurrencyUnits_ProductFeaturesId",
                table: "ProductCurrencyUnits",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductFeatures_ProductId",
                table: "ProductFeatures",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductMeasurementUnits_ProductFeaturesId",
                table: "ProductMeasurementUnits",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductProjects_ProductFeaturesId",
                table: "ProductProjects",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVatUnits_ProductFeaturesId",
                table: "ProductVatUnits",
                column: "ProductFeaturesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductWeightUnits_ProductFeaturesId",
                table: "ProductWeightUnits",
                column: "ProductFeaturesId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductBrands");

            migrationBuilder.DropTable(
                name: "ProductColors");

            migrationBuilder.DropTable(
                name: "ProductCurrencyUnits");

            migrationBuilder.DropTable(
                name: "ProductMeasurementUnits");

            migrationBuilder.DropTable(
                name: "ProductProjects");

            migrationBuilder.DropTable(
                name: "ProductVatUnits");

            migrationBuilder.DropTable(
                name: "ProductWeightUnits");

            migrationBuilder.DropTable(
                name: "ProductFeatures");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
