namespace Book_Management_System
{
    partial class frm_View_Book_List
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_View_Book_List));
            this.dgv_Book_Details = new System.Windows.Forms.DataGridView();
            this.lbl_View_Book_List = new System.Windows.Forms.Label();
            this.btn_Add_New_Book = new System.Windows.Forms.Button();
            this.dgv_Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Book_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Publish_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Book_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.book_Management_SystemDataSet = new Book_Management_System.Book_Management_SystemDataSet();
            this.bookDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.book_DetailsTableAdapter = new Book_Management_System.Book_Management_SystemDataSetTableAdapters.Book_DetailsTableAdapter();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book_Details)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Management_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Book_Details
            // 
            this.dgv_Book_Details.AllowUserToAddRows = false;
            this.dgv_Book_Details.AllowUserToDeleteRows = false;
            this.dgv_Book_Details.AutoGenerateColumns = false;
            this.dgv_Book_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Book_Details.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Book_Details.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Book_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Book_Details.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Book_ID,
            this.dgv_Book_Name,
            this.dgv_Publish_Date,
            this.dgv_Book_Price,
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.publishDateDataGridViewTextBoxColumn,
            this.bookPriceDataGridViewTextBoxColumn});
            this.dgv_Book_Details.DataSource = this.bookDetailsBindingSource;
            this.dgv_Book_Details.Location = new System.Drawing.Point(12, 100);
            this.dgv_Book_Details.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_Book_Details.Name = "dgv_Book_Details";
            this.dgv_Book_Details.ReadOnly = true;
            this.dgv_Book_Details.RowTemplate.Height = 28;
            this.dgv_Book_Details.Size = new System.Drawing.Size(1058, 338);
            this.dgv_Book_Details.TabIndex = 1;
            // 
            // lbl_View_Book_List
            // 
            this.lbl_View_Book_List.AutoSize = true;
            this.lbl_View_Book_List.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lbl_View_Book_List.Font = new System.Drawing.Font("Franklin Gothic Demi", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_View_Book_List.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_View_Book_List.Location = new System.Drawing.Point(399, 22);
            this.lbl_View_Book_List.Name = "lbl_View_Book_List";
            this.lbl_View_Book_List.Size = new System.Drawing.Size(298, 50);
            this.lbl_View_Book_List.TabIndex = 18;
            this.lbl_View_Book_List.Text = "View Book List";
            // 
            // btn_Add_New_Book
            // 
            this.btn_Add_New_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Add_New_Book.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Add_New_Book.Enabled = false;
            this.btn_Add_New_Book.Font = new System.Drawing.Font("Javanese Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_New_Book.ForeColor = System.Drawing.Color.DarkGreen;
            this.btn_Add_New_Book.Location = new System.Drawing.Point(438, 470);
            this.btn_Add_New_Book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Add_New_Book.Name = "btn_Add_New_Book";
            this.btn_Add_New_Book.Size = new System.Drawing.Size(228, 51);
            this.btn_Add_New_Book.TabIndex = 19;
            this.btn_Add_New_Book.Text = "Add New Book";
            this.btn_Add_New_Book.UseVisualStyleBackColor = false;
            // 
            // dgv_Book_ID
            // 
            this.dgv_Book_ID.DataPropertyName = "Book_ID";
            this.dgv_Book_ID.HeaderText = "Book_ID";
            this.dgv_Book_ID.Name = "dgv_Book_ID";
            this.dgv_Book_ID.ReadOnly = true;
            // 
            // dgv_Book_Name
            // 
            this.dgv_Book_Name.DataPropertyName = "Book_Name";
            this.dgv_Book_Name.HeaderText = "Book_Name";
            this.dgv_Book_Name.Name = "dgv_Book_Name";
            this.dgv_Book_Name.ReadOnly = true;
            // 
            // dgv_Publish_Date
            // 
            this.dgv_Publish_Date.DataPropertyName = "Publish_Date";
            this.dgv_Publish_Date.HeaderText = "Publish_Date";
            this.dgv_Publish_Date.Name = "dgv_Publish_Date";
            this.dgv_Publish_Date.ReadOnly = true;
            // 
            // dgv_Book_Price
            // 
            this.dgv_Book_Price.DataPropertyName = "Book_Price";
            this.dgv_Book_Price.HeaderText = "Book_Price";
            this.dgv_Book_Price.Name = "dgv_Book_Price";
            this.dgv_Book_Price.ReadOnly = true;
            // 
            // book_Management_SystemDataSet
            // 
            this.book_Management_SystemDataSet.DataSetName = "Book_Management_SystemDataSet";
            this.book_Management_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDetailsBindingSource
            // 
            this.bookDetailsBindingSource.DataMember = "Book_Details";
            this.bookDetailsBindingSource.DataSource = this.book_Management_SystemDataSet;
            // 
            // book_DetailsTableAdapter
            // 
            this.book_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "Book_Name";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publishDateDataGridViewTextBoxColumn
            // 
            this.publishDateDataGridViewTextBoxColumn.DataPropertyName = "Publish_Date";
            this.publishDateDataGridViewTextBoxColumn.HeaderText = "Publish_Date";
            this.publishDateDataGridViewTextBoxColumn.Name = "publishDateDataGridViewTextBoxColumn";
            this.publishDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookPriceDataGridViewTextBoxColumn
            // 
            this.bookPriceDataGridViewTextBoxColumn.DataPropertyName = "Book_Price";
            this.bookPriceDataGridViewTextBoxColumn.HeaderText = "Book_Price";
            this.bookPriceDataGridViewTextBoxColumn.Name = "bookPriceDataGridViewTextBoxColumn";
            this.bookPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frm_View_Book_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(1082, 544);
            this.Controls.Add(this.btn_Add_New_Book);
            this.Controls.Add(this.lbl_View_Book_List);
            this.Controls.Add(this.dgv_Book_Details);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_View_Book_List";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Book List";
            this.Load += new System.EventHandler(this.frm_View_Book_List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Book_Details)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.book_Management_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Book_Details;
        private System.Windows.Forms.Label lbl_View_Book_List;
        private System.Windows.Forms.Button btn_Add_New_Book;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Book_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Publish_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Book_Price;
        private Book_Management_SystemDataSet book_Management_SystemDataSet;
        private System.Windows.Forms.BindingSource bookDetailsBindingSource;
        private Book_Management_SystemDataSetTableAdapters.Book_DetailsTableAdapter book_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookPriceDataGridViewTextBoxColumn;
    }
}