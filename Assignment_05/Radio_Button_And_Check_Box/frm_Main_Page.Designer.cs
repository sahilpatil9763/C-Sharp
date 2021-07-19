
namespace Radio_Button_And_Check_Box
{
    partial class frm_Main_Page
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_Student_Information = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.lbl_Language = new System.Windows.Forms.Label();
            this.cb_C_Sharp = new System.Windows.Forms.CheckBox();
            this.cb_C = new System.Windows.Forms.CheckBox();
            this.cb_Python = new System.Windows.Forms.CheckBox();
            this.btn_View = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Student_Information
            // 
            this.lbl_Student_Information.AutoSize = true;
            this.lbl_Student_Information.BackColor = System.Drawing.Color.White;
            this.lbl_Student_Information.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Student_Information.Font = new System.Drawing.Font("Microsoft YaHei", 20F, System.Drawing.FontStyle.Bold);
            this.lbl_Student_Information.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Student_Information.Location = new System.Drawing.Point(128, 18);
            this.lbl_Student_Information.Name = "lbl_Student_Information";
            this.lbl_Student_Information.Size = new System.Drawing.Size(456, 47);
            this.lbl_Student_Information.TabIndex = 1;
            this.lbl_Student_Information.Text = "STUDENT INFORMATION";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(117, 112);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(100, 29);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "NAME :";
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.tb_Name.Location = new System.Drawing.Point(294, 112);
            this.tb_Name.MaxLength = 50;
            this.tb_Name.Multiline = true;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(285, 29);
            this.tb_Name.TabIndex = 1;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_Exit.ForeColor = System.Drawing.Color.Brown;
            this.btn_Exit.Location = new System.Drawing.Point(650, 0);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(92, 39);
            this.btn_Exit.TabIndex = 10;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(117, 170);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(111, 29);
            this.lbl_Course.TabIndex = 6;
            this.lbl_Course.Text = "Course :";
            // 
            // cmb_Course
            // 
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BSc CS",
            "MSc CS",
            "MCS"});
            this.cmb_Course.Location = new System.Drawing.Point(294, 177);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(285, 24);
            this.cmb_Course.TabIndex = 2;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(117, 237);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(114, 29);
            this.lbl_Gender.TabIndex = 8;
            this.lbl_Gender.Text = "Gender :";
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.rb_Male.Location = new System.Drawing.Point(299, 235);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(84, 30);
            this.rb_Male.TabIndex = 4;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.rb_Female.Location = new System.Drawing.Point(433, 235);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(112, 30);
            this.rb_Female.TabIndex = 5;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // lbl_Language
            // 
            this.lbl_Language.AutoSize = true;
            this.lbl_Language.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Language.Location = new System.Drawing.Point(117, 296);
            this.lbl_Language.Name = "lbl_Language";
            this.lbl_Language.Size = new System.Drawing.Size(142, 29);
            this.lbl_Language.TabIndex = 11;
            this.lbl_Language.Text = "Language :";
            // 
            // cb_C_Sharp
            // 
            this.cb_C_Sharp.AutoSize = true;
            this.cb_C_Sharp.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.cb_C_Sharp.Location = new System.Drawing.Point(294, 304);
            this.cb_C_Sharp.Name = "cb_C_Sharp";
            this.cb_C_Sharp.Size = new System.Drawing.Size(64, 30);
            this.cb_C_Sharp.TabIndex = 6;
            this.cb_C_Sharp.Text = "C#";
            this.cb_C_Sharp.UseVisualStyleBackColor = true;
            // 
            // cb_C
            // 
            this.cb_C.AutoSize = true;
            this.cb_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.cb_C.Location = new System.Drawing.Point(421, 304);
            this.cb_C.Name = "cb_C";
            this.cb_C.Size = new System.Drawing.Size(51, 30);
            this.cb_C.TabIndex = 7;
            this.cb_C.Text = "C";
            this.cb_C.UseVisualStyleBackColor = true;
            // 
            // cb_Python
            // 
            this.cb_Python.AutoSize = true;
            this.cb_Python.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.cb_Python.Location = new System.Drawing.Point(534, 304);
            this.cb_Python.Name = "cb_Python";
            this.cb_Python.Size = new System.Drawing.Size(108, 30);
            this.cb_Python.TabIndex = 8;
            this.cb_Python.Text = "Python";
            this.cb_Python.UseVisualStyleBackColor = true;
            // 
            // btn_View
            // 
            this.btn_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_View.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.btn_View.ForeColor = System.Drawing.Color.Brown;
            this.btn_View.Location = new System.Drawing.Point(294, 382);
            this.btn_View.Name = "btn_View";
            this.btn_View.Size = new System.Drawing.Size(125, 39);
            this.btn_View.TabIndex = 9;
            this.btn_View.Text = "VIEW";
            this.btn_View.UseVisualStyleBackColor = false;
            this.btn_View.Click += new System.EventHandler(this.btn_View_Click);
            // 
            // frm_Main_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.btn_View);
            this.Controls.Add(this.cb_Python);
            this.Controls.Add(this.cb_C);
            this.Controls.Add(this.cb_C_Sharp);
            this.Controls.Add(this.lbl_Language);
            this.Controls.Add(this.rb_Female);
            this.Controls.Add(this.rb_Male);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Student_Information);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Main_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_Student_Information;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.Label lbl_Language;
        private System.Windows.Forms.CheckBox cb_C_Sharp;
        private System.Windows.Forms.CheckBox cb_C;
        private System.Windows.Forms.CheckBox cb_Python;
        private System.Windows.Forms.Button btn_View;
    }
}

