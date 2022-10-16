using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class PublishedPropertyAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58ac18a1-d6dd-4419-a4d1-497f9f34e6f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "946356ab-33ba-4b60-8cb2-f3532de50004");

            migrationBuilder.AddColumn<bool>(
                name: "Published",
                table: "Courses",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff860db9-cb7a-4090-9fea-0ba083b77d73", "e885ae1f-7c57-4263-855b-3f0246b744f6", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b7b2ed5-2416-4736-b4ca-2aa279f71043", "6b8bb384-4ea3-41c8-bd3d-a5a2fc4faa95", "Instructor", "INSTRUCTOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b7b2ed5-2416-4736-b4ca-2aa279f71043");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff860db9-cb7a-4090-9fea-0ba083b77d73");

            migrationBuilder.DropColumn(
                name: "Published",
                table: "Courses");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "58ac18a1-d6dd-4419-a4d1-497f9f34e6f4", "da64bca1-c5f2-4d18-856e-77cdd741a05b", "Student", "STUDENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "946356ab-33ba-4b60-8cb2-f3532de50004", "a269886f-fb44-49a7-bcd0-4b6c8da1a98a", "Instructor", "INSTRUCTOR" });
        }
    }
}
