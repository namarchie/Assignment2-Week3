using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment2_Week3_Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceId", "ProvinceName" },
                values: new object[,]
                {
                    { 1, "Hưng Yên" },
                    { 2, "Nghệ An" },
                    { 3, "Thanh Hóa" }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Address", "CommuneId", "Name", "Phone", "Yob" },
                values: new object[,]
                {
                    { 1, "Thôn Liêu Hạ", 9, "Hoàng Văn A", 357490115, 1998 },
                    { 2, "Xóm Đen Vâu", 17, "Đỗ Văn B", 985471843, 1992 },
                    { 3, "Số nhà 68", 22, "Luyện Văn C", 785392104, 1995 }
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "DistrictId", "DistrictName", "ProvinceId" },
                values: new object[,]
                {
                    { 1, "Yên Mỹ", 1 },
                    { 2, "Khoái Châu", 1 },
                    { 3, "Tiên Lữ", 1 },
                    { 4, "Con Cuông", 2 },
                    { 5, "Đô Lương", 2 },
                    { 6, "Hưng Nguyên", 2 },
                    { 7, "Bá Thước", 3 },
                    { 8, "Cẩm Thủy", 3 },
                    { 9, "Đông Sơn", 3 }
                });

            migrationBuilder.InsertData(
                table: "Communes",
                columns: new[] { "CommuneId", "CommuneName", "DistrictId" },
                values: new object[,]
                {
                    { 1, "Đồng Than", 1 },
                    { 25, "Đông Thịnh", 9 },
                    { 24, "Cẩm Quý", 8 },
                    { 23, "Cẩm Lương", 8 },
                    { 22, "Cẩm Long", 8 },
                    { 21, "Cành Nàng", 7 },
                    { 20, "Ban Công", 7 },
                    { 19, "Ái Thượng", 7 },
                    { 18, "Hưng Tây", 6 },
                    { 17, "Hưng Lĩnh", 6 },
                    { 16, "Châu Nhân", 6 },
                    { 15, "Đặng Sơn", 5 },
                    { 26, "Đông Văn", 9 },
                    { 14, "Đà Sơn", 5 },
                    { 12, "Đôn Phục", 4 },
                    { 11, "Chi Khê", 4 },
                    { 10, "Bồng Khê", 4 },
                    { 9, "Dị Chế", 3 },
                    { 8, "Cương Chính", 3 },
                    { 7, "An Viên", 3 },
                    { 6, "Đại Tập", 2 },
                    { 5, "Dạ Trạch", 2 },
                    { 4, "Chí Tân", 2 },
                    { 3, "Trung Hưng", 1 },
                    { 2, "Tân Lập", 1 },
                    { 13, "Bài Sơn", 5 },
                    { 27, "Đông Sơn", 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Communes",
                keyColumn: "CommuneId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "DistrictId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceId",
                keyValue: 3);
        }
    }
}
