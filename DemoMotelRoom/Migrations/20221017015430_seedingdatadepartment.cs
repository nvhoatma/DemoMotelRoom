using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DemoMotelRoom.Migrations
{
    public partial class seedingdatadepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                    table: "department",
                    columns: new[] {"Name", "Descriptions" },
                    values: new object[] { "Phong_03", "khách sạn HCM Tuyệt vời Thoải Mái" });

            migrationBuilder.InsertData(
                table: "department",
                columns: new[] { "Name", "Descriptions",},
                values: new object[] { "Phong_088", "khách sạn HCM Tuyệt vời giường Rộng" });

            migrationBuilder.InsertData(
                table: "department",
                columns: new[] { "Name", "Descriptions" },
                values: new object[] { "Phong_007", "khách sạn HCM Tuyệt vời Ấm", });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            
        }
    }
}
