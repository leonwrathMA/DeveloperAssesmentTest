
namespace DeveloperAssesment_1._4
{
    partial class LibraryTestForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_ReturnBook = new System.Windows.Forms.Button();
            this.btn_Rent = new System.Windows.Forms.Button();
            this.lb_RentalISBN = new System.Windows.Forms.Label();
            this.lb_RentalLibNum = new System.Windows.Forms.Label();
            this.tb_RentalISBN = new System.Windows.Forms.TextBox();
            this.tb_RentalLibNum = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_RegUser = new System.Windows.Forms.Button();
            this.btn_RegBook = new System.Windows.Forms.Button();
            this.lb_LibUserNum = new System.Windows.Forms.Label();
            this.lb_Name = new System.Windows.Forms.Label();
            this.lb_ISBN = new System.Windows.Forms.Label();
            this.lb_Author = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.tb_LibUserNum = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.tb_Author = new System.Windows.Forms.TextBox();
            this.tb_Title = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgv_BookList = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgv_UserList = new System.Windows.Forms.DataGridView();
            this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LibNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookList)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(799, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_ReturnBook);
            this.tabPage1.Controls.Add(this.btn_Rent);
            this.tabPage1.Controls.Add(this.lb_RentalISBN);
            this.tabPage1.Controls.Add(this.lb_RentalLibNum);
            this.tabPage1.Controls.Add(this.tb_RentalISBN);
            this.tabPage1.Controls.Add(this.tb_RentalLibNum);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 423);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Book rental";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_ReturnBook
            // 
            this.btn_ReturnBook.Location = new System.Drawing.Point(304, 16);
            this.btn_ReturnBook.Name = "btn_ReturnBook";
            this.btn_ReturnBook.Size = new System.Drawing.Size(75, 23);
            this.btn_ReturnBook.TabIndex = 5;
            this.btn_ReturnBook.Text = "Return book";
            this.btn_ReturnBook.UseVisualStyleBackColor = true;
            this.btn_ReturnBook.Click += new System.EventHandler(this.btn_ReturnBook_Click);
            // 
            // btn_Rent
            // 
            this.btn_Rent.Location = new System.Drawing.Point(223, 16);
            this.btn_Rent.Name = "btn_Rent";
            this.btn_Rent.Size = new System.Drawing.Size(75, 23);
            this.btn_Rent.TabIndex = 4;
            this.btn_Rent.Text = "Rent book";
            this.btn_Rent.UseVisualStyleBackColor = true;
            this.btn_Rent.Click += new System.EventHandler(this.btn_Rent_Click);
            // 
            // lb_RentalISBN
            // 
            this.lb_RentalISBN.AutoSize = true;
            this.lb_RentalISBN.Location = new System.Drawing.Point(114, 3);
            this.lb_RentalISBN.Name = "lb_RentalISBN";
            this.lb_RentalISBN.Size = new System.Drawing.Size(32, 13);
            this.lb_RentalISBN.TabIndex = 3;
            this.lb_RentalISBN.Text = "ISBN";
            // 
            // lb_RentalLibNum
            // 
            this.lb_RentalLibNum.AutoSize = true;
            this.lb_RentalLibNum.Location = new System.Drawing.Point(8, 3);
            this.lb_RentalLibNum.Name = "lb_RentalLibNum";
            this.lb_RentalLibNum.Size = new System.Drawing.Size(76, 13);
            this.lb_RentalLibNum.TabIndex = 2;
            this.lb_RentalLibNum.Text = "Library number";
            // 
            // tb_RentalISBN
            // 
            this.tb_RentalISBN.Location = new System.Drawing.Point(117, 19);
            this.tb_RentalISBN.Name = "tb_RentalISBN";
            this.tb_RentalISBN.Size = new System.Drawing.Size(100, 20);
            this.tb_RentalISBN.TabIndex = 1;
            // 
            // tb_RentalLibNum
            // 
            this.tb_RentalLibNum.Location = new System.Drawing.Point(11, 19);
            this.tb_RentalLibNum.Name = "tb_RentalLibNum";
            this.tb_RentalLibNum.Size = new System.Drawing.Size(100, 20);
            this.tb_RentalLibNum.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_RegUser);
            this.tabPage2.Controls.Add(this.btn_RegBook);
            this.tabPage2.Controls.Add(this.lb_LibUserNum);
            this.tabPage2.Controls.Add(this.lb_Name);
            this.tabPage2.Controls.Add(this.lb_ISBN);
            this.tabPage2.Controls.Add(this.lb_Author);
            this.tabPage2.Controls.Add(this.lb_Title);
            this.tabPage2.Controls.Add(this.tb_LibUserNum);
            this.tabPage2.Controls.Add(this.tb_Name);
            this.tabPage2.Controls.Add(this.tb_ISBN);
            this.tabPage2.Controls.Add(this.tb_Author);
            this.tabPage2.Controls.Add(this.tb_Title);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 423);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add books/users";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_RegUser
            // 
            this.btn_RegUser.Location = new System.Drawing.Point(342, 55);
            this.btn_RegUser.Name = "btn_RegUser";
            this.btn_RegUser.Size = new System.Drawing.Size(145, 23);
            this.btn_RegUser.TabIndex = 11;
            this.btn_RegUser.Text = "Register user";
            this.btn_RegUser.UseVisualStyleBackColor = true;
            this.btn_RegUser.Click += new System.EventHandler(this.btn_RegUser_Click);
            // 
            // btn_RegBook
            // 
            this.btn_RegBook.Location = new System.Drawing.Point(342, 17);
            this.btn_RegBook.Name = "btn_RegBook";
            this.btn_RegBook.Size = new System.Drawing.Size(145, 23);
            this.btn_RegBook.TabIndex = 10;
            this.btn_RegBook.Text = "Register Book";
            this.btn_RegBook.UseVisualStyleBackColor = true;
            this.btn_RegBook.Click += new System.EventHandler(this.btn_RegBook_Click);
            // 
            // lb_LibUserNum
            // 
            this.lb_LibUserNum.AutoSize = true;
            this.lb_LibUserNum.Location = new System.Drawing.Point(114, 42);
            this.lb_LibUserNum.Name = "lb_LibUserNum";
            this.lb_LibUserNum.Size = new System.Drawing.Size(76, 13);
            this.lb_LibUserNum.TabIndex = 9;
            this.lb_LibUserNum.Text = "Library number";
            // 
            // lb_Name
            // 
            this.lb_Name.AutoSize = true;
            this.lb_Name.Location = new System.Drawing.Point(8, 42);
            this.lb_Name.Name = "lb_Name";
            this.lb_Name.Size = new System.Drawing.Size(35, 13);
            this.lb_Name.TabIndex = 8;
            this.lb_Name.Text = "Name";
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.lb_ISBN.Location = new System.Drawing.Point(223, 3);
            this.lb_ISBN.Name = "lb_ISBN";
            this.lb_ISBN.Size = new System.Drawing.Size(32, 13);
            this.lb_ISBN.TabIndex = 7;
            this.lb_ISBN.Text = "ISBN";
            // 
            // lb_Author
            // 
            this.lb_Author.AutoSize = true;
            this.lb_Author.Location = new System.Drawing.Point(114, 3);
            this.lb_Author.Name = "lb_Author";
            this.lb_Author.Size = new System.Drawing.Size(38, 13);
            this.lb_Author.TabIndex = 6;
            this.lb_Author.Text = "Author";
            // 
            // lb_Title
            // 
            this.lb_Title.AutoSize = true;
            this.lb_Title.Location = new System.Drawing.Point(8, 3);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(27, 13);
            this.lb_Title.TabIndex = 5;
            this.lb_Title.Text = "Title";
            // 
            // tb_LibUserNum
            // 
            this.tb_LibUserNum.Location = new System.Drawing.Point(117, 58);
            this.tb_LibUserNum.Name = "tb_LibUserNum";
            this.tb_LibUserNum.Size = new System.Drawing.Size(100, 20);
            this.tb_LibUserNum.TabIndex = 4;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(11, 58);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 20);
            this.tb_Name.TabIndex = 3;
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Location = new System.Drawing.Point(223, 19);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(100, 20);
            this.tb_ISBN.TabIndex = 2;
            // 
            // tb_Author
            // 
            this.tb_Author.Location = new System.Drawing.Point(117, 19);
            this.tb_Author.Name = "tb_Author";
            this.tb_Author.Size = new System.Drawing.Size(100, 20);
            this.tb_Author.TabIndex = 1;
            // 
            // tb_Title
            // 
            this.tb_Title.Location = new System.Drawing.Point(11, 19);
            this.tb_Title.Name = "tb_Title";
            this.tb_Title.Size = new System.Drawing.Size(100, 20);
            this.tb_Title.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgv_BookList);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 423);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Book list";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgv_BookList
            // 
            this.dgv_BookList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_BookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Author,
            this.ISBN,
            this.RentedBy});
            this.dgv_BookList.Location = new System.Drawing.Point(0, 0);
            this.dgv_BookList.Name = "dgv_BookList";
            this.dgv_BookList.Size = new System.Drawing.Size(788, 423);
            this.dgv_BookList.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // Author
            // 
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // RentedBy
            // 
            this.RentedBy.HeaderText = "Rented by";
            this.RentedBy.Name = "RentedBy";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dgv_UserList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(791, 423);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "User list";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgv_UserList
            // 
            this.dgv_UserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_UserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_UserList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserName,
            this.LibNum});
            this.dgv_UserList.Location = new System.Drawing.Point(0, 0);
            this.dgv_UserList.Name = "dgv_UserList";
            this.dgv_UserList.Size = new System.Drawing.Size(791, 423);
            this.dgv_UserList.TabIndex = 0;
            // 
            // UserName
            // 
            this.UserName.HeaderText = "Name";
            this.UserName.Name = "UserName";
            // 
            // LibNum
            // 
            this.LibNum.HeaderText = "Library number";
            this.LibNum.Name = "LibNum";
            // 
            // LibraryTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "LibraryTestForm";
            this.Text = "Library test";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BookList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_UserList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_ReturnBook;
        private System.Windows.Forms.Button btn_Rent;
        private System.Windows.Forms.Label lb_RentalISBN;
        private System.Windows.Forms.Label lb_RentalLibNum;
        private System.Windows.Forms.TextBox tb_RentalISBN;
        private System.Windows.Forms.TextBox tb_RentalLibNum;
        private System.Windows.Forms.Button btn_RegUser;
        private System.Windows.Forms.Button btn_RegBook;
        private System.Windows.Forms.Label lb_LibUserNum;
        private System.Windows.Forms.Label lb_Name;
        private System.Windows.Forms.Label lb_ISBN;
        private System.Windows.Forms.Label lb_Author;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.TextBox tb_LibUserNum;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.TextBox tb_Author;
        private System.Windows.Forms.TextBox tb_Title;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgv_BookList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentedBy;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dgv_UserList;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LibNum;
    }
}

