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
    public class TheLoaiDAL : SystemDAL<TheLoaiDTO, string>
    {
        public string generateAutoMaTheLoai(string THE_LOAI, string MaTheLoai, string TL)
        {
            return DBUTIL.GenerateId(THE_LOAI, MaTheLoai, TL);
        }
        public override List<TheLoaiDTO> selectAll()
        {
            string sql = "SELECT * FROM THE_LOAI";
            return selectBySql(sql, new List<object>());
        }
        public override TheLoaiDTO selectById(string id)
        {
            string sql = "SELECT * FROM THE_LOAI WHERE MaTheLoai = @0";
            List<object> args = new List<object> { id };
            List<TheLoaiDTO> result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }
        public override List<TheLoaiDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<TheLoaiDTO> list = new List<TheLoaiDTO>();
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
                while (reader.Read())
                {
                    TheLoaiDTO theLoai = new TheLoaiDTO
                    {
                        MaTheLoai = reader["MaTheLoai"].ToString(),
                        TenTheLoai = reader["TenTheLoai"].ToString(),
                        MoTa = reader["MoTa"] != DBNull.Value ? reader["MoTa"].ToString() : string.Empty
                    };
                    list.Add(theLoai);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting TheLoai by SQL", ex);
            }
            return list;
        }
        public override void Insert(TheLoaiDTO entity)
        {
            string sql = "INSERT INTO THE_LOAI (MaTheLoai, TenTheLoai, MoTa) VALUES (@0, @1, @2)";
            List<object> args = new List<object>
            {
                entity.MaTheLoai,
                entity.TenTheLoai,
                entity.MoTa
            };
            DBUTIL.Update(sql, args);
        }
        public override void Update(TheLoaiDTO entity)
        {
            string sql = "UPDATE THE_LOAI SET TenTheLoai = @0, MoTa = @1 WHERE MaTheLoai = @2";
            List<object> args = new List<object>
            {
                entity.TenTheLoai,
                entity.MoTa,
                entity.MaTheLoai
            };
            DBUTIL.Update(sql, args);
        }
        public override void Delete(string id)
        {
            string sql = "DELETE FROM THE_LOAI WHERE MaTheLoai = @0";
            List<object> args = new List<object> { id };
            DBUTIL.Update(sql, args);
        }
    }
}
