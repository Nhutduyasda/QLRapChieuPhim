using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_Model;
using UTIL_Valication;

namespace DAL_Service
{
    public class GiaoDichDAL : SystemDAL<GiaoDichViewDTO, string>
    {
        public override List<GiaoDichViewDTO> selectAll()
        {
            string sql = @"
                            SELECT 
                    dv.MaDatVe,
                    kh.TenKhachHang,
                    nv.TenNhanVien,
                    kh.Email,
                    v.MaSuatChieu,
                    pc.TenPhongChieu,
                    p.TenPhim,
                    v.MaGhe,
                    dv.ThoiGianDatVe,
                    dv.TongTien
                FROM DAT_VE dv
                JOIN KHACH_HANG kh ON dv.MaKhachHang = kh.MaKhachHang
                JOIN NHAN_VIEN nv ON dv.MaNhanVien = nv.MaNhanVien
                JOIN VE v ON dv.MaDatVe = v.MaDatVe
                JOIN SUAT_CHIEU sc ON v.MaSuatChieu = sc.MaSuatChieu
                JOIN PHIM p ON sc.MaPhim = p.MaPhim
                JOIN PHONG_CHIEU pc ON sc.MaPhongChieu = pc.MaPhongChieu
                ";

            return selectBySql(sql, new List<object>());
        }

        public override GiaoDichViewDTO selectById(string id)
        {
            string sql = @"
        SELECT 
            dv.MaDatVe AS MaGiaoDich,
            kh.TenKhachHang,
            kh.Email,
            nv.TenNhanVien,
            dv.ThoiGianDatVe,
            dv.TongTien,
            v.MaSuatChieu,
            pc.TenPhongChieu,
            p.TenPhim,
            v.MaGhe
        FROM DAT_VE dv
        JOIN KHACH_HANG kh ON dv.MaKhachHang = kh.MaKhachHang
        JOIN NHAN_VIEN nv ON dv.MaNhanVien = nv.MaNhanVien
        JOIN VE v ON dv.MaDatVe = v.MaDatVe
        JOIN SUAT_CHIEU sc ON v.MaSuatChieu = sc.MaSuatChieu
        JOIN PHIM p ON sc.MaPhim = p.MaPhim
        JOIN PHONG_CHIEU pc ON sc.MaPhongChieu = pc.MaPhongChieu
        WHERE dv.MaDatVe = @0";

            List<object> args = new List<object> { id };
            var list = selectBySql(sql, args);
            return list.Count > 0 ? list[0] : null;
        }


        public override List<GiaoDichViewDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<GiaoDichViewDTO> list = new List<GiaoDichViewDTO>();
            SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
            while (reader.Read())
            {
                GiaoDichViewDTO gd = new GiaoDichViewDTO
                {
                    MaDatVe = reader["MaDatVe"].ToString(),
                    TenKhachHang = reader["TenKhachHang"].ToString(),
                    Email = reader["Email"].ToString(),
                    TenNhanVien = reader["TenNhanVien"].ToString(),
                    ThoiGianDatVe = Convert.ToDateTime(reader["ThoiGianDatVe"]),
                    TongTien = Convert.ToDecimal(reader["TongTien"]),
                    MaSuatChieu = reader["MaSuatChieu"].ToString(),
                    TenPhongChieu = reader["TenPhongChieu"].ToString(),
                    TenPhim = reader["TenPhim"].ToString(),
                    MaGhe = reader["MaGhe"].ToString()
                };
                list.Add(gd);
            }
            reader.Close();
            return list;
        }


        // Không cần Insert/Update/Delete vì ViewDTO này chỉ dùng để hiển thị join
        public override void Insert(GiaoDichViewDTO entity) { throw new NotImplementedException(); }
        public override void Update(GiaoDichViewDTO entity) { throw new NotImplementedException(); }
        public override void Delete(string id) { throw new NotImplementedException(); }
    }
}
