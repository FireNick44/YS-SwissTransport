namespace SwissTransportUI
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelCenter = new System.Windows.Forms.Panel();
            this.btnShare = new System.Windows.Forms.Button();
            this.panelDepartureBoard = new System.Windows.Forms.Panel();
            this.dataGridViewBoard = new System.Windows.Forms.DataGridView();
            this.dataGridViewBoxBoardNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBoxBoardDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBoxBoardTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelBoard = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabsContent = new System.Windows.Forms.TabControl();
            this.tabTim = new System.Windows.Forms.TabPage();
            this.dataGridViewTime = new System.Windows.Forms.DataGridView();
            this.dataGridViewBoxTimeDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBoxTimeFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBoxTimeArr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBoxTimeTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBoxTimeDura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.webViewMap = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panelDateFilter = new System.Windows.Forms.Panel();
            this.checkDateFilter = new System.Windows.Forms.CheckBox();
            this.tabsDates = new System.Windows.Forms.TabControl();
            this.tabDep = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.tabArr = new System.Windows.Forms.TabPage();
            this.panelTo = new System.Windows.Forms.Panel();
            this.txtBxTo = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.panelFrom = new System.Windows.Forms.Panel();
            this.labelFrom = new System.Windows.Forms.Label();
            this.txtBxFrom = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.panelCenter.SuspendLayout();
            this.panelDepartureBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoard)).BeginInit();
            this.tabsContent.SuspendLayout();
            this.tabTim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTime)).BeginInit();
            this.tabMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).BeginInit();
            this.panelDateFilter.SuspendLayout();
            this.tabsDates.SuspendLayout();
            this.tabDep.SuspendLayout();
            this.panelTo.SuspendLayout();
            this.panelFrom.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCenter
            // 
            this.panelCenter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelCenter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCenter.Controls.Add(this.btnShare);
            this.panelCenter.Controls.Add(this.panelDepartureBoard);
            this.panelCenter.Controls.Add(this.btnRefresh);
            this.panelCenter.Controls.Add(this.tabsContent);
            this.panelCenter.Controls.Add(this.panelDateFilter);
            this.panelCenter.Controls.Add(this.panelTo);
            this.panelCenter.Controls.Add(this.panelFrom);
            this.panelCenter.Controls.Add(this.btnSwitch);
            this.panelCenter.Location = new System.Drawing.Point(24, 26);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1582, 800);
            this.panelCenter.TabIndex = 0;
            // 
            // btnShare
            // 
            this.btnShare.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShare.Location = new System.Drawing.Point(1135, 730);
            this.btnShare.Margin = new System.Windows.Forms.Padding(5);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(431, 52);
            this.btnShare.TabIndex = 5;
            this.btnShare.Text = "Mail Share";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            this.btnShare.MouseHover += new System.EventHandler(this.closeSearch);
            // 
            // panelDepartureBoard
            // 
            this.panelDepartureBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDepartureBoard.Controls.Add(this.dataGridViewBoard);
            this.panelDepartureBoard.Controls.Add(this.labelBoard);
            this.panelDepartureBoard.Location = new System.Drawing.Point(1135, 288);
            this.panelDepartureBoard.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelDepartureBoard.Name = "panelDepartureBoard";
            this.panelDepartureBoard.Size = new System.Drawing.Size(431, 436);
            this.panelDepartureBoard.TabIndex = 99;
            // 
            // dataGridViewBoard
            // 
            this.dataGridViewBoard.AllowUserToAddRows = false;
            this.dataGridViewBoard.AllowUserToDeleteRows = false;
            this.dataGridViewBoard.AllowUserToResizeColumns = false;
            this.dataGridViewBoard.AllowUserToResizeRows = false;
            this.dataGridViewBoard.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewBoard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBoard.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewBoard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBoard.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewBoxBoardNr,
            this.dataGridViewBoxBoardDep,
            this.dataGridViewBoxBoardTo});
            this.dataGridViewBoard.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewBoard.Location = new System.Drawing.Point(2, 50);
            this.dataGridViewBoard.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewBoard.Name = "dataGridViewBoard";
            this.dataGridViewBoard.ReadOnly = true;
            this.dataGridViewBoard.RowHeadersVisible = false;
            this.dataGridViewBoard.RowHeadersWidth = 51;
            this.dataGridViewBoard.RowTemplate.Height = 29;
            this.dataGridViewBoard.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBoard.Size = new System.Drawing.Size(425, 384);
            this.dataGridViewBoard.TabIndex = 1;
            // 
            // dataGridViewBoxBoardNr
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxBoardNr.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBoxBoardNr.HeaderText = "Nr";
            this.dataGridViewBoxBoardNr.MinimumWidth = 6;
            this.dataGridViewBoxBoardNr.Name = "dataGridViewBoxBoardNr";
            this.dataGridViewBoxBoardNr.ReadOnly = true;
            this.dataGridViewBoxBoardNr.Width = 60;
            // 
            // dataGridViewBoxBoardDep
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxBoardDep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBoxBoardDep.HeaderText = "Dep";
            this.dataGridViewBoxBoardDep.MinimumWidth = 6;
            this.dataGridViewBoxBoardDep.Name = "dataGridViewBoxBoardDep";
            this.dataGridViewBoxBoardDep.ReadOnly = true;
            this.dataGridViewBoxBoardDep.Width = 75;
            // 
            // dataGridViewBoxBoardTo
            // 
            this.dataGridViewBoxBoardTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxBoardTo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBoxBoardTo.HeaderText = "To";
            this.dataGridViewBoxBoardTo.MinimumWidth = 6;
            this.dataGridViewBoxBoardTo.Name = "dataGridViewBoxBoardTo";
            this.dataGridViewBoxBoardTo.ReadOnly = true;
            // 
            // labelBoard
            // 
            this.labelBoard.AutoSize = true;
            this.labelBoard.Location = new System.Drawing.Point(125, 13);
            this.labelBoard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBoard.Name = "labelBoard";
            this.labelBoard.Size = new System.Drawing.Size(186, 23);
            this.labelBoard.TabIndex = 99;
            this.labelBoard.Text = "Departure Boards";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(1006, 14);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 49);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseHover += new System.EventHandler(this.closeSearch);
            // 
            // tabsContent
            // 
            this.tabsContent.Controls.Add(this.tabTim);
            this.tabsContent.Controls.Add(this.tabMap);
            this.tabsContent.Location = new System.Drawing.Point(13, 84);
            this.tabsContent.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabsContent.Name = "tabsContent";
            this.tabsContent.SelectedIndex = 0;
            this.tabsContent.Size = new System.Drawing.Size(1106, 698);
            this.tabsContent.TabIndex = 99;
            this.tabsContent.TabStop = false;
            this.tabsContent.MouseHover += new System.EventHandler(this.closeSearch);
            // 
            // tabTim
            // 
            this.tabTim.Controls.Add(this.dataGridViewTime);
            this.tabTim.Location = new System.Drawing.Point(4, 32);
            this.tabTim.Margin = new System.Windows.Forms.Padding(0);
            this.tabTim.Name = "tabTim";
            this.tabTim.Size = new System.Drawing.Size(1098, 662);
            this.tabTim.TabIndex = 0;
            this.tabTim.Text = "                     Timetable                      ";
            this.tabTim.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTime
            // 
            this.dataGridViewTime.AllowUserToAddRows = false;
            this.dataGridViewTime.AllowUserToDeleteRows = false;
            this.dataGridViewTime.AllowUserToResizeColumns = false;
            this.dataGridViewTime.AllowUserToResizeRows = false;
            this.dataGridViewTime.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewTime.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridViewTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTime.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewBoxTimeDep,
            this.dataGridViewBoxTimeFrom,
            this.dataGridViewBoxTimeArr,
            this.dataGridViewBoxTimeTo,
            this.dataGridViewBoxTimeDura});
            this.dataGridViewTime.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTime.Location = new System.Drawing.Point(2, 5);
            this.dataGridViewTime.Margin = new System.Windows.Forms.Padding(2, 5, 2, 2);
            this.dataGridViewTime.Name = "dataGridViewTime";
            this.dataGridViewTime.ReadOnly = true;
            this.dataGridViewTime.RowHeadersVisible = false;
            this.dataGridViewTime.RowHeadersWidth = 51;
            this.dataGridViewTime.RowTemplate.Height = 29;
            this.dataGridViewTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTime.Size = new System.Drawing.Size(1094, 554);
            this.dataGridViewTime.TabIndex = 0;
            // 
            // dataGridViewBoxTimeDep
            // 
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxTimeDep.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewBoxTimeDep.HeaderText = "Departure";
            this.dataGridViewBoxTimeDep.MinimumWidth = 6;
            this.dataGridViewBoxTimeDep.Name = "dataGridViewBoxTimeDep";
            this.dataGridViewBoxTimeDep.ReadOnly = true;
            this.dataGridViewBoxTimeDep.Width = 125;
            // 
            // dataGridViewBoxTimeFrom
            // 
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxTimeFrom.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewBoxTimeFrom.HeaderText = "From";
            this.dataGridViewBoxTimeFrom.MinimumWidth = 6;
            this.dataGridViewBoxTimeFrom.Name = "dataGridViewBoxTimeFrom";
            this.dataGridViewBoxTimeFrom.ReadOnly = true;
            this.dataGridViewBoxTimeFrom.Width = 325;
            // 
            // dataGridViewBoxTimeArr
            // 
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxTimeArr.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewBoxTimeArr.HeaderText = "Arrival";
            this.dataGridViewBoxTimeArr.MinimumWidth = 6;
            this.dataGridViewBoxTimeArr.Name = "dataGridViewBoxTimeArr";
            this.dataGridViewBoxTimeArr.ReadOnly = true;
            this.dataGridViewBoxTimeArr.Width = 125;
            // 
            // dataGridViewBoxTimeTo
            // 
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxTimeTo.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewBoxTimeTo.HeaderText = "To";
            this.dataGridViewBoxTimeTo.MinimumWidth = 6;
            this.dataGridViewBoxTimeTo.Name = "dataGridViewBoxTimeTo";
            this.dataGridViewBoxTimeTo.ReadOnly = true;
            this.dataGridViewBoxTimeTo.Width = 325;
            // 
            // dataGridViewBoxTimeDura
            // 
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxTimeDura.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewBoxTimeDura.HeaderText = "Duration";
            this.dataGridViewBoxTimeDura.MinimumWidth = 6;
            this.dataGridViewBoxTimeDura.Name = "dataGridViewBoxTimeDura";
            this.dataGridViewBoxTimeDura.ReadOnly = true;
            this.dataGridViewBoxTimeDura.Width = 125;
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.webViewMap);
            this.tabMap.Location = new System.Drawing.Point(4, 29);
            this.tabMap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabMap.Size = new System.Drawing.Size(1098, 665);
            this.tabMap.TabIndex = 1;
            this.tabMap.Text = "                     Map                      ";
            this.tabMap.UseVisualStyleBackColor = true;
            // 
            // webViewMap
            // 
            this.webViewMap.AllowExternalDrop = true;
            this.webViewMap.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.webViewMap.CreationProperties = null;
            this.webViewMap.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webViewMap.Location = new System.Drawing.Point(4, 4);
            this.webViewMap.Margin = new System.Windows.Forms.Padding(4);
            this.webViewMap.Name = "webViewMap";
            this.webViewMap.Size = new System.Drawing.Size(1088, 654);
            this.webViewMap.Source = new System.Uri("https://www.google.com/maps", System.UriKind.Absolute);
            this.webViewMap.TabIndex = 0;
            this.webViewMap.ZoomFactor = 1D;
            // 
            // panelDateFilter
            // 
            this.panelDateFilter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDateFilter.Controls.Add(this.checkDateFilter);
            this.panelDateFilter.Controls.Add(this.tabsDates);
            this.panelDateFilter.Location = new System.Drawing.Point(1135, 14);
            this.panelDateFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelDateFilter.Name = "panelDateFilter";
            this.panelDateFilter.Size = new System.Drawing.Size(431, 256);
            this.panelDateFilter.TabIndex = 3;
            // 
            // checkDateFilter
            // 
            this.checkDateFilter.AutoSize = true;
            this.checkDateFilter.Location = new System.Drawing.Point(75, 14);
            this.checkDateFilter.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.checkDateFilter.Name = "checkDateFilter";
            this.checkDateFilter.Size = new System.Drawing.Size(296, 27);
            this.checkDateFilter.TabIndex = 4;
            this.checkDateFilter.Text = "Filter date on Timetable";
            this.checkDateFilter.UseVisualStyleBackColor = true;
            this.checkDateFilter.CheckedChanged += new System.EventHandler(this.checkDateFilter_CheckedChanged);
            // 
            // tabsDates
            // 
            this.tabsDates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tabsDates.Controls.Add(this.tabDep);
            this.tabsDates.Controls.Add(this.tabArr);
            this.tabsDates.Enabled = false;
            this.tabsDates.Location = new System.Drawing.Point(9, 59);
            this.tabsDates.Margin = new System.Windows.Forms.Padding(9);
            this.tabsDates.Name = "tabsDates";
            this.tabsDates.SelectedIndex = 0;
            this.tabsDates.Size = new System.Drawing.Size(413, 186);
            this.tabsDates.TabIndex = 6;
            // 
            // tabDep
            // 
            this.tabDep.Controls.Add(this.dateTimePicker1);
            this.tabDep.Controls.Add(this.dateTimePicker2);
            this.tabDep.Location = new System.Drawing.Point(4, 32);
            this.tabDep.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabDep.Name = "tabDep";
            this.tabDep.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabDep.Size = new System.Drawing.Size(405, 150);
            this.tabDep.TabIndex = 0;
            this.tabDep.Text = "     Departure    ";
            this.tabDep.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 86);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(206, 31);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(112, 37);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(206, 31);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // tabArr
            // 
            this.tabArr.Location = new System.Drawing.Point(4, 29);
            this.tabArr.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabArr.Name = "tabArr";
            this.tabArr.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabArr.Size = new System.Drawing.Size(405, 153);
            this.tabArr.TabIndex = 1;
            this.tabArr.Text = "     Arrival     ";
            this.tabArr.UseVisualStyleBackColor = true;
            // 
            // panelTo
            // 
            this.panelTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTo.Controls.Add(this.txtBxTo);
            this.panelTo.Controls.Add(this.labelTo);
            this.panelTo.Location = new System.Drawing.Point(559, 14);
            this.panelTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelTo.Name = "panelTo";
            this.panelTo.Size = new System.Drawing.Size(432, 50);
            this.panelTo.TabIndex = 1;
            this.panelTo.TabStop = true;
            // 
            // txtBxTo
            // 
            this.txtBxTo.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBxTo.Location = new System.Drawing.Point(73, 9);
            this.txtBxTo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBxTo.Name = "txtBxTo";
            this.txtBxTo.Size = new System.Drawing.Size(347, 31);
            this.txtBxTo.TabIndex = 1;
            this.txtBxTo.TextChanged += new System.EventHandler(this.txtBxTo_TextChanged);
            this.txtBxTo.Enter += new System.EventHandler(this.txtBxTo_Enter);
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(19, 12);
            this.labelTo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(32, 23);
            this.labelTo.TabIndex = 1;
            this.labelTo.Text = "To";
            // 
            // panelFrom
            // 
            this.panelFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFrom.Controls.Add(this.labelFrom);
            this.panelFrom.Controls.Add(this.txtBxFrom);
            this.panelFrom.Location = new System.Drawing.Point(13, 14);
            this.panelFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(432, 50);
            this.panelFrom.TabIndex = 0;
            this.panelFrom.TabStop = true;
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(13, 12);
            this.labelFrom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(54, 23);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From";
            // 
            // txtBxFrom
            // 
            this.txtBxFrom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBxFrom.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBxFrom.Location = new System.Drawing.Point(73, 9);
            this.txtBxFrom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtBxFrom.Name = "txtBxFrom";
            this.txtBxFrom.Size = new System.Drawing.Size(347, 31);
            this.txtBxFrom.TabIndex = 0;
            this.txtBxFrom.TextChanged += new System.EventHandler(this.txtBxFrom_TextChanged);
            this.txtBxFrom.Enter += new System.EventHandler(this.txtBxFrom_Enter);
            // 
            // btnSwitch
            // 
            this.btnSwitch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSwitch.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSwitch.Location = new System.Drawing.Point(466, 14);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(72, 49);
            this.btnSwitch.TabIndex = 2;
            this.btnSwitch.Text = "⇄";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            this.btnSwitch.MouseHover += new System.EventHandler(this.closeSearch);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1632, 853);
            this.Controls.Add(this.panelCenter);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1600, 850);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swiss Transport [Form UI v1.1]";
            this.panelCenter.ResumeLayout(false);
            this.panelDepartureBoard.ResumeLayout(false);
            this.panelDepartureBoard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoard)).EndInit();
            this.tabsContent.ResumeLayout(false);
            this.tabTim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTime)).EndInit();
            this.tabMap.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webViewMap)).EndInit();
            this.panelDateFilter.ResumeLayout(false);
            this.panelDateFilter.PerformLayout();
            this.tabsDates.ResumeLayout(false);
            this.tabDep.ResumeLayout(false);
            this.panelTo.ResumeLayout(false);
            this.panelTo.PerformLayout();
            this.panelFrom.ResumeLayout(false);
            this.panelFrom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelCenter;
        private TextBox txtBxFrom;
        private Button btnSwitch;
        private Label labelTo;
        private Label labelFrom;
        private Panel panelFrom;
        private CheckBox checkDateFilter;
        private Panel panelTo;
        private Label labelBoard;
        private TextBox txtBxTo;
        private TabControl tabsContent;
        private TabPage tabTim;
        private TabPage tabMap;
        private Panel panelDateFilter;
        private Button btnRefresh;
        private DateTimePicker dateTimePicker1;
        private TabControl tabsDates;
        private TabPage tabDep;
        private TabPage tabArr;
        private DateTimePicker dateTimePicker2;
        private Panel panelDepartureBoard;
        private Button btnShare;
        private DataGridView dataGridViewTime;
        private DataGridView dataGridViewBoard;
        private Microsoft.Web.WebView2.WinForms.WebView2 webViewMap;
        private DataGridViewTextBoxColumn dataGridViewBoxBoardNr;
        private DataGridViewTextBoxColumn dataGridViewBoxBoardDep;
        private DataGridViewTextBoxColumn dataGridViewBoxBoardTo;
        private DataGridViewTextBoxColumn dataGridViewBoxTimeDep;
        private DataGridViewTextBoxColumn dataGridViewBoxTimeFrom;
        private DataGridViewTextBoxColumn dataGridViewBoxTimeArr;
        private DataGridViewTextBoxColumn dataGridViewBoxTimeTo;
        private DataGridViewTextBoxColumn dataGridViewBoxTimeDura;
    }
}