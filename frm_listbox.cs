using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratice
{
    public partial class frm_listbox : Form
    {
        public frm_listbox()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_CapNhat_Click(object sender, EventArgs e)
        {
            if (txtHoten.Text != "")
            {
                if (radioLopA.Checked == true)
                {
                    list_LopA.Items.Add(txtHoten.Text);
                }
                if (radioLopB.Checked == true)
                {
                    list_lopB.Items.Add(txtHoten.Text);
                }
                if (radioLopA.Checked == false && radioLopB.Checked == false)
                {
                    MessageBox.Show("Vui long chon lop");
                    radioLopA.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Vui long nhap ho ten");
                txtHoten.Focus();
            }

        }

        private void bt_Lammoi_Click(object sender, EventArgs e)
        {
            txtHoten.Text = "";
            list_LopA.Items.Clear();
            list_lopB.Items.Clear();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban co muon thoat", "Thong Bao", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btchhuyenb_Click(object sender, EventArgs e)
        {
            foreach (string item in list_LopA.SelectedItems)
            {
                list_lopB.Items.Add(item);
            }
            try
            {
                foreach (string item in list_LopA.SelectedItems)
                {
                    list_LopA.Items.RemoveAt(list_LopA.SelectedIndex);
                }
            }
            catch
            {

                return;
            }
        }

        private void btchuyenallb_Click(object sender, EventArgs e)
        {
            foreach (string item in list_LopA.Items)
            {
                list_lopB.Items.Add(item);
            }
            list_LopA.Items.Clear();
        }

        private void btchuyena_Click(object sender, EventArgs e)
        {
            foreach (string item in list_lopB.SelectedItems)
            {
                list_LopA.Items.Add(item);
            }
            try
            {
                foreach (string item in list_lopB.SelectedItems)
                {
                    list_LopA.Items.RemoveAt(list_lopB.SelectedIndex);
                }
            }
            catch
            {

                return;
            }

        }

        private void btchuyenalla_Click(object sender, EventArgs e)
        {
            foreach (string item in list_lopB.Items)
            {
                list_LopA.Items.Add(item);
            }
            list_lopB.Items.Clear();
        }
    }
}
