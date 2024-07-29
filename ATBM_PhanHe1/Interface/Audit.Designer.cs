﻿namespace ATBM_PhanHe1.Interface
{
    partial class Audit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pic_refresh_U = new PictureBox();
            lab_dstk = new Label();
            dtGrid_user = new DataGridView();
            btn_search_user = new Button();
            btn_ds = new Button();
            btn_dstk = new Button();
            pn_qlur = new Panel();
            btn_qlur = new Button();
            pic_logout = new PictureBox();
            btn_qlq = new Button();
            pn_qlq = new Panel();
            pic_khtn = new PictureBox();
            pn_main = new Panel();
            cbB_table = new ComboBox();
            panel5 = new Panel();
            tb_search_user = new TextBox();
            pic_search_user = new PictureBox();
            pn_dstk = new Panel();
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_user).BeginInit();
            pn_qlur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logout).BeginInit();
            pn_qlq.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_khtn).BeginInit();
            pn_main.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_user).BeginInit();
            pn_dstk.SuspendLayout();
            SuspendLayout();
            // 
            // pic_refresh_U
            // 
            pic_refresh_U.Image = Properties.Resources.refresh_buttons;
            pic_refresh_U.Location = new Point(561, 76);
            pic_refresh_U.Name = "pic_refresh_U";
            pic_refresh_U.Size = new Size(49, 39);
            pic_refresh_U.SizeMode = PictureBoxSizeMode.Zoom;
            pic_refresh_U.TabIndex = 24;
            pic_refresh_U.TabStop = false;
            pic_refresh_U.Click += pic_refresh_U_Click;
            // 
            // lab_dstk
            // 
            lab_dstk.AutoSize = true;
            lab_dstk.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            lab_dstk.Location = new Point(314, 15);
            lab_dstk.Name = "lab_dstk";
            lab_dstk.Size = new Size(110, 31);
            lab_dstk.TabIndex = 1;
            lab_dstk.Text = "NHẬT KÝ";
            lab_dstk.TextAlign = ContentAlignment.TopCenter;
            // 
            // dtGrid_user
            // 
            dtGrid_user.BackgroundColor = Color.WhiteSmoke;
            dtGrid_user.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGrid_user.Location = new Point(31, 128);
            dtGrid_user.Name = "dtGrid_user";
            dtGrid_user.RowHeadersWidth = 51;
            dtGrid_user.Size = new Size(677, 389);
            dtGrid_user.TabIndex = 23;
            // 
            // btn_search_user
            // 
            btn_search_user.BackColor = Color.White;
            btn_search_user.BackgroundImage = Properties.Resources.button_round2;
            btn_search_user.FlatAppearance.BorderSize = 0;
            btn_search_user.FlatStyle = FlatStyle.Flat;
            btn_search_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_search_user.ForeColor = SystemColors.Window;
            btn_search_user.Location = new Point(616, 76);
            btn_search_user.Name = "btn_search_user";
            btn_search_user.Size = new Size(91, 37);
            btn_search_user.TabIndex = 21;
            btn_search_user.Text = "Tìm kiếm";
            btn_search_user.UseVisualStyleBackColor = false;
            btn_search_user.Click += btn_search_user_Click;
            // 
            // btn_ds
            // 
            btn_ds.BackColor = Color.FromArgb(42, 107, 167);
            btn_ds.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_ds.FlatAppearance.BorderSize = 0;
            btn_ds.FlatStyle = FlatStyle.Flat;
            btn_ds.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_ds.ForeColor = Color.Transparent;
            btn_ds.Location = new Point(-1, 265);
            btn_ds.Name = "btn_ds";
            btn_ds.Size = new Size(218, 56);
            btn_ds.TabIndex = 22;
            btn_ds.Text = "Danh sách tài khoản";
            btn_ds.UseVisualStyleBackColor = false;
            btn_ds.Click += btn_dstk_Click;
            // 
            // btn_dstk
            // 
            btn_dstk.BackColor = Color.FromArgb(177, 213, 246);
            btn_dstk.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_dstk.FlatAppearance.BorderSize = 0;
            btn_dstk.FlatStyle = FlatStyle.Flat;
            btn_dstk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dstk.ForeColor = Color.Black;
            btn_dstk.Location = new Point(0, 3);
            btn_dstk.Name = "btn_dstk";
            btn_dstk.Size = new Size(218, 56);
            btn_dstk.TabIndex = 5;
            btn_dstk.Text = "Xem nhật ký";
            btn_dstk.UseVisualStyleBackColor = false;
            // 
            // pn_qlur
            // 
            pn_qlur.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlur.Controls.Add(btn_qlur);
            pn_qlur.Location = new Point(-1, 327);
            pn_qlur.Name = "pn_qlur";
            pn_qlur.Size = new Size(219, 76);
            pn_qlur.TabIndex = 19;
            // 
            // btn_qlur
            // 
            btn_qlur.BackColor = Color.FromArgb(42, 107, 167);
            btn_qlur.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_qlur.FlatAppearance.BorderSize = 0;
            btn_qlur.FlatStyle = FlatStyle.Flat;
            btn_qlur.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_qlur.ForeColor = Color.Transparent;
            btn_qlur.Location = new Point(1, 11);
            btn_qlur.Name = "btn_qlur";
            btn_qlur.Size = new Size(218, 56);
            btn_qlur.TabIndex = 6;
            btn_qlur.Text = "Quản lý User/Role";
            btn_qlur.UseVisualStyleBackColor = false;
            btn_qlur.Click += btn_qlur_Click;
            // 
            // pic_logout
            // 
            pic_logout.Image = Properties.Resources.Exit;
            pic_logout.Location = new Point(901, 5);
            pic_logout.Name = "pic_logout";
            pic_logout.Size = new Size(43, 36);
            pic_logout.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logout.TabIndex = 20;
            pic_logout.TabStop = false;
            pic_logout.Click += pic_logout_Click;
            // 
            // btn_qlq
            // 
            btn_qlq.BackColor = Color.FromArgb(42, 107, 167);
            btn_qlq.FlatAppearance.BorderColor = Color.FromArgb(177, 213, 246);
            btn_qlq.FlatAppearance.BorderSize = 0;
            btn_qlq.FlatStyle = FlatStyle.Flat;
            btn_qlq.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_qlq.ForeColor = Color.Transparent;
            btn_qlq.Location = new Point(1, 11);
            btn_qlq.Name = "btn_qlq";
            btn_qlq.Size = new Size(218, 56);
            btn_qlq.TabIndex = 7;
            btn_qlq.Text = "Quản lý quyền";
            btn_qlq.UseVisualStyleBackColor = false;
            btn_qlq.Click += btn_qlq_Click;
            // 
            // pn_qlq
            // 
            pn_qlq.BackColor = Color.FromArgb(42, 107, 167);
            pn_qlq.Controls.Add(btn_qlq);
            pn_qlq.Location = new Point(-1, 404);
            pn_qlq.Name = "pn_qlq";
            pn_qlq.Size = new Size(219, 76);
            pn_qlq.TabIndex = 21;
            // 
            // pic_khtn
            // 
            pic_khtn.Image = Properties.Resources.logo2;
            pic_khtn.Location = new Point(26, 24);
            pic_khtn.Name = "pic_khtn";
            pic_khtn.Size = new Size(170, 155);
            pic_khtn.SizeMode = PictureBoxSizeMode.Zoom;
            pic_khtn.TabIndex = 17;
            pic_khtn.TabStop = false;
            // 
            // pn_main
            // 
            pn_main.BackColor = SystemColors.Window;
            pn_main.Controls.Add(cbB_table);
            pn_main.Controls.Add(pic_refresh_U);
            pn_main.Controls.Add(dtGrid_user);
            pn_main.Controls.Add(panel5);
            pn_main.Controls.Add(btn_search_user);
            pn_main.Controls.Add(lab_dstk);
            pn_main.Location = new Point(218, 49);
            pn_main.Name = "pn_main";
            pn_main.Size = new Size(739, 536);
            pn_main.TabIndex = 16;
            // 
            // cbB_table
            // 
            cbB_table.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_table.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_table.FormattingEnabled = true;
            cbB_table.Location = new Point(339, 77);
            cbB_table.Name = "cbB_table";
            cbB_table.Size = new Size(187, 36);
            cbB_table.TabIndex = 89;
            // 
            // panel5
            // 
            panel5.BackColor = Color.WhiteSmoke;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(tb_search_user);
            panel5.Controls.Add(pic_search_user);
            panel5.Location = new Point(31, 77);
            panel5.Name = "panel5";
            panel5.Size = new Size(247, 38);
            panel5.TabIndex = 22;
            // 
            // tb_search_user
            // 
            tb_search_user.BackColor = Color.WhiteSmoke;
            tb_search_user.BorderStyle = BorderStyle.None;
            tb_search_user.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_search_user.Location = new Point(53, 5);
            tb_search_user.Name = "tb_search_user";
            tb_search_user.PlaceholderText = "Nhập mã định danh...";
            tb_search_user.Size = new Size(189, 23);
            tb_search_user.TabIndex = 1;
            // 
            // pic_search_user
            // 
            pic_search_user.Image = Properties.Resources.Search1;
            pic_search_user.Location = new Point(3, 3);
            pic_search_user.Name = "pic_search_user";
            pic_search_user.Size = new Size(43, 29);
            pic_search_user.SizeMode = PictureBoxSizeMode.Zoom;
            pic_search_user.TabIndex = 0;
            pic_search_user.TabStop = false;
            // 
            // pn_dstk
            // 
            pn_dstk.BackColor = Color.FromArgb(177, 213, 246);
            pn_dstk.Controls.Add(btn_dstk);
            pn_dstk.Location = new Point(-1, 485);
            pn_dstk.Name = "pn_dstk";
            pn_dstk.Size = new Size(219, 65);
            pn_dstk.TabIndex = 23;
            // 
            // Audit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(42, 107, 167);
            ClientSize = new Size(957, 589);
            ControlBox = false;
            Controls.Add(pn_dstk);
            Controls.Add(btn_ds);
            Controls.Add(pn_qlur);
            Controls.Add(pic_logout);
            Controls.Add(pn_qlq);
            Controls.Add(pic_khtn);
            Controls.Add(pn_main);
            FormBorderStyle = FormBorderStyle.None;
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Audit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Audit";
            ((System.ComponentModel.ISupportInitialize)pic_refresh_U).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtGrid_user).EndInit();
            pn_qlur.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_logout).EndInit();
            pn_qlq.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_khtn).EndInit();
            pn_main.ResumeLayout(false);
            pn_main.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pic_search_user).EndInit();
            pn_dstk.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pic_refresh_U;
        private Label lab_dstk;
        private DataGridView dtGrid_user;
        private Button btn_search_user;
        private Button btn_ds;
        private Button btn_dstk;
        private Panel pn_qlur;
        private Button btn_qlur;
        private PictureBox pic_logout;
        private Button btn_qlq;
        private Panel pn_qlq;
        private PictureBox pic_khtn;
        private Panel pn_main;
        private Panel pn_dstk;
        private Panel panel5;
        private TextBox tb_search_user;
        private PictureBox pic_search_user;
        private ComboBox cbB_table;
    }
}