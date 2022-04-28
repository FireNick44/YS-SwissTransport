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
using SwissTransport.Models;


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
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            refresh();
        }
        private void txtBxFrom_Enter(object sender, EventArgs e)
        {
            create_Searchbar(this.txtBxFrom, true);
        }
        private void txtBxFrom_TextChanged(object sender, EventArgs e)
        {
            searchFromTo(this.txtBxFrom);
        }

        private void txtBxTo_Enter(object sender, EventArgs e)
        {
            create_Searchbar(this.txtBxTo, true);
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
        private void selectSearch(object? sender, EventArgs e)
        {
            if(listBxSearch.Location.X == 88)
            {
                if (listBxSearch.Text == "") { }
                else txtBxFrom.Text = listBxSearch.Text;
            }
            else if(listBxSearch.Location.X == 632)
            {
                if (listBxSearch.Text == "") { }
                else txtBxTo.Text = listBxSearch.Text;
            }
        }



        //Functions
        private void searchFromTo(Control sender)
        {
            if (sender.Text != "")
            {
                listBxSearch.Items.Clear();
                listBxSearch.BringToFront();
                listBxSearch.Visible = true;

                Stations stations = t.GetStations(sender.Text);
                var noResult = stations.StationList.FirstOrDefault(); //1.Item

                if (noResult == null || noResult.Name == null) listBxSearch.Items.Add("No results"); //NoResult Test
                else if (noResult.Name != null)
                {
                    foreach (var item in stations.StationList)
                    {
                        listBxSearch.Items.Add(item.Name.ToString());
                    }
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
            //if mission is true, create listBxSearch
            if (sender == txtBxFrom)    listBxSearch.Location = new System.Drawing.Point(88, 54);
            else if (sender == txtBxTo) listBxSearch.Location = new System.Drawing.Point(632, 54);

            if (mission)
            {
                listBxSearch.ItemHeight = 10;
                listBxSearch.Items.AddRange(new object[] { });
                listBxSearch.Size = new System.Drawing.Size(347, 247);
                listBxSearch.SelectedIndexChanged += new System.EventHandler(selectSearch);
                listBxSearch.TabIndex = 99;
                listBxSearch.TabStop = false;
                panelCenter.Controls.Add(listBxSearch);
                listBxSearch.SendToBack();
                listBxSearch.Visible = false;
            }
            else if (!mission)
            {
                panelCenter.Controls.Remove(listBxSearch);
                listBxSearch.Visible = false;
            }
        }
        private void refresh()
        {

            if (txtBxFrom.Text == "") noResultBoard();
            else
            {
                var testFrom = t.GetStations(txtBxFrom.Text);
                var noResultFrom = testFrom.StationList.FirstOrDefault();

                if (noResultFrom == null || noResultFrom.Name == null) noResultBoard();
                else
                {
                    string currentLocation;
                    //string fill = "     choose a starting location     ";
                    string fill = "────────────────────────────────────";
                    var stationBoard = t.GetStationBoard(txtBxFrom.Text, txtBxFrom.Text);

                    currentLocation = "(" + stationBoard.Station.Name + ")";
                    if (stationBoard.Station.Name == null) currentLocation = "location (Not a station)";

                    listBxDepBoard.Items.Clear();
                    listBxDepBoard.Items.Add(currentLocation);

                    foreach (StationBoard departure in stationBoard.Entries)
                    {

                        listBxDepBoard.Items.Add(fill);

                        string timeSplit = "";

                        if (departure.Stop.Departure.TimeOfDay.Hours < 10) timeSplit = "0";
                        else if (departure.Stop.Departure.TimeOfDay.Hours == 0) timeSplit = "00";
                        listBxDepBoard.Items.Add(

                            + departure.Stop.Departure.TimeOfDay.Hours
                            + ":"
                            + timeSplit
                            + departure.Stop.Departure.TimeOfDay.Minutes
                            + "  "
                            + departure.To
                            );
                    }
                }
            }


        }

        //Ausgabe
        private void noResultBoard()
        {
            listBxDepBoard.Items.Clear();
            listBxDepBoard.Items.AddRange(new object[]
            {
                "",
                "              No result             ",
                ""
            });
        }
    }
}
