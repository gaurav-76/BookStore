using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookStoreBook.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class PorductIdUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Guid Blyton", 2, "DOT000SY00001", 25.0, 499.0, 20.0, 22.0, "The Famous Five" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price50", "Title" },
                values: new object[] { "Marcel Proust", 2, "OTSI09800001", 25.0, 349.0, 22.0, "In Search of Lost Time" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Ralph Ellison", "09OT00YU70001", 25.0, 299.0, 20.0, 22.0, "Invisible Man" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Caitlin Moran", 3, "TKLQ0056500001", 25.0, 199.0, 20.0, 22.0, "How To Be Famous" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price50", "Title" },
                values: new object[] { "Munshi Premchand", 1, "KLMT000000658", 25.0, 399.0, 22.0, "Godan" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "CategoryId", "ISBN", "Price", "Title" },
                values: new object[] { "Aldous Huxley", 1, "VCDB00605321", 449.0, "Brave New World" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "CategoryId", "ISBN", "Price", "Title" },
                values: new object[] { "Laura Phantom", 3, "FOT000000001", 123.0, "Leaves and Wonders" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price50", "Title" },
                values: new object[] { "Ron Parker", 2, "SOTJ1111111101", 30.0, 27.0, 25.0, "Rock in the Ocean" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Abby Muscles", 2, "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Julian Button", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price50", "Title" },
                values: new object[] { "Nancy Hoover", 1, "CAW777777701", 40.0, 30.0, 25.0, "Dark Skies" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Billy Spark", 1, "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Billy Spark", 1, "SWD9999001", 99.0, 90.0, 80.0, 85.0, "Fortune of Time" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price50", "Title" },
                values: new object[] { "Nancy Hoover", 1, "CAW777777701", 40.0, 30.0, 25.0, "Dark Skies" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Author", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Julian Button", "RITO5555501", 55.0, 50.0, 35.0, 40.0, "Vanish in the Sunset" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Abby Muscles", 2, "WS3333333301", 70.0, 65.0, 55.0, 60.0, "Cotton Candy" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price50", "Title" },
                values: new object[] { "Ron Parker", 2, "SOTJ1111111101", 30.0, 27.0, 25.0, "Rock in the Ocean" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Author", "CategoryId", "ISBN", "Price", "Title" },
                values: new object[] { "Laura Phantom", 3, "FOT000000001", 123.0, "Leaves and Wonders" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Author", "CategoryId", "ISBN", "Price", "Title" },
                values: new object[] { "Aldous Huxley", 1, "VCDB00605321", 449.0, "Brave New World" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price50", "Title" },
                values: new object[] { "Munshi Premchand", 1, "KLMT000000658", 25.0, 399.0, 22.0, "Godan" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Caitlin Moran", 3, "TKLQ0056500001", 25.0, 199.0, 20.0, 22.0, "How To Be Famous" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Author", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Ralph Ellison", "09OT00YU70001", 25.0, 299.0, 20.0, 22.0, "Invisible Man" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price50", "Title" },
                values: new object[] { "Marcel Proust", 2, "OTSI09800001", 25.0, 349.0, 22.0, "In Search of Lost Time" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Author", "CategoryId", "ISBN", "ListPrice", "Price", "Price100", "Price50", "Title" },
                values: new object[] { "Guid Blyton", 2, "DOT000SY00001", 25.0, 499.0, 20.0, 22.0, "The Famous Five" });
        }
    }
}
