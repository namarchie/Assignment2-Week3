using Assignment2_Week3_Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Assignment2_Week3_Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                new Province() { ProvinceId = 1, ProvinceName = "Hưng Yên" },
                new Province() { ProvinceId = 2, ProvinceName = "Nghệ An" },
                new Province() { ProvinceId = 3, ProvinceName = "Thanh Hóa" }
                );
            modelBuilder.Entity<District>().HasData(
                new District() { DistrictId = 1, DistrictName = "Yên Mỹ", ProvinceId = 1 },
                new District() { DistrictId = 2, DistrictName = "Khoái Châu", ProvinceId = 1 },
                new District() { DistrictId = 3, DistrictName = "Tiên Lữ", ProvinceId = 1 },
                new District() { DistrictId = 4, DistrictName = "Con Cuông", ProvinceId = 2 },
                new District() { DistrictId = 5, DistrictName = "Đô Lương", ProvinceId = 2 },
                new District() { DistrictId = 6, DistrictName = "Hưng Nguyên", ProvinceId = 2 },
                new District() { DistrictId = 7, DistrictName = "Bá Thước", ProvinceId = 3 },
                new District() { DistrictId = 8, DistrictName = "Cẩm Thủy", ProvinceId = 3 },
                new District() { DistrictId = 9, DistrictName = "Đông Sơn", ProvinceId = 3 }
                );
            modelBuilder.Entity<Commune>().HasData(
                new Commune() { CommuneId = 1, CommuneName = "Đồng Than", DistrictId = 1 },
                new Commune() { CommuneId = 2, CommuneName = "Tân Lập", DistrictId = 1 },
                new Commune() { CommuneId = 3, CommuneName = "Trung Hưng", DistrictId = 1 },
                new Commune() { CommuneId = 4, CommuneName = "Chí Tân", DistrictId = 2 },
                new Commune() { CommuneId = 5, CommuneName = "Dạ Trạch", DistrictId = 2 },
                new Commune() { CommuneId = 6, CommuneName = "Đại Tập", DistrictId = 2 },
                new Commune() { CommuneId = 7, CommuneName = "An Viên", DistrictId = 3 },
                new Commune() { CommuneId = 8, CommuneName = "Cương Chính", DistrictId = 3 },
                new Commune() { CommuneId = 9, CommuneName = "Dị Chế", DistrictId = 3 },
                new Commune() { CommuneId = 10, CommuneName = "Bồng Khê", DistrictId = 4 },
                new Commune() { CommuneId = 11, CommuneName = "Chi Khê", DistrictId = 4 },
                new Commune() { CommuneId = 12, CommuneName = "Đôn Phục", DistrictId = 4 },
                new Commune() { CommuneId = 13, CommuneName = "Bài Sơn", DistrictId = 5 },
                new Commune() { CommuneId = 14, CommuneName = "Đà Sơn", DistrictId = 5 },
                new Commune() { CommuneId = 15, CommuneName = "Đặng Sơn", DistrictId = 5 },
                new Commune() { CommuneId = 16, CommuneName = "Châu Nhân", DistrictId = 6 },
                new Commune() { CommuneId = 17, CommuneName = "Hưng Lĩnh", DistrictId = 6 },
                new Commune() { CommuneId = 18, CommuneName = "Hưng Tây", DistrictId = 6 },
                new Commune() { CommuneId = 19, CommuneName = "Ái Thượng", DistrictId = 7 },
                new Commune() { CommuneId = 20, CommuneName = "Ban Công", DistrictId = 7 },
                new Commune() { CommuneId = 21, CommuneName = "Cành Nàng", DistrictId = 7 },
                new Commune() { CommuneId = 22, CommuneName = "Cẩm Long", DistrictId = 8 },
                new Commune() { CommuneId = 23, CommuneName = "Cẩm Lương", DistrictId = 8 },
                new Commune() { CommuneId = 24, CommuneName = "Cẩm Quý", DistrictId = 8 },
                new Commune() { CommuneId = 25, CommuneName = "Đông Thịnh", DistrictId = 9 },
                new Commune() { CommuneId = 26, CommuneName = "Đông Văn", DistrictId = 9 },
                new Commune() { CommuneId = 27, CommuneName = "Đông Sơn", DistrictId = 9 }
                );
        }
    }
}
