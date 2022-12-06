using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class def : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BrandName = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerAddress = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerTaxNumber = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerTaxOffice = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerMail = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerPhone = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    customerid = table.Column<int>(type: "INTEGER", nullable: false),
                    brandid = table.Column<int>(type: "INTEGER", nullable: false),
                    Model = table.Column<string>(type: "TEXT", nullable: false),
                    Color = table.Column<string>(type: "TEXT", nullable: false),
                    Inch = table.Column<string>(type: "TEXT", nullable: false),
                    PackageType = table.Column<string>(type: "TEXT", nullable: false),
                    WashType = table.Column<string>(type: "TEXT", nullable: false),
                    ProductDate = table.Column<string>(type: "TEXT", nullable: false),
                    Deadline = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    PhotoPath = table.Column<string>(type: "TEXT", nullable: true),
                    s28 = table.Column<int>(type: "INTEGER", nullable: false),
                    s30 = table.Column<int>(type: "INTEGER", nullable: false),
                    s32 = table.Column<int>(type: "INTEGER", nullable: false),
                    s34 = table.Column<int>(type: "INTEGER", nullable: false),
                    s36 = table.Column<int>(type: "INTEGER", nullable: false),
                    s38 = table.Column<int>(type: "INTEGER", nullable: false),
                    s40 = table.Column<int>(type: "INTEGER", nullable: false),
                    s42 = table.Column<int>(type: "INTEGER", nullable: false),
                    s44 = table.Column<int>(type: "INTEGER", nullable: false),
                    s46 = table.Column<int>(type: "INTEGER", nullable: false),
                    s48 = table.Column<int>(type: "INTEGER", nullable: false),
                    s50 = table.Column<int>(type: "INTEGER", nullable: false),
                    sCount = table.Column<int>(type: "INTEGER", nullable: true),
                    k28 = table.Column<int>(type: "INTEGER", nullable: false),
                    k30 = table.Column<int>(type: "INTEGER", nullable: false),
                    k32 = table.Column<int>(type: "INTEGER", nullable: false),
                    k34 = table.Column<int>(type: "INTEGER", nullable: false),
                    k36 = table.Column<int>(type: "INTEGER", nullable: false),
                    k38 = table.Column<int>(type: "INTEGER", nullable: false),
                    k40 = table.Column<int>(type: "INTEGER", nullable: false),
                    k42 = table.Column<int>(type: "INTEGER", nullable: false),
                    k44 = table.Column<int>(type: "INTEGER", nullable: false),
                    k46 = table.Column<int>(type: "INTEGER", nullable: false),
                    k48 = table.Column<int>(type: "INTEGER", nullable: false),
                    k50 = table.Column<int>(type: "INTEGER", nullable: false),
                    kCount = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.id);
                    table.ForeignKey(
                        name: "FK_orders_brands_brandid",
                        column: x => x.brandid,
                        principalTable: "brands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_orders_customers_customerid",
                        column: x => x.customerid,
                        principalTable: "customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_orders_brandid",
                table: "orders",
                column: "brandid");

            migrationBuilder.CreateIndex(
                name: "IX_orders_customerid",
                table: "orders",
                column: "customerid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "customers");
        }
    }
}
