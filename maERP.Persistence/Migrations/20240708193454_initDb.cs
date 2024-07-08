﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace maERP.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AiModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AiModelType = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApiUsername = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApiPassword = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ApiKey = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AiModel", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AiPrompt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    AiModelType = table.Column<int>(type: "int", nullable: false),
                    Identifier = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PromptText = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AiPrompt", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Firstname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lastname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    PasswordHash = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    SecurityStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ConcurrencyStamp = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumber = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CountryCode = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lastname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompanyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Email = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Phone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Website = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    VatNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Note = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerStatus = table.Column<int>(type: "int", nullable: false),
                    DateEnrollment = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Key = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Shipping",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ShippingProviderId = table.Column<int>(type: "int", nullable: false),
                    TrackingNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingCost = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingTaxRate = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingProviderName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShippingProvider",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingProvider", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "TaxClass",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    TaxRate = table.Column<double>(type: "double", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxClass", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Warehouse",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimType = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ClaimValue = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderKey = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ProviderDisplayName = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    RoleId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    LoginProvider = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Lastname = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CompanyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Street = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    HouseNr = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Zip = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    City = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DefaultDeliveryAddress = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    DefaultInvoiceAddress = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CustomerAddress_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "CustomerSalesChannel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SalesChannelId = table.Column<int>(type: "int", nullable: false),
                    RemoteCustomerId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSalesChannel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CustomerSalesChannel_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SalesChannelId = table.Column<int>(type: "int", nullable: false),
                    RemoteOrderId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ShippingCost = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TotalTax = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    PaymentMethod = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaymentProvider = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    PaymentTransactionId = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    CustomerNote = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InternalNote = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeliveryAddressFirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeliveryAddressLastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeliveryAddressCompanyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeliveryAddressPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeliveryAddressStreet = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeliveryAddressCity = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeliverAddressZip = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DeliveryAddressCountry = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceAddressFirstName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceAddressLastName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceAddressCompanyName = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceAddressPhone = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceAddressStreet = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceAddressCity = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceAddressZip = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    InvoiceAddressCountry = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateOrdered = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ShippingProviderRate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MaxLength = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MaxWidth = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MaxHeight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    MaxWeight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    ShippingProviderId = table.Column<int>(type: "int", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShippingProviderRate", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ShippingProviderRate_ShippingProvider_ShippingProviderId",
                        column: x => x.ShippingProviderId,
                        principalTable: "ShippingProvider",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Sku = table.Column<string>(type: "varchar(255)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    NameOptimized = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Ean = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Asin = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DescriptionOptimized = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    UseOptimized = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Msrp = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    Depth = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TaxClassId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_TaxClass_TaxClassId",
                        column: x => x.TaxClassId,
                        principalTable: "TaxClass",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "SalesChannel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    URL = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Username = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Password = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImportProducts = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ImportCustomers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ImportOrders = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ExportProducts = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ExportCustomers = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ExportOrders = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InitialProductImportCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    InitialProductExportCompleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesChannel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SalesChannel_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<double>(type: "double", nullable: false),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    TaxRate = table.Column<double>(type: "double", nullable: false),
                    MissingProductSku = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    MissingProductEan = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ShippingId = table.Column<int>(type: "int", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItem_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductStock",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    WarehouseId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<double>(type: "double", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductStock", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductStock_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductStock_Warehouse_WarehouseId",
                        column: x => x.WarehouseId,
                        principalTable: "Warehouse",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductSalesChannel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    SalesChannelId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    RemoteProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(65,30)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSalesChannel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSalesChannel_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSalesChannel_SalesChannel_SalesChannelId",
                        column: x => x.SalesChannelId,
                        principalTable: "SalesChannel",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "OrderItemSerialNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    OrderItemId = table.Column<int>(type: "int", nullable: false),
                    SerialNumber = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    DateCreated = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    DateModified = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemSerialNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItemSerialNumber_OrderItem_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", null, "Employee", "EMPLOYEE" },
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "8e445865-a24d-4543-a6c6-9443d048cdb9", 0, "9b4687af-200e-4098-b579-9dc2e4389676", "admin@localhost.com", true, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEKQWdCJwWm46N0lwAjYfPchGpsxQHMmD66ZidCJ/n+cJEvZIIndllPChhwLRfd/7+g==", null, false, "7948f1b9-d031-4312-8381-2c90a11b94bc", false, "admin@localhost.com" },
                    { "9e224968-33e4-4652-b7b7-8574d048cdb9", 0, "1c31e445-9cb5-48b4-bc53-3d5472259230", "user@localhost.com", true, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEAmz/+yatdm1DWgp0ESfk1LTl4T8ju1QTsNGRCwbtkexbvtCw7CGOrcpypLuyFF3+w==", null, false, "d4d5d93c-e663-4582-8057-80fbab58339a", false, "user@localhost.com" }
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CountryCode", "DateCreated", "DateModified", "Name" },
                values: new object[,]
                {
                    { 1, "DE", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3597), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3605), "Germany" },
                    { 2, "AT", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3609), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3610), "Austria" },
                    { 3, "CH", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3610), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3611), "Switzerland" },
                    { 4, "AD", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3611), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3612), "Andorra" },
                    { 5, "AF", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3612), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3613), "Afghanistan" },
                    { 6, "AG", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3613), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3614), "Antigua and Barbuda" },
                    { 7, "AL", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3614), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3615), "Albania" },
                    { 8, "AM", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3615), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3616), "Armenia" },
                    { 9, "AO", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3616), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3617), "Angola" },
                    { 10, "AX", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3617), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3618), "Åland Islands" },
                    { 11, "AR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3618), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3619), "Argentina" },
                    { 12, "AT", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3709), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3710), "Antarctica" },
                    { 13, "AU", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3711), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3711), "Australia" },
                    { 14, "AZ", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3712), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3712), "Azerbaijan" },
                    { 15, "BA", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3713), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3713), "Bosnia and Herzegovina" },
                    { 16, "BB", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3714), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3714), "Barbados" },
                    { 17, "BE", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3715), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3715), "Belgium" },
                    { 18, "BG", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3716), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3716), "Bulgaria" },
                    { 19, "BL", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3717), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3717), "Saint Barthélemy" },
                    { 20, "BO", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3718), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3718), "Bolivia" },
                    { 21, "BR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3719), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3719), "Brazil" },
                    { 22, "BS", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3720), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3720), "Bahamas" },
                    { 23, "BY", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3721), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3722), "Belarus" },
                    { 24, "BZ", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3722), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3723), "Belize" },
                    { 25, "CA", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3723), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3724), "Canada" },
                    { 26, "CH", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3724), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3725), "Cocos (Keeling) Islands" },
                    { 27, "CI", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3725), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3726), "Ivory Coast" },
                    { 28, "CL", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3726), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3727), "Chile" },
                    { 29, "CN", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3727), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3728), "China" },
                    { 30, "CO", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3728), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3729), "Colombia" },
                    { 31, "CR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3729), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3730), "Costa Rica" },
                    { 32, "CU", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3730), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3731), "Cuba" },
                    { 33, "CY", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3731), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3732), "Cyprus" },
                    { 34, "CZ", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3732), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3733), "Czech Republic" },
                    { 35, "DO", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3733), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3734), "Dominican Republic" },
                    { 36, "DK", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3734), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3735), "Denmark" },
                    { 37, "DZ", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3735), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3736), "Algeria" },
                    { 38, "EC", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3736), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3737), "Ecuador" },
                    { 39, "EE", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3737), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3738), "Estonia" },
                    { 40, "EG", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3738), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3739), "Egypt" },
                    { 41, "ER", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3739), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3740), "Eritrea" },
                    { 42, "ES", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3740), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3741), "Spain" },
                    { 43, "ET", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3741), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3742), "Ethiopia" },
                    { 44, "FI", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3742), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3743), "Finland" },
                    { 45, "FR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3743), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3744), "France" },
                    { 46, "GB", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3744), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3745), "United Kingdom" },
                    { 47, "GE", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3746), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3746), "Georgia" },
                    { 48, "GF", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3746), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3747), "French Guiana" },
                    { 49, "GH", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3747), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3748), "Ghana" },
                    { 50, "GL", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3748), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3749), "Greenland" },
                    { 51, "GP", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3750), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3750), "Guadeloupe" },
                    { 52, "GR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3750), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3751), "Greece" },
                    { 53, "GT", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3751), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3752), "Guatemala" },
                    { 54, "GY", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3752), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3753), "Guyana" },
                    { 55, "HN", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3753), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3754), "Honduras" },
                    { 56, "HR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3754), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3755), "Croatia" },
                    { 57, "HT", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3755), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3756), "Haiti" },
                    { 58, "HU", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3757), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3757), "Hungary" },
                    { 59, "ID", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3758), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3758), "Indonesia" },
                    { 60, "IE", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3759), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3759), "Ireland" },
                    { 61, "IN", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3759), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3760), "India" },
                    { 62, "IR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3761), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3761), "Iran" },
                    { 63, "IS", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3762), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3762), "Iceland" },
                    { 64, "IT", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3763), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3763), "Italy" },
                    { 65, "JM", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3764), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3764), "Jamaica" },
                    { 66, "JP", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3765), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3765), "Japan" },
                    { 67, "KE", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3766), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3766), "Kenya" },
                    { 68, "KG", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3767), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3767), "Kyrgyzstan" },
                    { 69, "KR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3768), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3768), "South Korea" },
                    { 70, "KW", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3769), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3769), "Kuwait" },
                    { 71, "KZ", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3770), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3770), "Kazakhstan" },
                    { 72, "LU", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3771), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3771), "Luxembourg" },
                    { 73, "LT", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3772), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3772), "Lithuania" },
                    { 74, "LV", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3773), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3773), "Latvia" },
                    { 75, "MA", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3774), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3774), "Morocco" },
                    { 76, "MC", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3775), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3775), "Monaco" },
                    { 77, "MD", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3776), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3776), "Moldova" },
                    { 78, "MF", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3777), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3777), "Saint Martin" },
                    { 79, "MG", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3778), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3778), "Madagascar" },
                    { 80, "MQ", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3779), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3779), "Martinique" },
                    { 81, "MT", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3780), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3780), "Malta" },
                    { 82, "MX", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3781), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3781), "Mexico" },
                    { 83, "MY", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3782), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3782), "Malaysia" },
                    { 84, "NG", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3783), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3783), "Nigeria" },
                    { 85, "NI", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3784), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3784), "Nicaragua" },
                    { 86, "NL", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3785), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3785), "Netherlands" },
                    { 87, "NO", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3786), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3786), "Norway" },
                    { 88, "NZ", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3787), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3787), "New Zealand" },
                    { 89, "OM", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3788), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3788), "Oman" },
                    { 90, "PA", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3789), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3789), "Panama" },
                    { 91, "PE", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3790), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3790), "Peru" },
                    { 92, "PL", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3791), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3791), "Poland" },
                    { 93, "PM", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3792), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3792), "Saint Pierre and Miquelon" },
                    { 94, "PR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3793), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3793), "Puerto Rico" },
                    { 95, "PT", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3794), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3794), "Portugal" },
                    { 96, "PY", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3795), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3795), "Paraguay" },
                    { 97, "QA", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3796), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3796), "Qatar" },
                    { 98, "RO", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3797), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3797), "Romania" },
                    { 99, "RS", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3798), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3798), "Serbia" },
                    { 100, "RU", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3799), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3799), "Russia" },
                    { 101, "SA", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3800), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3800), "Saudi Arabia" },
                    { 102, "SE", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3801), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3801), "Sweden" },
                    { 103, "SG", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3802), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3802), "Singapore" },
                    { 104, "SI", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3803), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3803), "Slovenia" },
                    { 105, "SK", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3804), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3804), "Slovakia" },
                    { 106, "SN", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3805), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3805), "Senegal" },
                    { 107, "SR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3806), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3806), "Suriname" },
                    { 108, "SV", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3807), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3807), "El Salvador" },
                    { 109, "TR", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3808), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3808), "Turkey" },
                    { 110, "TT", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3809), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3809), "Trinidad and Tobago" },
                    { 111, "UA", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3810), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3810), "Ukraine" },
                    { 112, "US", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3811), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3811), "United States" },
                    { 113, "UY", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3812), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3812), "Uruguay" },
                    { 114, "VE", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3813), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3813), "Venezuela" },
                    { 115, "VI", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3814), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3814), "Virgin Islands" },
                    { 116, "VN", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3815), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3815), "Vietnam" },
                    { 117, "YE", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3816), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3816), "Yemen" },
                    { 118, "ZA", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3817), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3817), "South Africa" },
                    { 119, "ZM", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3818), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3818), "Zambia" },
                    { 120, "ZW", new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3819), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(3819), "Zimbabwe" }
                });

            migrationBuilder.InsertData(
                table: "TaxClass",
                columns: new[] { "Id", "DateCreated", "DateModified", "TaxRate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(5242), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(5243), 19.0 },
                    { 2, new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(5244), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(5244), 7.0 },
                    { 3, new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(5245), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(5245), 0.0 }
                });

            migrationBuilder.InsertData(
                table: "Warehouse",
                columns: new[] { "Id", "DateCreated", "DateModified", "Name" },
                values: new object[] { 1, new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(4826), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(4826), "Testlager" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "cbc43a8e-f7bb-4445-baaf-1add431ffbbf", "8e445865-a24d-4543-a6c6-9443d048cdb9" },
                    { "cac43a6e-f7bb-4448-baaf-1add431ccbbf", "9e224968-33e4-4652-b7b7-8574d048cdb9" }
                });

            migrationBuilder.InsertData(
                table: "SalesChannel",
                columns: new[] { "Id", "DateCreated", "DateModified", "ExportCustomers", "ExportOrders", "ExportProducts", "ImportCustomers", "ImportOrders", "ImportProducts", "InitialProductExportCompleted", "InitialProductImportCompleted", "Name", "Password", "Type", "URL", "Username", "WarehouseId" },
                values: new object[] { 1, new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(5031), new DateTime(2024, 7, 8, 14, 34, 53, 642, DateTimeKind.Utc).AddTicks(5031), false, false, false, false, false, false, false, false, "Kasse Ladengeschäft", "", 1, "", "", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CountryId",
                table: "CustomerAddress",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerAddress_CustomerId",
                table: "CustomerAddress",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSalesChannel_CustomerId",
                table: "CustomerSalesChannel",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemSerialNumber_OrderItemId",
                table: "OrderItemSerialNumber",
                column: "OrderItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Sku",
                table: "Product",
                column: "Sku",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_TaxClassId",
                table: "Product",
                column: "TaxClassId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSalesChannel_ProductId",
                table: "ProductSalesChannel",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSalesChannel_SalesChannelId",
                table: "ProductSalesChannel",
                column: "SalesChannelId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStock_ProductId",
                table: "ProductStock",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductStock_WarehouseId",
                table: "ProductStock",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesChannel_WarehouseId",
                table: "SalesChannel",
                column: "WarehouseId");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingProviderRate_ShippingProviderId",
                table: "ShippingProviderRate",
                column: "ShippingProviderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AiModel");

            migrationBuilder.DropTable(
                name: "AiPrompt");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "CustomerAddress");

            migrationBuilder.DropTable(
                name: "CustomerSalesChannel");

            migrationBuilder.DropTable(
                name: "OrderItemSerialNumber");

            migrationBuilder.DropTable(
                name: "ProductSalesChannel");

            migrationBuilder.DropTable(
                name: "ProductStock");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropTable(
                name: "Shipping");

            migrationBuilder.DropTable(
                name: "ShippingProviderRate");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "OrderItem");

            migrationBuilder.DropTable(
                name: "SalesChannel");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ShippingProvider");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Warehouse");

            migrationBuilder.DropTable(
                name: "TaxClass");

            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
