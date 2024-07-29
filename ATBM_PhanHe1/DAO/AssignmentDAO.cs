﻿using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class AssignmentDAO
    {
        private static AssignmentDAO instance;
        public static AssignmentDAO Instance
        {
            get { if (instance == null) instance = new AssignmentDAO(); return AssignmentDAO.instance; }
            private set { AssignmentDAO.instance = value; }
        }
        private AssignmentDAO() { }
        public List<AssignmentDTO> GetDepartmentHeadAssignmentList()
        {
            List<AssignmentDTO> list = new List<AssignmentDTO>();
            string query = "select pc.*, ns.HOTEN, hp.TENHP, ct.TENCT, dv.TENDV from admin.tb_phancong pc, admin.tb_nhansu ns, admin.tb_donvi dv, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where pc.MAGV = ns.MANV and pc.MAHP = hp.MAHP and pc.MACT = ct.MACT AND hp.MADV = dv.MADV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO course = new AssignmentDTO(row);
                list.Add(course);
            }
            return list;
        }
        public List<AssignmentDTO> GetLecturerAssignmentList()
        {
            List<AssignmentDTO> list = new List<AssignmentDTO>();
            string query = "select pc.*, dv.TENDV, ns.HOTEN, hp.TENHP, ct.TENCT from admin.uv_gvxemphancong pc, admin.uv_nvxemthongtin ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct, admin.tb_donvi dv where pc.MAGV = ns.MANV and pc.MAHP = hp.MAHP and pc.MACT = ct.MACT and hp.MADV = dv.MADV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO course = new AssignmentDTO(row);
                list.Add(course);
            }
            return list;
        }
        public List<AssignmentDTO> GetRegistrarAssignmentList()
        {
            List<AssignmentDTO> list = new List<AssignmentDTO>();
            string query = "select pc.*, dv.TENDV, ns.HOTEN, hp.TENHP, ct.TENCT from admin.tb_phancong pc, admin.uv_xemgiangvien ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct, admin.tb_donvi dv where pc.MAGV = ns.MANV and pc.MAHP = hp.MAHP and pc.MACT = ct.MACT and hp.MADV = dv.MADV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO course = new AssignmentDTO(row);
                list.Add(course);
            }
            return list;
        }
        public List<AssignmentDTO> GetUnitChiefAssignmentList()
        {
            List<AssignmentDTO> list = new List<AssignmentDTO>();
            string query = "select pc.*, hp.TENHP, ct.TENCT, dv.TENDV from admin.uv_tdvxemphancong2 pc, admin.tb_hocphan hp, admin.tb_donvi dv, admin.tb_chuongtrinh ct where pc.MAHP = hp.MAHP and pc.MACT = ct.MACT and hp.MADV = dv.MADV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO course = new AssignmentDTO(row);
                list.Add(course);
            }
            return list;
        }
        public List<AssignmentDTO> DepartmentHeadSearchAssignment(int semester,int year,string programName)
        {
            List<AssignmentDTO> result = new List<AssignmentDTO>();
            string query = "select pc.*, ns.HOTEN, hp.TENHP, ct.TENCT, dv.TENDV from admin.tb_phancong pc, admin.tb_nhansu ns, admin.tb_donvi dv, admin.tb_hocphan hp, admin.tb_chuongtrinh ct where pc.MAGV = ns.MANV and pc.MAHP = hp.MAHP and pc.MACT = ct.MACT AND hp.MADV = dv.MADV";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO assignment = new AssignmentDTO(row);
                result.Add(assignment);
            }
            return result;
        }
        public List<AssignmentDTO> LecturerSearchAssignment(int semester, int year, string programName)
        {
            List<AssignmentDTO> result = new List<AssignmentDTO>();
            string query = "select pc.*, dv.TENDV, ns.HOTEN, hp.TENHP, ct.TENCT from admin.uv_gvxemphancong pc, admin.uv_nvxemthongtin ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct, admin.tb_donvi dv where pc.MAGV = ns.MANV and pc.MAHP = hp.MAHP and pc.MACT = ct.MACT and hp.MADV = dv.MADV";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO assignment = new AssignmentDTO(row);
                result.Add(assignment);
            }
            return result;
        }
        public List<AssignmentDTO> RegistrarSearchAssignment(int semester, int year, string programName)
        {
            List<AssignmentDTO> result = new List<AssignmentDTO>();
            string query = "select pc.*, dv.TENDV, ns.HOTEN, hp.TENHP, ct.TENCT from admin.tb_phancong pc, admin.uv_xemgiangvien ns, admin.tb_hocphan hp, admin.tb_chuongtrinh ct, admin.tb_donvi dv where pc.MAGV = ns.MANV and pc.MAHP = hp.MAHP and pc.MACT = ct.MACT and hp.MADV = dv.MADV";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO assignment = new AssignmentDTO(row);
                result.Add(assignment);
            }
            return result;
        }
        public List<AssignmentDTO> UnitChiefSearchAssignment(int semester, int year, string programName)
        {
            List<AssignmentDTO> result = new List<AssignmentDTO>();
            string query = "select pc.*, hp.TENHP, ct.TENCT, dv.TENDV from admin.uv_tdvxemphancong2 pc, admin.tb_hocphan hp, admin.tb_donvi dv, admin.tb_chuongtrinh ct where pc.MAHP = hp.MAHP and pc.MACT = ct.MACT and hp.MADV = dv.MADV";
            if (semester > 0)
                query += string.Format(" and HK = {0}", semester);
            if (year > 0)
                query += string.Format(" and NAM = {0}", year);
            if (programName != "null")
                query += string.Format(" and TENCT = '{0}'", programName);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AssignmentDTO assignment = new AssignmentDTO(row);
                result.Add(assignment);
            }
            return result;
        }
        public bool UpdateAssignment(string courseID, string semester, string year, string programID, string lecturerID, string newLecturerID)
        {
            string query = string.Format("update admin.tb_phancong set MAGV = '{0}' where MAHP = '{1}' and HK = {2} and NAM = {3} and MACT = '{4}' and MAGV = '{5}'", newLecturerID, courseID, semester, year, programID, lecturerID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool UnitChiefUpdateAssignment(string courseID, string semester, string year, string programID, string lecturerID, string newLecturerID)
        {
            string query = string.Format("update admin.uv_tdvxemphancong set MAGV = '{0}' where MAHP = '{1}' and HK = {2} and NAM = {3} and MACT = '{4}' and MAGV = '{5}'", newLecturerID, courseID, semester, year, programID, lecturerID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool DepartmentHeadUpdateAssignment(string courseID, string semester, string year, string programID, string lecturerID, string newLecturerID)
        {
            string query = string.Format("update admin.uv_tkxemphancong set MAGV = '{0}' where MAHP = '{1}' and HK = {2} and NAM = {3} and MACT = '{4}' and MAGV = '{5}'", newLecturerID, courseID, semester, year, programID, lecturerID);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public void UnitChiefDeleteAssignment(string courseID, int semester, int year, string programID, string lecturerID)
        {
            string query = string.Format("begin delete from admin.uv_tdvxemphancong where MAHP = '{0}' and HK = {1} and NAM = {2} and MACT = '{3}' and MAGV = '{4}'; end;", courseID, semester, year, programID, lecturerID);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void DepartmentHeadDeleteAssignment(string courseID, int semester, int year, string programID, string lecturerID)
        {
            string query = string.Format("begin delete from admin.uv_tkxemphancong where MAHP = '{0}' and HK = {1} and NAM = {2} and MACT = '{3}' and MAGV = '{4}'; end;", courseID, semester, year, programID, lecturerID);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void UnitChiefAddAssignment(string courseID, string semester, int year, string programID, string lecturerID)
        {
            string query = string.Format("insert into admin.uv_tdvxemphancong values('{0}', '{1}', {2}, {3}, '{4}')", lecturerID, courseID, semester, year, programID);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public void DepartmentHeadAddAssignment(string courseID, string semester, int year, string programID, string lecturerID)
        {
            string query = string.Format("insert into admin.uv_tkxemphancong values('{0}', '{1}', {2}, {3}, '{4}')", lecturerID, courseID, semester, year, programID);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
    }
}
