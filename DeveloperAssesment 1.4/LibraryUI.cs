using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeveloperAssesment_1._4
{
    public partial class LibraryTestForm : Form
    {
        private Controller Control = new Controller();
        public LibraryTestForm()
        {
            InitializeComponent();
            //detecting when the index on the tabs have changed in the UI
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
        }

        private void tabControl1_SelectedIndexChanged(Object sender, EventArgs e)
        {
            //checks what value that is switched to, 2 = book list, 3 = user list, in this case we dont care about the rest of them
            if (tabControl1.SelectedIndex == 2)
            {
                //clear the booklist to get a fresh new one, this could also be done when switching away, so there isnt alot of data in a UI element that isnt being show.
                dgv_BookList.Rows.Clear();
                //gets the list of string[] from the control.getBookList() and cycle through them
                foreach (string[] row in Control.getBookList())
                {
                    //add each row to the gridview
                    dgv_BookList.Rows.Add(row);
                }
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                //clear the userlist to get a fresh new one, this could also be done when switching away, so there isnt alot of data in a UI element that isnt being show.
                dgv_UserList.Rows.Clear();
                //gets the list of string[] from the control.getUserList() and cycle through them
                foreach (string[] row in Control.getUserList())
                {
                    //add each row to the gridview
                    dgv_UserList.Rows.Add(row);
                }
            }
        }

        private void btn_RegBook_Click(object sender, EventArgs e)
        {
            Control.RegBook(tb_Title.Text, tb_Author.Text, int.Parse(tb_ISBN.Text));
        }

        private void btn_RegUser_Click(object sender, EventArgs e)
        {
            Control.RegUser(tb_Name.Text, int.Parse(tb_LibUserNum.Text));
        }

        private void btn_Rent_Click(object sender, EventArgs e)
        {
            Control.RentBook(int.Parse(tb_RentalLibNum.Text), int.Parse(tb_RentalISBN.Text));
        }

        private void btn_ReturnBook_Click(object sender, EventArgs e)
        {
            Control.ReturnBook(int.Parse(tb_RentalISBN.Text), int.Parse(tb_RentalLibNum.Text));
        }
    }
}
