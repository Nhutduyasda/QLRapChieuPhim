using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Model;
using Microsoft.Data.SqlClient;
using SharpCompress.Common;
using UTIL_Valication;

namespace DAL_Service
{
    public class PhongChieuDAL
    {
        
        public string GenerateAutoMaPhongChieu(string PHONG_CHIEU, string MaPhongChieu, string P)
        {
            return DBUTIL.GenerateId(PHONG_CHIEU, MaPhongChieu, P);
        }
        public List<PhongChieuDTO> selectAll()
        {
            string sql = "SELECT * FROM PHONG_CHIEU";
            return selectBySql(sql, new List<object>());
        }
        public PhongChieuDTO selectById(string id)
        {
            string sql = "SELECT * FROM PHONG_CHIEU WHERE MaPhongChieu = @0";
            List<object> args = new List<object> { id };
            List<PhongChieuDTO> result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }
        public List<PhongChieuDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhongChieuDTO> list = new List<PhongChieuDTO>();
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
                while (reader.Read())
                {
                    PhongChieuDTO phongChieu = new PhongChieuDTO
                    {
                        MaPhongChieu = reader["MaPhongChieu"].ToString(),
                        MaRapChieu = reader["MaRapChieu"].ToString(),
                        TenPhongChieu = reader["TenPhongChieu"].ToString(),
                        SucChua = Convert.ToInt32(reader["SucChua"]),
                    };
                    list.Add(phongChieu);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting PhongChieu by SQL", ex);
            }
            return list;
        }

        public void insert(PhongChieuDTO phong)
        {
            string newId = DBUTIL.GenerateId("PHONG_CHIEU", "MaPhongChieu", "PC");
            phong.MaPhongChieu = newId;

            string sql = "INSERT INTO PHONG_CHIEU (MaPhongChieu, MaRapChieu, TenPhongChieu, SucChua) VALUES (@0, @1, @2, @3)";
            DBUTIL.Update(sql, new List<object> { phong.MaPhongChieu, phong.MaRapChieu, phong.TenPhongChieu, phong.SucChua });
        }


        public void update(PhongChieuDTO phong)
        {
            string sql = "UPDATE PHONG_CHIEU SET MaRapChieu = @0, TenPhongChieu = @1, SucChua = @2 " +
                         "WHERE MaPhongChieu = @3";
            List<object> args = new List<object>
            {
                phong.MaRapChieu,
                phong.TenPhongChieu,
                phong.SucChua,
                phong.MaPhongChieu
            };

            DBUTIL.Update(sql, args);
        }

        public void delete(string maPhong)
        {
            string sqlGhe = "DELETE FROM GHE WHERE MaPhongChieu = @0";
            DBUTIL.Update(sqlGhe, new List<object> { maPhong });

            string sql = "DELETE FROM PHONG_CHIEU WHERE MaPhongChieu = @0";
            DBUTIL.Update(sql, new List<object> { maPhong });
        }

        public void InsertWithSeats(PhongChieuDTO phong, int soHang, int soCot)
        {
            try
            {
                // Thêm phòng chiếu vào bảng PHONG_CHIEU
                string sql = "INSERT INTO PHONG_CHIEU (MaPhongChieu, MaRapChieu, TenPhongChieu, SucChua) VALUES (@0, @1, @2, @3)";
                List<object> parameters = new List<object>
                {
                    phong.MaPhongChieu,
                    phong.MaRapChieu,
                    phong.TenPhongChieu,
                    phong.SucChua
                };
                DBUTIL.Update(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting PhongChieu with seats", ex);
            }

            try
            {
                for (int i = 0; i < soHang; i++)
                {
                    char hang = (char)('A' + i); // Hàng A, B, C,...
                    for (int j = 1; j <= soCot; j++)
                    {
                        string tenGhe = $"{hang}{j}"; // A1, A2,...
                        string maGhe = $"{phong.MaPhongChieu}_{tenGhe}"; 

                        string sqlGhe = "INSERT INTO GHE (MaGhe, MaPhongChieu, TenGhe, TrangThai, ViTri) VALUES (@0, @1, @2, @3, @4)";
                        DBUTIL.Update(sqlGhe, new List<object> { maGhe, phong.MaPhongChieu, tenGhe, "Trống", tenGhe });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting seats for PhongChieu", ex);
            }
        }
        public void updateWithSeats(PhongChieuDTO phong, int soHang, int soCot)
        {
            try
            {
                // Cập nhật thông tin phòng chiếu
                string sql = "UPDATE PHONG_CHIEU SET MaRapChieu = @0, TenPhongChieu = @1, SucChua = @2 WHERE MaPhongChieu = @3";
                List<object> parameters = new List<object>
                {
                    phong.MaRapChieu,
                    phong.TenPhongChieu,
                    phong.SucChua,
                    phong.MaPhongChieu
                };
                DBUTIL.Update(sql, parameters);
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating PhongChieu with seats", ex);
            }
            try
            {
                // Xóa ghế cũ trước khi thêm ghế mới
                string sqlDeleteGhe = "DELETE FROM GHE WHERE MaPhongChieu = @0";
                DBUTIL.Update(sqlDeleteGhe, new List<object> { phong.MaPhongChieu });
                // Thêm ghế mới
                for (int i = 0; i < soHang; i++)
                {
                    char hang = (char)('A' + i); // Hàng A, B, C,...
                    for (int j = 1; j <= soCot; j++)
                    {
                        string tenGhe = $"{hang}{j}"; // A1, A2,...
                        string maGhe = $"{phong.MaPhongChieu}_{tenGhe}";
                        string sqlGhe = "INSERT INTO GHE (MaGhe, MaPhongChieu, TenGhe, TrangThai, ViTri) VALUES (@0, @1, @2, @3, @4)";
                        DBUTIL.Update(sqlGhe, new List<object> { maGhe, phong.MaPhongChieu, tenGhe, "Trống", tenGhe });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating seats for PhongChieu", ex);
            }
        }

    }
}
