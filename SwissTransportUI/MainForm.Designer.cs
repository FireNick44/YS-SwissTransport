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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelCenter = new System.Windows.Forms.Panel();
            this.btnShare = new System.Windows.Forms.Button();
            this.panelDepartureBoard = new System.Windows.Forms.Panel();
            this.dataGridViewBoard = new System.Windows.Forms.DataGridView();
            this.dataGridViewBoxNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBoxDep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBoxTo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelBoard = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tabsContent = new System.Windows.Forms.TabControl();
            this.tabTim = new System.Windows.Forms.TabPage();
            this.dataGridViewTime = new System.Windows.Forms.DataGridView();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabMap = new System.Windows.Forms.TabPage();
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
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = true;
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
            this.dataGridViewBoxNr,
            this.dataGridViewBoxDep,
            this.dataGridViewBoxTo});
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
            // dataGridViewBoxNr
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxNr.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewBoxNr.HeaderText = "Nr";
            this.dataGridViewBoxNr.MinimumWidth = 6;
            this.dataGridViewBoxNr.Name = "dataGridViewBoxNr";
            this.dataGridViewBoxNr.ReadOnly = true;
            this.dataGridViewBoxNr.Width = 60;
            // 
            // dataGridViewBoxDep
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxDep.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewBoxDep.HeaderText = "Dep";
            this.dataGridViewBoxDep.MinimumWidth = 6;
            this.dataGridViewBoxDep.Name = "dataGridViewBoxDep";
            this.dataGridViewBoxDep.ReadOnly = true;
            this.dataGridViewBoxDep.Width = 75;
            // 
            // dataGridViewBoxTo
            // 
            this.dataGridViewBoxTo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridViewBoxTo.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewBoxTo.HeaderText = "To";
            this.dataGridViewBoxTo.MinimumWidth = 6;
            this.dataGridViewBoxTo.Name = "dataGridViewBoxTo";
            this.dataGridViewBoxTo.ReadOnly = true;
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
            this.From,
            this.To,
            this.Departure,
            this.Arrival,
            this.Duration});
            this.dataGridViewTime.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewTime.Location = new System.Drawing.Point(2, 0);
            this.dataGridViewTime.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewTime.Name = "dataGridViewTime";
            this.dataGridViewTime.ReadOnly = true;
            this.dataGridViewTime.RowHeadersVisible = false;
            this.dataGridViewTime.RowHeadersWidth = 51;
            this.dataGridViewTime.RowTemplate.Height = 29;
            this.dataGridViewTime.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTime.Size = new System.Drawing.Size(1094, 472);
            this.dataGridViewTime.TabIndex = 0;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 6;
            this.From.Name = "From";
            this.From.ReadOnly = true;
            this.From.Width = 125;
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 6;
            this.To.Name = "To";
            this.To.ReadOnly = true;
            this.To.Width = 125;
            // 
            // Departure
            // 
            this.Departure.HeaderText = "Departure";
            this.Departure.MinimumWidth = 6;
            this.Departure.Name = "Departure";
            this.Departure.ReadOnly = true;
            this.Departure.Width = 125;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            this.Arrival.ReadOnly = true;
            this.Arrival.Width = 125;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            this.Duration.Width = 125;
            // 
            // tabMap
            // 
            this.tabMap.Location = new System.Drawing.Point(4, 29);
            this.tabMap.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabMap.Size = new System.Drawing.Size(1098, 665);
            this.tabMap.TabIndex = 1;
            this.tabMap.Text = "                     Map                      ";
            this.tabMap.UseVisualStyleBackColor = true;
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
        private DataGridViewTextBoxColumn From;
        private DataGridViewTextBoxColumn To;
        private DataGridViewTextBoxColumn Departure;
        private DataGridViewTextBoxColumn Arrival;
        private DataGridViewTextBoxColumn Duration;
        private DataGridView dataGridViewBoard;
        private DataGridViewTextBoxColumn dataGridViewBoxNr;
        private DataGridViewTextBoxColumn dataGridViewBoxDep;
        private DataGridViewTextBoxColumn dataGridViewBoxTo;
    }
}