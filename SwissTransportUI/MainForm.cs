using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwissTransportUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void checkDateFilter_CheckedChanged(object sender, EventArgs e)
        {
            if (checkDateFilter.Checked) tabsDates.Enabled = true;
            else if (!checkDateFilter.Checked) tabsDates.Enabled = false;
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            string tmpV = txtBxFrom.Text;
            txtBxFrom.Text = txtBxTo.Text;
            txtBxTo.Text = tmpV;
        }

        private void txtBxFrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            create_Searchbar(true);
        }

        private void create_Searchbar(bool mission)
        {
            ListBox txtBxFromSearch = new ListBox();
            
            if(mission)
            {

                txtBxFromSearch.Items.Clear();
                txtBxFromSearch.ItemHeight = 23;
                txtBxFromSearch.Items.AddRange(new object[] { "Test", "Test2", "..." });
                txtBxFromSearch.Location = new System.Drawing.Point(88, 54);
                txtBxFromSearch.Size = new System.Drawing.Size(347, 418);
                txtBxFromSearch.TabIndex = 99;
                txtBxFromSearch.TabStop = false;
                txtBxFromSearch.Focus();

                panelCenter.Controls.Add(txtBxFromSearch);
                txtBxFromSearch.BringToFront();
            }

            else if (!mission)
            {
                panelCenter.Controls.Remove(txtBxFromSearch);
                txtBxFromSearch.Visible = false;
                txtBxFromSearch.SendToBack();
            }
        }

        private void txtBxFrom_Leave(object sender, EventArgs e)
        {
            create_Searchbar(false);
        }
    }
}
