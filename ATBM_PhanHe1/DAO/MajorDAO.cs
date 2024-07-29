﻿using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class MajorDAO
    {
        private static MajorDAO instance;
        public static MajorDAO Instance
        {
            get { if (instance == null) instance = new MajorDAO(); return MajorDAO.instance; }
            private set { MajorDAO.instance = value; }
        }
        private MajorDAO() { }
        public MajorDTO GetMajorByID(string majorID)
        {
            string query = string.Format("select * from admin.tb_nganh where lower(MANGANH) like lower('%{0}%')", majorID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            MajorDTO result = new MajorDTO(data.Rows[0]);
            return result;
        }
        public DataTable GetListMajor()
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM ADMIN.TB_NGANH"));
        }
        public string GetIDMajor(string name_major)
        {
            string query = $"SELECT MANGANH FROM ADMIN.TB_NGANH WHERE TENNGANH = ('{name_major}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { name_major });
            return result.ToString();
        }
    }
}
