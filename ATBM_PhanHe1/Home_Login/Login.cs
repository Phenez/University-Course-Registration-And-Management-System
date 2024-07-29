﻿using ATBM_PhanHe1.DAO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ATBM_PhanHe1.Home_Login
{
    public partial class Login : Form
    {
        public static string User { get; set; }
        public static string Pass { get; set; }

        public Login()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            tB_pass.UseSystemPasswordChar = true;
            pic_hide.Visible = false;
            pic_show.Visible = true;
            tB_name.Text = "";
            tB_pass.Text = "";
        }
        private void Login_button_Click(object sender, EventArgs e)
        {
            User = tB_name.Text.ToString();
            Pass = tB_pass.Text.ToString();
            try
            {
                if (User.ToUpper().StartsWith("NV") || User.ToUpper().StartsWith("SV"))
                {
                    
                    PhanHe2.MainBase mainBase = new PhanHe2.MainBase();
                    this.Hide();
                    mainBase.ShowDialog();
                    this.Show();
                }
                else
                {
                    Interface.Homepage homepage = new Interface.Homepage();
                    this.Hide();
                    homepage.ShowDialog();
                    this.Show();
                }
                Load();
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message, "Lỗi");
            }
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pic_show_Click(object sender, EventArgs e)
        {
            tB_pass.UseSystemPasswordChar = false;
            pic_show.Visible = false;
            pic_hide.Visible = true;
        }

        private void pic_hide_Click(object sender, EventArgs e)
        {
            tB_pass.UseSystemPasswordChar = true;
            pic_hide.Visible = false;
            pic_show.Visible = true;
        }
    }
}
