using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;

namespace SwissTransportUI
{
    public partial class MainForm : Form
    {
        ITransport t = new Transport();
        public MainForm()
        {
            InitializeComponent();
        }

        //Objekte 
        ListBox listBxSearchFrom = new ListBox();
        ListBox listBxSearchTo = new ListBox();
        ListBox listBxSearch = new ListBox();

        private bool lastSearch = false;



        //Actions
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
        
        private void txtBxFrom_Enter(object sender, EventArgs e)
        {
            create_Searchbar(this.txtBxFrom, true);
        }
        private void txtBxFrom_Leave(object sender, EventArgs e)
        {

        }
        private void txtBxFrom_TextChanged(object sender, EventArgs e)
        {
            searchFromTo(this.txtBxFrom);
        }

        private void txtBxTo_Enter(object sender, EventArgs e)
        {
            create_Searchbar(this.txtBxTo, true);
        }
        private void txtBxTo_Leave(object sender, EventArgs e)
        {
            
        }
        private void txtBxTo_TextChanged(object sender, EventArgs e)
        {
            searchFromTo(this.txtBxTo);
        }

        //Custom Actions
        private void selectSearchFrom(object? sender, EventArgs e)
        {
            if (listBxSearch.Text == "") { }
            else txtBxFrom.Text = listBxSearch.Text;
        }
        private void selectSearchTo(object? sender, EventArgs e)
        {
            if (listBxSearch.Text == "") { }
            else txtBxTo.Text = listBxSearch.Text;
        }

        //Functions
        private void searchFromTo(Control sender)
        {
            if (sender.Text != "")
            {
                listBxSearch.Items.Clear();
                listBxSearch.BringToFront();
                listBxSearch.Visible = true;

                var stations = t.GetStations(sender.Text);
                foreach (var item in stations.StationList)
                {
                    listBxSearchFrom.Items.Add(item.Name);
                }
            }
            else if (sender.Text == "")
            {
                listBxSearch.SendToBack();
                listBxSearch.Visible = false;
            }
        }
        private void create_Searchbar(Control sender, bool mission)
        {
            if (sender == txtBxFrom)
            {
                listBxSearch.Location = new System.Drawing.Point(632, 54);
                listBxSearch.SelectedIndexChanged += new System.EventHandler(selectSearchTo);
            }
            else if (sender == txtBxTo) 
            {
                listBxSearchFrom.Location = new System.Drawing.Point(88, 54);
                listBxSearch.SelectedIndexChanged += new System.EventHandler(selectSearchFrom);
            }

            if (mission)
            {
                listBxSearch.ItemHeight = 10;
                listBxSearch.Items.AddRange(new object[] { });
                listBxSearch.Size = new System.Drawing.Size(347, 247);
                listBxSearch.TabIndex = 99;
                listBxSearch.TabStop = false;
                panelCenter.Controls.Add(listBxSearch);
                listBxSearch.SendToBack();
                listBxSearch.Visible = false;
            }
            else if (!mission)
            {
                panelCenter.Controls.Remove(listBxSearchFrom);
                listBxSearchFrom.Visible = false;
            }
        }
    }
}
