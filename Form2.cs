using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace btbuoi3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ListViewItem it = new ListViewItem(txtLastName.Text);
            it.SubItems.Add(txtFirstName.Text);
            it.SubItems.Add(txtPhone.Text);
            lv1.Items.Add(it);
        }

        private void lv1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0)
            {
                ListViewItem lt = lv1.SelectedItems[0];
                string lastname = lt.SubItems[0].Text;
                string firtname = lt.SubItems[1].Text;
                string phone = lt.SubItems[2].Text;
                
                txtLastName.Text = lastname;
                txtFirstName.Text = firtname;
                txtPhone.Text = phone;

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(lv1.SelectedItems.Count > 0)
            {
                ListViewItem item = lv1.SelectedItems[0];
                item.SubItems[0].Text = txtLastName.Text;
                item.SubItems[1].Text= txtFirstName.Text;
                item.SubItems[2].Text= txtPhone.Text;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lv1.SelectedItems.Count > 0)
            {
                lv1.Items.RemoveAt(lv1.SelectedItems[0].Index);
            }
            else
            {
                MessageBox.Show("Ban chua chon dong de xoa !");
            }
        }
    }
}
