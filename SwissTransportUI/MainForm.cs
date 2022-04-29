using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwissTransport.Core;
using SwissTransport.Models;
using Microsoft.Web.WebView2.Core;

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
            grayBoxTester();
        }
        private void btnShare_Click(object sender, EventArgs e)
        {
            setUpShare();
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
        private void closeSearch(object sender, EventArgs e)
        {
            create_Searchbar(this, false);
        }
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

        //Error Prints
        private void noResultBoard()
        {
            dataGridViewBoard.Rows.Clear();
            dataGridViewBoard.Rows.Add("404", "--:--", "Not a Station");
        }
        private void noResultTimetable()
        {
            dataGridViewTime.Rows.Clear();
            dataGridViewTime.Rows.Add("404", "####", "Not a", "Station");
        }


        //Functions
        private void searchFromTo(Control sender)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        private void grayBoxTester()
        {
            try
            {
                //Filter From -> Board
                if (txtBxFrom.Text != "")
                {
                    Stations testFrom = t.GetStations(txtBxFrom.Text);
                    var noResultFrom = testFrom.StationList.FirstOrDefault();

                    if (noResultFrom == null || noResultFrom.Name == null) noResultBoard();
                    else
                    {
                        setUpBoard();
                    }
                }

                //Filter From & To -> Timetable
                if (txtBxFrom.Text != "" && txtBxTo.Text != "")
                {
                    Stations testFrom = t.GetStations(txtBxFrom.Text);
                    Stations testTo = t.GetStations(txtBxTo.Text);
                    var noResultFrom = testFrom.StationList.FirstOrDefault();
                    var noResultTo = testTo.StationList.FirstOrDefault();

                    if (noResultFrom == null || noResultFrom.Name == null || noResultTo == null || noResultTo.Name == null) noResultTimetable();
                    else
                    {
                        setUpTimetable();
                        setUpMap();
                    }
                }

                //Anything else
                //not wotking with only one letter (l -> Luzern)
                //more testing 
                else
                {
                    noResultBoard();
                    noResultTimetable();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void setUpBoard()
        {
            try
            {
                var stationBoard = t.GetStationBoard(txtBxFrom.Text, txtBxFrom.Text);
                dataGridViewBoard.Rows.Clear();

                foreach (StationBoard departures in stationBoard.Entries)
                {
                    DateTime date = DateTime.Parse(departures.Stop.Departure.TimeOfDay.ToString(), System.Globalization.CultureInfo.CurrentCulture);
                    string t = date.ToString("HH:mm");

                    dataGridViewBoard.Rows.Add(departures.Category + " " + departures.Number, t, departures.To);
                }
                if (dataGridViewBoard.Rows.Count == 0) noResultBoard();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setUpTimetable()
        {
            try
            {
                if (checkDateFilter.Checked == true)
                {
                    MessageBox.Show("Timetable DatePicker");
                }
                else
                {
                    var stationBoard = t.GetStationBoard(txtBxFrom.Text, txtBxTo.Text);
                    var test3 = t.GetStations(txtBxFrom.Text);

                    var connections = t.GetConnections(txtBxFrom.Text, txtBxTo.Text);
                    dataGridViewTime.Rows.Clear();

                    foreach(Connection result in connections.ConnectionList)
                    {
                        DateTime dateduration = DateTime.Parse(result.From.Departure.ToString(), System.Globalization.CultureInfo.CurrentCulture);
                        string dep = dateduration.ToString("HH:mm");

                        DateTime date = DateTime.Parse(result.To.Arrival.ToString(), System.Globalization.CultureInfo.CurrentCulture);
                        string arr = date.ToString("HH:mm");

                        string timestring = result.Duration.ToString();
                        var split = timestring.Split('d', ':');

                        string hour = Convert.ToString(split[1]);
                        string mins = Convert.ToString(split[2]);
                        string duration = "";

                        if (hour != "0" || hour != "00") duration += hour + "h ";
                        duration += mins + "min";

                        dataGridViewTime.Rows.Add(dep, result.From.Station.Name, arr, result.To.Station.Name, duration);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setUpMap()
        {
            try
            {
                string map = "https://www.google.com/maps/dir/";

                string from = txtBxFrom.Text;
                string to = txtBxTo.Text;

                var spaceToPlusFrom = from.Split(' ');
                var spaceToPlusTo = to.Split(' ');

                from = spaceToPlusFrom[0] + "+" + spaceToPlusFrom[1];
                to = spaceToPlusTo[0] + "+" + spaceToPlusTo[1];
                map += from + "/" + to;

                Uri finalUri = new Uri(map);
                webViewMap.Source = finalUri;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void setUpShare()
        {
            try
            {
                string mail = "mailto:?subject=Swiss%20Transport%20Connection&body=";

                string text = "My%20Connection:%20";
                foreach (DataGridViewRow row in dataGridViewTime.SelectedRows)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        text += "%20";
                        text += row.Cells[i].FormattedValue.ToString();
                    }
                }

                mail += text;
                string finalmail = mail;

                Uri finalUri = new Uri(finalmail);
                webViewMap.Source = finalUri;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
