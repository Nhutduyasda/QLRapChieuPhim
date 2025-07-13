using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIL_Valication;
using DTO_Model;
using Microsoft.Data.SqlClient;
using System.Data;

namespace DAL_Service
{
    public class DaoDienDAL : SystemDAL<DaoDienDTO, string>
    {
        public string generateAutoMaDaoDien(string DAO_DIEN, string MaDaoDien, string DD)
        {
            return DBUTIL.GenerateId(DAO_DIEN, MaDaoDien, DD);
        }

        public override List<DaoDienDTO> selectAll()
        {
            string sql = "SELECT * FROM DAO_DIEN";
            return selectBySql(sql, new List<object>());
        }
        public override DaoDienDTO selectById(string id)
        {
            string sql = "SELECT * FROM DAO_DIEN WHERE MaDaoDien = @0";
            List<object> args = new List<object> { id };
            List<DaoDienDTO> result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }

        public override List<DaoDienDTO> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<DaoDienDTO> list = new List<DaoDienDTO>();
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
                while (reader.Read())
                {
                    DaoDienDTO daoDien = new DaoDienDTO
                    {
                        MaDaoDien = reader["MaDaoDien"].ToString(),
                        TenDaoDien = reader["TenDaoDien"].ToString(),
                        TieuSu = reader["TieuSu"].ToString()
                    };
                    list.Add(daoDien);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting DaoDien by SQL", ex);
            }
            return list;
        }

        public override void Insert(DaoDienDTO entity)
        {

            string sql = "INSERT INTO DAO_DIEN (MaDaoDien, TenDaoDien, TieuSu) VALUES (@0, @1, @2)";
            List<object> parameters = new List<object>
            {
                entity.MaDaoDien,
                entity.TenDaoDien,
                entity.TieuSu
            };
            DBUTIL.Update(sql, parameters);
        }
        public override void Update(DaoDienDTO entity)
        {
            string sql = "UPDATE DAO_DIEN SET TenDaoDien = @1, TieuSu = @2 WHERE MaDaoDien = @0";
            List<object> parameters = new List<object>
            {
                entity.MaDaoDien,
                entity.TenDaoDien,
                entity.TieuSu
            };
            DBUTIL.Update(sql, parameters);
        }
        public override void Delete(string id)
        {
            string sql = "DELETE FROM DAO_DIEN WHERE MaDaoDien = @0";
            List<object> parameters = new List<object> { id };
            DBUTIL.Update(sql, parameters);
        }


    }
}
