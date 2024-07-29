﻿using ATBM_PhanHe1.DAO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_PhanHe1.Role
{
    public partial class Delete_R : Form
    {
        public Delete_R()
        {
            InitializeComponent();
            tb_name.Text = Interface.User_Role.SelectedDeleteName;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            try
            {
                RoleDAO.Instance.Delete_Role(name);
                MessageBox.Show("Xóa thành công", "Thông báo");
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message, "Lỗi");
            }
        }

        private void tb_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
