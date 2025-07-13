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
    public class DienVienDAL : SystemDAL<DienVienDTO, string>
    {

        public string generateAutoMaDienVien(string DIEN_VIEN, string MaDienVien, string DV)
        {
            return DBUTIL.GenerateId(DIEN_VIEN, MaDienVien, DV);
        }
        public override List<DienVienDTO> selectAll()
        {
            string sql = "SELECT * FROM DIEN_VIEN";
            return selectBySql(sql, new List<object>());
        }
        public override DienVienDTO selectById(string id)
        {
            string sql = "SELECT * FROM DIEN_VIEN WHERE MaDienVien = @0";
            List<object> args = new List<object> { id };
            List<DienVienDTO> result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }
        public override List<DienVienDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<DienVienDTO> list = new List<DienVienDTO>();
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
                while (reader.Read())
                {
                    DienVienDTO dienVien = new DienVienDTO
                    {
                        MaDienVien = reader["MaDienVien"].ToString(),
                        TenDienVien = reader["TenDienVien"].ToString(),
                        TieuSu = reader["TieuSu"].ToString()
                    };
                    list.Add(dienVien);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting DienVien by SQL", ex);
            }
            return list;
        }
        public override void Insert(DienVienDTO entity)
        {
            string sql = "INSERT INTO DIEN_VIEN (MaDienVien, TenDienVien, TieuSu) VALUES (@0, @1, @2)";
            List<object> parameters = new List<object>
            {
                entity.MaDienVien,
                entity.TenDienVien,
                entity.TieuSu
            };
            DBUTIL.Update(sql, parameters);
        }

        public override void Update(DienVienDTO entity)
        {
            string sql = "UPDATE DIEN_VIEN SET TenDienVien = @1, TieuSu = @2 WHERE MaDienVien = @0";
            List<object> parameters = new List<object>
            {
                entity.MaDienVien,
                entity.TenDienVien,
                entity.TieuSu
            };
            DBUTIL.Update(sql, parameters);
        }
        public override void Delete(string id)
        {
            string sql = "DELETE FROM DIEN_VIEN WHERE MaDienVien = @0";
            List<object> parameters = new List<object> { id };
            DBUTIL.Update(sql, parameters);

        }
    }
}
