﻿namespace ATBM_PhanHe1.PhanHe2
{
    partial class Add_Register
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
            lb_namestudent = new Label();
            lb_idstudent = new Label();
            cbB_nameCourses = new ComboBox();
            cbB_idcourses = new ComboBox();
            btn_Add = new Button();
            cbB_semester = new ComboBox();
            btn_Back = new Button();
            lb_year = new Label();
            lb_nameprogram = new Label();
            lb_idprogram = new Label();
            lb_semester = new Label();
            lb_name = new Label();
            lb_id = new Label();
            lb_Info = new Label();
            tb_year = new TextBox();
            tb_programId = new TextBox();
            tb_programName = new TextBox();
            cbB_studentId = new ComboBox();
            cbB_studentName = new ComboBox();
            SuspendLayout();
            // 
            // lb_namestudent
            // 
            lb_namestudent.AutoSize = true;
            lb_namestudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_namestudent.Location = new Point(40, 157);
            lb_namestudent.Name = "lb_namestudent";
            lb_namestudent.Size = new Size(122, 28);
            lb_namestudent.TabIndex = 184;
            lb_namestudent.Text = "Tên sinh viên";
            // 
            // lb_idstudent
            // 
            lb_idstudent.AutoSize = true;
            lb_idstudent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idstudent.Location = new Point(40, 91);
            lb_idstudent.Name = "lb_idstudent";
            lb_idstudent.Size = new Size(121, 28);
            lb_idstudent.TabIndex = 183;
            lb_idstudent.Text = "Mã sinh viên";
            // 
            // cbB_nameCourses
            // 
            cbB_nameCourses.DropDownHeight = 150;
            cbB_nameCourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_nameCourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_nameCourses.FormattingEnabled = true;
            cbB_nameCourses.IntegralHeight = false;
            cbB_nameCourses.Location = new Point(626, 293);
            cbB_nameCourses.Name = "cbB_nameCourses";
            cbB_nameCourses.Size = new Size(229, 36);
            cbB_nameCourses.TabIndex = 182;
            cbB_nameCourses.SelectedIndexChanged += cbB_nameCourses_SelectedIndexChanged;
            // 
            // cbB_idcourses
            // 
            cbB_idcourses.DropDownHeight = 150;
            cbB_idcourses.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_idcourses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_idcourses.FormattingEnabled = true;
            cbB_idcourses.IntegralHeight = false;
            cbB_idcourses.Location = new Point(626, 225);
            cbB_idcourses.Name = "cbB_idcourses";
            cbB_idcourses.Size = new Size(229, 36);
            cbB_idcourses.TabIndex = 181;
            cbB_idcourses.SelectedIndexChanged += cbB_idcourses_SelectedIndexChanged;
            // 
            // btn_Add
            // 
            btn_Add.BackColor = Color.White;
            btn_Add.BackgroundImage = Properties.Resources.button_round2;
            btn_Add.FlatAppearance.BorderSize = 0;
            btn_Add.FlatStyle = FlatStyle.Flat;
            btn_Add.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Add.ForeColor = SystemColors.Window;
            btn_Add.Location = new Point(464, 372);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(91, 37);
            btn_Add.TabIndex = 178;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = false;
            btn_Add.Click += btn_Add_Click;
            // 
            // cbB_semester
            // 
            cbB_semester.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_semester.FormattingEnabled = true;
            cbB_semester.Location = new Point(189, 225);
            cbB_semester.Name = "cbB_semester";
            cbB_semester.Size = new Size(229, 36);
            cbB_semester.TabIndex = 176;
            // 
            // btn_Back
            // 
            btn_Back.BackColor = Color.White;
            btn_Back.BackgroundImage = Properties.Resources.button_round2;
            btn_Back.FlatAppearance.BorderSize = 0;
            btn_Back.FlatStyle = FlatStyle.Flat;
            btn_Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btn_Back.ForeColor = SystemColors.Window;
            btn_Back.Location = new Point(339, 372);
            btn_Back.Name = "btn_Back";
            btn_Back.Size = new Size(91, 37);
            btn_Back.TabIndex = 175;
            btn_Back.Text = "Quay lại";
            btn_Back.UseVisualStyleBackColor = false;
            btn_Back.Click += btn_Back_Click;
            // 
            // lb_year
            // 
            lb_year.AutoSize = true;
            lb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_year.Location = new Point(40, 296);
            lb_year.Name = "lb_year";
            lb_year.Size = new Size(54, 28);
            lb_year.TabIndex = 174;
            lb_year.Text = "Năm";
            // 
            // lb_nameprogram
            // 
            lb_nameprogram.AutoSize = true;
            lb_nameprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_nameprogram.Location = new Point(453, 157);
            lb_nameprogram.Name = "lb_nameprogram";
            lb_nameprogram.Size = new Size(159, 28);
            lb_nameprogram.TabIndex = 173;
            lb_nameprogram.Text = "Tên chương trình";
            // 
            // lb_idprogram
            // 
            lb_idprogram.AutoSize = true;
            lb_idprogram.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_idprogram.Location = new Point(453, 91);
            lb_idprogram.Name = "lb_idprogram";
            lb_idprogram.Size = new Size(158, 28);
            lb_idprogram.TabIndex = 172;
            lb_idprogram.Text = "Mã chương trình";
            // 
            // lb_semester
            // 
            lb_semester.AutoSize = true;
            lb_semester.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_semester.Location = new Point(40, 225);
            lb_semester.Name = "lb_semester";
            lb_semester.Size = new Size(72, 28);
            lb_semester.TabIndex = 171;
            lb_semester.Text = "Học kỳ";
            // 
            // lb_name
            // 
            lb_name.AutoSize = true;
            lb_name.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_name.Location = new Point(453, 296);
            lb_name.Name = "lb_name";
            lb_name.Size = new Size(127, 28);
            lb_name.TabIndex = 170;
            lb_name.Text = "Tên học phần";
            // 
            // lb_id
            // 
            lb_id.AutoSize = true;
            lb_id.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_id.Location = new Point(453, 228);
            lb_id.Name = "lb_id";
            lb_id.Size = new Size(126, 28);
            lb_id.TabIndex = 169;
            lb_id.Text = "Mã học phần";
            // 
            // lb_Info
            // 
            lb_Info.AutoSize = true;
            lb_Info.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_Info.Location = new Point(311, 13);
            lb_Info.Name = "lb_Info";
            lb_Info.Size = new Size(263, 31);
            lb_Info.TabIndex = 168;
            lb_Info.Text = "Thêm đăng ký học phần";
            // 
            // tb_year
            // 
            tb_year.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_year.Location = new Point(189, 296);
            tb_year.Name = "tb_year";
            tb_year.Size = new Size(229, 34);
            tb_year.TabIndex = 187;
            tb_year.TabStop = false;
            // 
            // tb_programId
            // 
            tb_programId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_programId.Location = new Point(626, 88);
            tb_programId.Name = "tb_programId";
            tb_programId.ReadOnly = true;
            tb_programId.Size = new Size(229, 34);
            tb_programId.TabIndex = 186;
            tb_programId.TabStop = false;
            // 
            // tb_programName
            // 
            tb_programName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_programName.Location = new Point(626, 155);
            tb_programName.Name = "tb_programName";
            tb_programName.ReadOnly = true;
            tb_programName.Size = new Size(229, 34);
            tb_programName.TabIndex = 186;
            tb_programName.TabStop = false;
            // 
            // cbB_studentId
            // 
            cbB_studentId.DropDownHeight = 150;
            cbB_studentId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_studentId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_studentId.FormattingEnabled = true;
            cbB_studentId.IntegralHeight = false;
            cbB_studentId.Location = new Point(189, 88);
            cbB_studentId.Name = "cbB_studentId";
            cbB_studentId.Size = new Size(229, 36);
            cbB_studentId.TabIndex = 176;
            cbB_studentId.SelectedIndexChanged += cbB_studentId_SelectedIndexChanged;
            // 
            // cbB_studentName
            // 
            cbB_studentName.DropDownHeight = 150;
            cbB_studentName.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB_studentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbB_studentName.FormattingEnabled = true;
            cbB_studentName.IntegralHeight = false;
            cbB_studentName.Location = new Point(189, 154);
            cbB_studentName.Name = "cbB_studentName";
            cbB_studentName.Size = new Size(229, 36);
            cbB_studentName.TabIndex = 176;
            cbB_studentName.SelectedIndexChanged += cbB_studentName_SelectedIndexChanged;
            // 
            // Add_Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(895, 425);
            Controls.Add(tb_year);
            Controls.Add(tb_programName);
            Controls.Add(tb_programId);
            Controls.Add(lb_namestudent);
            Controls.Add(lb_idstudent);
            Controls.Add(cbB_nameCourses);
            Controls.Add(cbB_idcourses);
            Controls.Add(btn_Add);
            Controls.Add(cbB_studentId);
            Controls.Add(cbB_studentName);
            Controls.Add(cbB_semester);
            Controls.Add(btn_Back);
            Controls.Add(lb_year);
            Controls.Add(lb_nameprogram);
            Controls.Add(lb_idprogram);
            Controls.Add(lb_semester);
            Controls.Add(lb_name);
            Controls.Add(lb_id);
            Controls.Add(lb_Info);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Add_Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add_Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_namestudent;
        private Label lb_idstudent;
        private ComboBox cbB_nameCourses;
        private ComboBox cbB_idcourses;
        private Button btn_Add;
        private ComboBox cbB_semester;
        private Button btn_Back;
        private Label lb_year;
        private Label lb_nameprogram;
        private Label lb_idprogram;
        private Label lb_semester;
        private Label lb_name;
        private Label lb_id;
        private Label lb_Info;
        private TextBox tb_year;
        private TextBox tb_programId;
        private TextBox tb_programName;
        private ComboBox cbB_studentId;
        private ComboBox cbB_studentName;
    }
}