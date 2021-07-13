namespace Book_Management_System
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Password.Location = new System.Drawing.Point(138, 253);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(156, 36);
            this.lbl_Password.TabIndex = 19;
            this.lbl_Password.Text = "Password";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Font = new System.Drawing.Font("Modern No. 20", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_Username.Location = new System.Drawing.Point(138, 171);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(164, 36);
            this.lbl_Username.TabIndex = 18;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Login
            // 
            this.lbl_Login.AutoSize = true;
            this.lbl_Login.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_Login.Font = new System.Drawing.Font("Franklin Gothic Demi", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_Login.Location = new System.Drawing.Point(295, 27);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(266, 50);
            this.lbl_Login.TabIndex = 17;
            this.lbl_Login.Text = "LOGIN FORM";
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(433, 253);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Password.MaxLength = 12;
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(339, 40);
            this.tb_Password.TabIndex = 3;
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(433, 171);
            this.tb_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Username.MaxLength = 12;
            this.tb_Username.Multiline = true;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(339, 40);
            this.tb_Username.TabIndex = 3;
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Font = new System.Drawing.Font("Franklin Gothic Book", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btn_Submit.Location = new System.Drawing.Point(325, 355);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(141, 50);
            this.btn_Submit.TabIndex = 5;
            this.btn_Submit.Text = "SUBMIT";
            this.btn_Submit.UseVisualStyleBackColor = false;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(851, 476);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Login;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.Button btn_Submit;
    }
}

