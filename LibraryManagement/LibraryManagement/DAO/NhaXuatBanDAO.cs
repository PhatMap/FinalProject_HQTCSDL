﻿using LibraryManagement.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class NhaXuatBanDAO
    {
        private static NhaXuatBanDAO instance;
        public static NhaXuatBanDAO Instance
        {
            get { if (instance == null) instance = new NhaXuatBanDAO(); return instance; }
            private set { instance = value; }
        }
        private NhaXuatBanDAO() { }

        public DataTable LoadNXBList()
        {
            string query = "SELECT * FROM VW_NXB_List";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            return data;
        }
        public void AddNXB(NhaXuatBan nxb)
        {
            string query = "SP_Add_New_NXB @TenNhaXuatBan ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { nxb.TenNhaXuatBan });
        }
        public void DeleteNXB(NhaXuatBan nxb)
        {
            string query = "SP_Delete_NXB @MaNhaXuatBan , @TenNhaXuatBan ";
            DataProvider.Instance.ExecuteQuery(query, new object[] { nxb.MaNhaXuatBan, nxb.TenNhaXuatBan });
        }
        public bool UpdateNXB(NhaXuatBan nxb)
        {
            string query = "SP_Update_NXB @MaNhaXuatBan , @TenNhaXuatBan ";

            int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { nxb.MaNhaXuatBan, nxb.TenNhaXuatBan });

            return result > 0;
        }
        public DataTable FindNhaXuatBan(NhaXuatBan nxb)
        {
            object manhaxuatban = nxb.MaNhaXuatBan;
            object tennhaxuatban = nxb.TenNhaXuatBan;

            if (nxb.MaNhaXuatBan == 0)
            {
                manhaxuatban = DBNull.Value;
            }
            if (nxb.TenNhaXuatBan == "")
            {
                tennhaxuatban = DBNull.Value;
            }

            string query = "SP_Find_NXB @MaNhaXuatBan , @TenNhaXuatBan ";
            DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { manhaxuatban, tennhaxuatban });
            return data;
        }
        public DataTable TotalPublishers()
        {
            string query = "SELECT * FROM FN_Total_Publishers()";
            DataTable total = DataProvider.Instance.ExecuteQuery(query);
            return total;
        }
    }
}
