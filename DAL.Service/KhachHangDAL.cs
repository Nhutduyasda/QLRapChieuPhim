﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTIL_Valication;
using DTO_Model;
using System.Data;
using Microsoft.Data.SqlClient;

namespace DAL_Service
{
    public class KhachHangDAL : SystemDAL<KhachHang, string>
    {
        public string generateAutoMaKhachHang(string KHACH_HANG, string MaKhachHang, string KH)
        {
            return DBUTIL.GenerateId(KHACH_HANG, MaKhachHang, KH);
        }
        public override List<KhachHang> selectAll()
        {
            string sql = "SELECT * FROM KHACH_HANG";
            return selectBySql(sql, new List<object>());
        }
        public override KhachHang selectById(string id)
        {
            string sql = "SELECT * FROM KHACH_HANG WHERE MaKhachHang = @0";
            List<object> args = new List<object> { id };
            List<KhachHang> result = selectBySql(sql, args);
            return result.Count > 0 ? result[0] : null;
        }
        public override List<KhachHang> selectBySql(string sql, List<object> args, CommandType cmdType = CommandType.Text)
        {
            List<KhachHang> list = new List<KhachHang>();
            try
            {
                SqlDataReader reader = DBUTIL.Query(sql, args, cmdType);
                while (reader.Read())
                {
                    KhachHang khachHang = new KhachHang
                    {
                        MaKhachHang = reader["MaKhachHang"].ToString(),
                        TenKhachHang = reader["TenKhachHang"].ToString(),
                        Email = reader["Email"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        MatKhau = reader["MatKhauHash"].ToString(),

                    };
                    list.Add(khachHang);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Error selecting KhachHang by SQL", ex);
            }
            return list;
        }
        public override void Insert(KhachHang entity)
        {
            string sql = "INSERT INTO KHACH_HANG (MaKhachHang, TenKhachHang, Email, SoDienThoai, MatKhauHash) VALUES (@0, @1, @2, @3, @4)";
            List<object> parameters = new List<object>
            {
                entity.MaKhachHang,
                entity.TenKhachHang,
                entity.Email,
                entity.SoDienThoai,
                entity.MatKhau
            };
            DBUTIL.Update(sql, parameters);
        }

        public override void Update(KhachHang entity)
        {
            string sql = "UPDATE KHACH_HANG SET TenKhachHang = @1, Email = @2, SoDienThoai = @3, MatKhauHash = @4 WHERE MaKhachHang = @0";
            List<object> parameters = new List<object>
            {
                entity.MaKhachHang,
                entity.TenKhachHang,
                entity.Email,
                entity.SoDienThoai,
                entity.MatKhau
            };
            DBUTIL.Update(sql, parameters);
        }

        public override void Delete(string id)
        {
            string sql = "DELETE FROM KHACH_HANG WHERE MaKhachHang = @0";
            List<object> parameters = new List<object> { id };
            DBUTIL.Update(sql, parameters);
        }

    }
}
