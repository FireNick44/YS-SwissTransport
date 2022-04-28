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
            SearchFrom(this.txtBxFrom);
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
          //if(lastSearch)
                SearchTo(this.txtBxTo);
        }

        //Custom Actions
        private void selectSearchFrom(object? sender, EventArgs e)
        {
            if (listBxSearchFrom.Text == "") { }
            else txtBxFrom.Text = listBxSearchFrom.Text;
        }

        private void selectSearchTo(object? sender, EventArgs e)
        {
            if (listBxSearchTo.Text == "") { }
            else txtBxTo.Text = listBxSearchTo.Text;

        }
        //Functions
        private void SearchFrom(Control sender)
        {
            if (sender.Text != "")
            {
                listBxSearchFrom.Items.Clear();
                listBxSearchFrom.BringToFront();
                listBxSearchFrom.Visible = true;

                var stations = t.GetStations(sender.Text);
                foreach (var item in stations.StationList)
                {
                    listBxSearchFrom.Items.Add(item.Name);
                }
            }
            else if (sender.Text == "")
            {
                listBxSearchFrom.SendToBack();
                listBxSearchFrom.Visible = false;
            }
        }
        private void SearchTo(Control sender)
        {
            if (txtBxTo.Text != "")
            {
                listBxSearchTo.Items.Clear();
                listBxSearchTo.BringToFront();
                listBxSearchTo.Visible = true;

                var stations = t.GetStations(txtBxTo.Text);
                foreach (var item in stations.StationList)
                {
                    listBxSearchTo.Items.Add(item.Name);
                }
            }
            else if (txtBxTo.Text == "")
            {
                listBxSearchTo.SendToBack();
                listBxSearchTo.Visible = false;
            }
        }
        private void create_Searchbar(Control sender, bool mission)
        {
            if (sender == txtBxFrom)
            {
                if (mission)
                {
                    listBxSearchFrom.ItemHeight = 10;
                    listBxSearchFrom.Items.AddRange(new object[] { });
                    listBxSearchFrom.Location = new System.Drawing.Point(88, 54);
                    listBxSearchFrom.Size = new System.Drawing.Size(347, 247);
                    listBxSearchFrom.TabIndex = 99;
                    listBxSearchFrom.TabStop = false;
                    listBxSearchFrom.SelectedIndexChanged += new System.EventHandler(selectSearchFrom);
                    panelCenter.Controls.Add(listBxSearchFrom);
                    listBxSearchFrom.SendToBack();
                    listBxSearchFrom.Visible = false;
                }
                else if (!mission)
                {
                    panelCenter.Controls.Remove(listBxSearchFrom);
                    listBxSearchFrom.Visible = false;
                }
            }
            else if(sender == txtBxTo)
            {
                if (mission)
                {
                    listBxSearchTo.ItemHeight = 10;
                    listBxSearchTo.Items.AddRange(new object[] { });
                    listBxSearchTo.Size = new System.Drawing.Size(347, 247);
                    listBxSearchTo.Location = new System.Drawing.Point(632, 54);
                    listBxSearchTo.TabIndex = 99;
                    listBxSearchTo.TabStop = false;
                    listBxSearchTo.SelectedIndexChanged += new System.EventHandler(selectSearchTo);
                    panelCenter.Controls.Add(listBxSearchTo);
                    listBxSearchTo.SendToBack();
                    listBxSearchTo.Visible = false;
                }
                else if (!mission)
                {
                    panelCenter.Controls.Remove(listBxSearchTo);
                    listBxSearchTo.Visible = false;
                }
            }
        }
    }
}
