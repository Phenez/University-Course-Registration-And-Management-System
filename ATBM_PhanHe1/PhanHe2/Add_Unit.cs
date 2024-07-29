﻿using ATBM_PhanHe1.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATBM_PhanHe1.PhanHe2
{
    public partial class Add_Unit : Form
    {
        BindingSource headList = new BindingSource();

        public Add_Unit()
        {
            InitializeComponent();
        }
       
        private void btn_Update_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;
            string name = tb_name.Text;
            try
            {
                UnitDAO.Instance.Add_Unit(id, name);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi");
                return;
            }
            PhanHe2.Success success = new PhanHe2.Success();
            success.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
