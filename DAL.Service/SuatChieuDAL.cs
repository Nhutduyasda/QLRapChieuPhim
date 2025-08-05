using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using DTO_Model;
using UTIL_Valication;

namespace DAL_Service
{
    public class SuatChieuDAL : SystemDAL<SuatChieuDTO, string>
    {
        public string GenerateAutoMaSuatChieu(string tableName, string columnName, string prefix)
        {
            return DBUTIL.GenerateId(tableName, columnName, prefix);
        }

        public override List<SuatChieuDTO> selectAll()
        {
            string sql = "SELECT * FROM SUAT_CHIEU";
            return selectBySql(sql, new List<object>());
        }

        public override SuatChieuDTO selectById(string id)
        {
            string sql = "SELECT * FROM SUAT_CHIEU WHERE MaSuatChieu = @0";
            List<object> args = new List<object> { id };
            List<SuatChieuDTO> result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }

        public override List<SuatChieuDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<SuatChieuDTO> list = new List<SuatChieuDTO>();
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
                while (reader.Read())
                {
                    SuatChieuDTO sc = new SuatChieuDTO
                    {
                        MaSuatChieu = reader["MaSuatChieu"].ToString(),
                        MaPhim = reader["MaPhim"].ToString(),
                        MaPhongChieu = reader["MaPhongChieu"].ToString(),   
                        NgayChieu = Convert.ToDateTime(reader["NgayChieu"]),
                        GioBatDau = (TimeSpan)reader["ThoiGianBatDau"],
                        GioKetThuc = (TimeSpan)reader["ThoiGianKetThuc"],
                        GiaVe = Convert.ToDecimal(reader["GiaVe"]),
                    };
                    list.Add(sc);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting SuatChieu by SQL", ex);
            }
            return list;
        }

        public override void Insert(SuatChieuDTO entity)
        {
            string sql = @"INSERT INTO SUAT_CHIEU (MaSuatChieu, MaPhim, MaPhongChieu, NgayChieu, ThoiGianBatDau, ThoiGianKetThuc, GiaVe, TinhTrang)
               VALUES (@0, @1, @2, @3, @4, @5, @6, @7)";
            List<object> parameters = new List<object>
            {
                entity.MaSuatChieu,
                entity.MaPhim,
                entity.MaPhongChieu,
                entity.NgayChieu,
                entity.GioBatDau,
                entity.GioKetThuc,
                entity.GiaVe,
                entity.TinhTrang ?? "Đang chiếu"
             };
            DBUTIL.Update(sql, parameters);
        }

        public override void Update(SuatChieuDTO entity)
        {
            string sql = @"UPDATE SUAT_CHIEU 
                           SET MaPhim = @1, MaPhongChieu = @2,
                               NgayChieu = @3, ThoiGianBatDau = @4, ThoiGianKetThuc = @5, GiaVe = @6 , TinhTrang = @7
                           WHERE MaSuatChieu = @0";
            List<object> parameters = new List<object>
            {
                entity.MaSuatChieu,
                entity.MaPhim,
                entity.MaPhongChieu,
                entity.NgayChieu,
                entity.GioBatDau,
                entity.GioKetThuc,
                entity.GiaVe,
                 entity.TinhTrang ?? "Đang chiếu"
            };
            DBUTIL.Update(sql, parameters);
        }

        public override void Delete(string id)
        {
            string sql = "DELETE FROM SUAT_CHIEU WHERE MaSuatChieu = @0";
            List<object> parameters = new List<object> { id };
            DBUTIL.Update(sql, parameters);
        }
        public List<ThayDoiTrangThaiPhimView> SelectViewThayDoiTrangThaiPhim()
        {
            List<ThayDoiTrangThaiPhimView> list = new List<ThayDoiTrangThaiPhimView>();
            string sql = @"
            SELECT
                SC.MaSuatChieu,
                SC.NgayChieu,
                SC.ThoiGianKetThuc,
                P.TinhTrang
            FROM SUAT_CHIEU SC
            JOIN PHIM P ON SC.MaPhim = P.MaPhim
            ";
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, new List<object>());
                while (reader.Read())
                {
                    ThayDoiTrangThaiPhimView item = new ThayDoiTrangThaiPhimView
                    {
                        MaSuatChieu = reader["MaSuatChieu"].ToString(),
                        NgayChieu = reader["NgayChieu"].ToString(),
                        ThoiGianKetThuc = reader["ThoiGianKetThuc"].ToString(),
                        TinhTrang = reader["TinhTrang"].ToString()
                    };
                    list.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting ThayDoiTrangThaiPhimView", ex);
            }
            return list;
        }
        
        public void UpdateTinhTrang(string maSuatChieu, string tinhTrang)
        {
            string sql = "UPDATE SUAT_CHIEU SET TinhTrang = @0 WHERE MaSuatChieu = @1";
            List<object> parameters = new List<object> { tinhTrang, maSuatChieu };
            DBUTIL.Update(sql, parameters);
        }
        public List<SuatChieuView> SelectViewPhimSuatChieu()
        {
            List<SuatChieuView> list = new List<SuatChieuView>();
            string sql = @"
            SELECT 
                SC.MaSuatChieu,
                P.TenPhim,
                PC.MaPhongChieu,
                PC.TenPhongChieu,
                P.HinhAnh,
                SC.GiaVe,
                P.TinhTrang
            FROM SUAT_CHIEU SC
            JOIN PHIM P ON SC.MaPhim = P.MaPhim
            JOIN PHONG_CHIEU PC ON SC.MaPhongChieu = PC.MaPhongChieu

    ";
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, new List<object>());
                while (reader.Read())
                {
                    SuatChieuView item = new SuatChieuView
                    {
                        MaSuatChieu = reader["MaSuatChieu"].ToString(),
                        TenPhim = reader["TenPhim"].ToString(),
                        MaPhongChieu = reader["MaPhongChieu"].ToString(),
                        TenPhongChieu = reader["TenPhongChieu"].ToString(),
                        HinhAnh = reader["HinhAnh"].ToString(),
                        GiaVe = Convert.ToDecimal(reader["GiaVe"]),
                    };
                    list.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting SuatChieuPhimViewDTO", ex);
            }

            return list;
        }
        public List<ViewSuatChieu> viewSuatChieu()
        {
            List<ViewSuatChieu> list = new List<ViewSuatChieu>();
            string sql = @"
        SELECT 
            SC.MaSuatChieu,
            P.TenPhim,
            PC.TenPhongChieu,
            SC.NgayChieu,
            SC.ThoiGianBatDau,
            SC.ThoiGianKetThuc,
            SC.GiaVe
        FROM SUAT_CHIEU SC
        JOIN PHIM P ON SC.MaPhim = P.MaPhim
        JOIN PHONG_CHIEU PC ON SC.MaPhongChieu = PC.MaPhongChieu
    ";
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, new List<object>());
                while (reader.Read())
                {
                    ViewSuatChieu item = new ViewSuatChieu
                    {
                        MaSuatChieu = reader["MaSuatChieu"].ToString(),
                        TenPhim = reader["TenPhim"].ToString(),
                        TenPhongChieu = reader["TenPhongChieu"].ToString(),
                        NgayChieu = Convert.ToDateTime(reader["NgayChieu"]),
                        ThoiGianBatDau = (TimeSpan)reader["ThoiGianBatDau"],
                        ThoiGianKetThuc = (TimeSpan)reader["ThoiGianKetThuc"],
                        GiaVe = Convert.ToDecimal(reader["GiaVe"])
                    };
                    list.Add(item);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting ViewSuatChieu", ex);
            }

            return list;
        }


        public SuatChieuDTO selectByMa(string maSuat)
        {
            string query = "SELECT * FROM SUAT_CHIEU WHERE MaSuatChieu = @0";
            List<object> parameters = new List<object>() { maSuat };
            SqlDataReader reader = DBUTIL.Query(query, parameters);

            if (reader.Read())
            {
                SuatChieuDTO sc = new SuatChieuDTO
                {
                    MaSuatChieu = reader["MaSuatChieu"].ToString(),
                    MaPhongChieu = reader["MaPhongChieu"].ToString(),
                    MaPhim = reader["MaPhim"].ToString(),
                    NgayChieu = Convert.ToDateTime(reader["NgayChieu"]),
                    GioBatDau = (TimeSpan)reader["ThoiGianBatDau"],
                    GioKetThuc = (TimeSpan)reader["ThoiGianKetThuc"]
                };
                reader.Close();
                return sc;
            }
            reader.Close();
            return null;
        }


    }
}
