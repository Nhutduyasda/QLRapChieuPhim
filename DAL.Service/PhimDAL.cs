using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Model;
using Microsoft.Data.SqlClient;
using UTIL_Valication;

namespace DAL_Service
{
    public class PhimDAL : SystemDAL<PhimDTO, string>
    {
        public string generateAutoMaPhim(string PHIM, string MaPhim, string P)
        {
            return DBUTIL.GenerateId(PHIM, MaPhim, P);
        }
        public override List<PhimDTO> selectAll()
        {
            string sql = "SELECT * FROM PHIM";
            return selectBySql(sql, new List<object>());
        }
        public override PhimDTO selectById(string id)
        {
            string sql = "SELECT * FROM PHIM WHERE MaPhim = @0";
            List<object> args = new List<object> { id };
            List<PhimDTO> result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }
        public override List<PhimDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<PhimDTO> list = new List<PhimDTO>();
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
                while (reader.Read())
                {
                    PhimDTO phim = new PhimDTO
                    {
                        MaPhim = reader["MaPhim"].ToString(),
                        MaRapChieu = reader["MaRapChieu"].ToString(),
                        HinhAnh = reader["HinhAnh"].ToString(),
                        TieuDe = reader["TieuDe"].ToString(),
                        MoTa = reader["MoTa"].ToString(),
                        ThoiLuong = reader["ThoiLuong"] != DBNull.Value ? Convert.ToInt32(reader["ThoiLuong"]) : 0,
                        NgayPhatHanh = reader["NgayPhatHanh"] != DBNull.Value ? Convert.ToDateTime(reader["NgayPhatHanh"]).ToString("yyyy-MM-dd") : string.Empty,
                        DoTuoi = reader["DoTuoi"].ToString(),
                    };
                    list.Add(phim);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting Phim by SQL", ex);
            }
            return list;
        }
        public override void Insert(PhimDTO entity)
        {
            string sql = "INSERT INTO PHIM (MaPhim, MaRapChieu, HinhAnh, TieuDe, MoTa, ThoiLuong, NgayPhatHanh, DoTuoi)" +
                " VALUES (@0, @1, @2, @3, @4, @5, @6, @7)";
            List<object> parameters = new List<object>
            {
                entity.MaPhim,
                entity.MaRapChieu,
                entity.HinhAnh,
                entity.MoTa,
                entity.ThoiLuong,
                entity.NgayPhatHanh,
                entity.DoTuoi
            };
            DBUTIL.Update(sql, parameters);
        }
        public override void Update(PhimDTO entity)
        {
            string sql = "UPDATE PHIM SET MaRapChieu = @1, HinhAnh = @2, TieuDe = @3, MoTa = @4, ThoiLuong = @5, NgayPhatHanh = @6, MoTa = @7 WHERE MaPhim = @0";
            List<object> parameters = new List<object>
            {
                entity.MaPhim,
                entity.MaRapChieu,
                entity.HinhAnh,
                entity.MoTa,
                entity.ThoiLuong,
                entity.NgayPhatHanh,
                entity.DoTuoi
            };
            DBUTIL.Update(sql, parameters);
        }
        public override void Delete(string id)
        {
            string sql = "DELETE FROM PHIM WHERE MaPhim = @0";
            List<object> parameters = new List<object> { id };
            DBUTIL.Update(sql, parameters);
        }
    }
}
