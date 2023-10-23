namespace PersonelTracking_1_UI
{
    partial class PersonelTracking
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gb_Employee_Register_TcNo_tb = new TextBox();
            gb_Employee_Register_Name_tb = new TextBox();
            gb_Employee_Register_Surname_tb = new TextBox();
            gb_Employee_Register_MotherName_tb = new TextBox();
            gb_Employee_Register_FatherName_tb = new TextBox();
            gb_Employee_Register_BirthDate_tb = new TextBox();
            gb_Employee_Register_MartialStatus_cb = new ComboBox();
            gb_Employee_Register_BirthCity_cb = new ComboBox();
            gb_Employee_Register_LivingCity_cb = new ComboBox();
            gb_Employee_Register = new GroupBox();
            gb_Employee_Register_Employees_ListBox = new ListBox();
            gb_Employee_Register_Selection_btn = new Button();
            gb_Employee_Register_Delete_btn = new Button();
            gb_Employee_Register_Update_btn = new Button();
            gb_Employee_Register_Register_btn = new Button();
            gb_Employee_Register_LivingCity_lbl = new Label();
            gb_Employee_Register_BirthCity_lbl = new Label();
            gb_Employee_Register_MartialStatus_lbl = new Label();
            gb_Employee_Register.SuspendLayout();
            SuspendLayout();
            // 
            // gb_Employee_Register_TcNo_tb
            // 
            gb_Employee_Register_TcNo_tb.Location = new Point(15, 31);
            gb_Employee_Register_TcNo_tb.Name = "gb_Employee_Register_TcNo_tb";
            gb_Employee_Register_TcNo_tb.PlaceholderText = "Tc NO";
            gb_Employee_Register_TcNo_tb.Size = new Size(267, 23);
            gb_Employee_Register_TcNo_tb.TabIndex = 0;
            // 
            // gb_Employee_Register_Name_tb
            // 
            gb_Employee_Register_Name_tb.Location = new Point(15, 60);
            gb_Employee_Register_Name_tb.Name = "gb_Employee_Register_Name_tb";
            gb_Employee_Register_Name_tb.PlaceholderText = "First  Name";
            gb_Employee_Register_Name_tb.Size = new Size(267, 23);
            gb_Employee_Register_Name_tb.TabIndex = 0;
            // 
            // gb_Employee_Register_Surname_tb
            // 
            gb_Employee_Register_Surname_tb.Location = new Point(15, 89);
            gb_Employee_Register_Surname_tb.Name = "gb_Employee_Register_Surname_tb";
            gb_Employee_Register_Surname_tb.PlaceholderText = "Last Name";
            gb_Employee_Register_Surname_tb.Size = new Size(267, 23);
            gb_Employee_Register_Surname_tb.TabIndex = 0;
            // 
            // gb_Employee_Register_MotherName_tb
            // 
            gb_Employee_Register_MotherName_tb.Location = new Point(15, 118);
            gb_Employee_Register_MotherName_tb.Name = "gb_Employee_Register_MotherName_tb";
            gb_Employee_Register_MotherName_tb.PlaceholderText = "Mother Name";
            gb_Employee_Register_MotherName_tb.Size = new Size(267, 23);
            gb_Employee_Register_MotherName_tb.TabIndex = 0;
            // 
            // gb_Employee_Register_FatherName_tb
            // 
            gb_Employee_Register_FatherName_tb.Location = new Point(15, 147);
            gb_Employee_Register_FatherName_tb.Name = "gb_Employee_Register_FatherName_tb";
            gb_Employee_Register_FatherName_tb.PlaceholderText = "Father Name";
            gb_Employee_Register_FatherName_tb.Size = new Size(267, 23);
            gb_Employee_Register_FatherName_tb.TabIndex = 0;
            // 
            // gb_Employee_Register_BirthDate_tb
            // 
            gb_Employee_Register_BirthDate_tb.Location = new Point(15, 176);
            gb_Employee_Register_BirthDate_tb.Name = "gb_Employee_Register_BirthDate_tb";
            gb_Employee_Register_BirthDate_tb.PlaceholderText = "Birth Date";
            gb_Employee_Register_BirthDate_tb.Size = new Size(267, 23);
            gb_Employee_Register_BirthDate_tb.TabIndex = 0;
            // 
            // gb_Employee_Register_MartialStatus_cb
            // 
            gb_Employee_Register_MartialStatus_cb.FormattingEnabled = true;
            gb_Employee_Register_MartialStatus_cb.Location = new Point(108, 207);
            gb_Employee_Register_MartialStatus_cb.Name = "gb_Employee_Register_MartialStatus_cb";
            gb_Employee_Register_MartialStatus_cb.Size = new Size(174, 23);
            gb_Employee_Register_MartialStatus_cb.TabIndex = 1;
            gb_Employee_Register_MartialStatus_cb.TabStop = false;
            gb_Employee_Register_MartialStatus_cb.Text = "Medeni Durmununu Seçiniz";
            // 
            // gb_Employee_Register_BirthCity_cb
            // 
            gb_Employee_Register_BirthCity_cb.FormattingEnabled = true;
            gb_Employee_Register_BirthCity_cb.Location = new Point(108, 236);
            gb_Employee_Register_BirthCity_cb.Name = "gb_Employee_Register_BirthCity_cb";
            gb_Employee_Register_BirthCity_cb.Size = new Size(174, 23);
            gb_Employee_Register_BirthCity_cb.TabIndex = 1;
            gb_Employee_Register_BirthCity_cb.Text = "Doğduğu Şehiri Seçiniz";
            // 
            // gb_Employee_Register_LivingCity_cb
            // 
            gb_Employee_Register_LivingCity_cb.FormattingEnabled = true;
            gb_Employee_Register_LivingCity_cb.Location = new Point(108, 265);
            gb_Employee_Register_LivingCity_cb.Name = "gb_Employee_Register_LivingCity_cb";
            gb_Employee_Register_LivingCity_cb.Size = new Size(174, 23);
            gb_Employee_Register_LivingCity_cb.TabIndex = 1;
            gb_Employee_Register_LivingCity_cb.Text = "Yaşadığı Şehiri Seçiniz";
            // 
            // gb_Employee_Register
            // 
            gb_Employee_Register.Controls.Add(gb_Employee_Register_Employees_ListBox);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_Selection_btn);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_Delete_btn);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_Update_btn);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_Register_btn);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_LivingCity_lbl);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_BirthCity_lbl);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_MartialStatus_lbl);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_MartialStatus_cb);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_LivingCity_cb);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_TcNo_tb);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_BirthCity_cb);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_Name_tb);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_Surname_tb);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_BirthDate_tb);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_MotherName_tb);
            gb_Employee_Register.Controls.Add(gb_Employee_Register_FatherName_tb);
            gb_Employee_Register.Location = new Point(12, 12);
            gb_Employee_Register.Name = "gb_Employee_Register";
            gb_Employee_Register.Size = new Size(742, 325);
            gb_Employee_Register.TabIndex = 2;
            gb_Employee_Register.TabStop = false;
            gb_Employee_Register.Text = "Employe Register";
            // 
            // gb_Employee_Register_Employees_ListBox
            // 
            gb_Employee_Register_Employees_ListBox.FormattingEnabled = true;
            gb_Employee_Register_Employees_ListBox.ItemHeight = 15;
            gb_Employee_Register_Employees_ListBox.Location = new Point(307, 40);
            gb_Employee_Register_Employees_ListBox.Name = "gb_Employee_Register_Employees_ListBox";
            gb_Employee_Register_Employees_ListBox.Size = new Size(417, 244);
            gb_Employee_Register_Employees_ListBox.TabIndex = 4;
            // 
            // gb_Employee_Register_Selection_btn
            // 
            gb_Employee_Register_Selection_btn.Location = new Point(307, 296);
            gb_Employee_Register_Selection_btn.Name = "gb_Employee_Register_Selection_btn";
            gb_Employee_Register_Selection_btn.Size = new Size(417, 23);
            gb_Employee_Register_Selection_btn.TabIndex = 3;
            gb_Employee_Register_Selection_btn.Text = "Listede Seçili Çalışanın Bilgilerini Getir";
            gb_Employee_Register_Selection_btn.UseVisualStyleBackColor = true;
            gb_Employee_Register_Selection_btn.Click += gb_Employee_Register_Selection_btn_Click;
            // 
            // gb_Employee_Register_Delete_btn
            // 
            gb_Employee_Register_Delete_btn.Enabled = false;
            gb_Employee_Register_Delete_btn.Location = new Point(214, 296);
            gb_Employee_Register_Delete_btn.Name = "gb_Employee_Register_Delete_btn";
            gb_Employee_Register_Delete_btn.Size = new Size(68, 23);
            gb_Employee_Register_Delete_btn.TabIndex = 3;
            gb_Employee_Register_Delete_btn.Text = "Sil";
            gb_Employee_Register_Delete_btn.UseVisualStyleBackColor = true;
            gb_Employee_Register_Delete_btn.Click += gb_Employee_Register_Delete_btn_Click;
            // 
            // gb_Employee_Register_Update_btn
            // 
            gb_Employee_Register_Update_btn.Enabled = false;
            gb_Employee_Register_Update_btn.Location = new Point(108, 296);
            gb_Employee_Register_Update_btn.Name = "gb_Employee_Register_Update_btn";
            gb_Employee_Register_Update_btn.Size = new Size(68, 23);
            gb_Employee_Register_Update_btn.TabIndex = 3;
            gb_Employee_Register_Update_btn.Text = "Güncelle";
            gb_Employee_Register_Update_btn.UseVisualStyleBackColor = true;
            gb_Employee_Register_Update_btn.Click += gb_Employee_Register_Update_btn_Click;
            // 
            // gb_Employee_Register_Register_btn
            // 
            gb_Employee_Register_Register_btn.Location = new Point(6, 296);
            gb_Employee_Register_Register_btn.Name = "gb_Employee_Register_Register_btn";
            gb_Employee_Register_Register_btn.Size = new Size(68, 23);
            gb_Employee_Register_Register_btn.TabIndex = 3;
            gb_Employee_Register_Register_btn.Text = "Ekle";
            gb_Employee_Register_Register_btn.UseVisualStyleBackColor = true;
            gb_Employee_Register_Register_btn.Click += gb_Employee_Register_Register_btn_Click;
            // 
            // gb_Employee_Register_LivingCity_lbl
            // 
            gb_Employee_Register_LivingCity_lbl.AutoSize = true;
            gb_Employee_Register_LivingCity_lbl.Location = new Point(16, 265);
            gb_Employee_Register_LivingCity_lbl.Name = "gb_Employee_Register_LivingCity_lbl";
            gb_Employee_Register_LivingCity_lbl.Size = new Size(82, 15);
            gb_Employee_Register_LivingCity_lbl.TabIndex = 2;
            gb_Employee_Register_LivingCity_lbl.Text = "Yaşadığı Şehir:";
            // 
            // gb_Employee_Register_BirthCity_lbl
            // 
            gb_Employee_Register_BirthCity_lbl.AutoSize = true;
            gb_Employee_Register_BirthCity_lbl.Location = new Point(16, 239);
            gb_Employee_Register_BirthCity_lbl.Name = "gb_Employee_Register_BirthCity_lbl";
            gb_Employee_Register_BirthCity_lbl.Size = new Size(89, 15);
            gb_Employee_Register_BirthCity_lbl.TabIndex = 2;
            gb_Employee_Register_BirthCity_lbl.Text = "Doğduğu Şehir:";
            // 
            // gb_Employee_Register_MartialStatus_lbl
            // 
            gb_Employee_Register_MartialStatus_lbl.AutoSize = true;
            gb_Employee_Register_MartialStatus_lbl.Location = new Point(15, 210);
            gb_Employee_Register_MartialStatus_lbl.Name = "gb_Employee_Register_MartialStatus_lbl";
            gb_Employee_Register_MartialStatus_lbl.Size = new Size(90, 15);
            gb_Employee_Register_MartialStatus_lbl.TabIndex = 2;
            gb_Employee_Register_MartialStatus_lbl.Text = "Medeni Durum:";
            // 
            // PersonelTracking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1204, 981);
            Controls.Add(gb_Employee_Register);
            Name = "PersonelTracking";
            Text = "Kayıt Ekranı";
            Load += PersonelTracking_Load;
            gb_Employee_Register.ResumeLayout(false);
            gb_Employee_Register.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox gb_Employee_Register_TcNo_tb;
        private TextBox gb_Employee_Register_Name_tb;
        private TextBox gb_Employee_Register_Surname_tb;
        private TextBox gb_Employee_Register_MotherName_tb;
        private TextBox gb_Employee_Register_FatherName_tb;
        private TextBox gb_Employee_Register_BirthDate_tb;
        private ComboBox gb_Employee_Register_MartialStatus_cb;
        private ComboBox gb_Employee_Register_BirthCity_cb;
        private ComboBox gb_Employee_Register_LivingCity_cb;
        private GroupBox gb_Employee_Register;
        private Label gb_Employee_Register_LivingCity_lbl;
        private Label gb_Employee_Register_BirthCity_lbl;
        private Label gb_Employee_Register_MartialStatus_lbl;
        private Button gb_Employee_Register_Delete_btn;
        private Button gb_Employee_Register_Update_btn;
        private Button gb_Employee_Register_Register_btn;
        private ListBox gb_Employee_Register_Employees_ListBox;
        private Button gb_Employee_Register_Selection_btn;
    }
}