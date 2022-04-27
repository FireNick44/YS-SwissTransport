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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelCenter = new System.Windows.Forms.Panel();
            this.panelDepartureBoard = new System.Windows.Forms.Panel();
            this.listBxDepBoard = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnShare = new System.Windows.Forms.Button();
            this.tabsContent = new System.Windows.Forms.TabControl();
            this.tabTim = new System.Windows.Forms.TabPage();
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
            this.label2 = new System.Windows.Forms.Label();
            this.panelFrom = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBxFrom = new System.Windows.Forms.TextBox();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.panelCenter.SuspendLayout();
            this.panelDepartureBoard.SuspendLayout();
            this.tabsContent.SuspendLayout();
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
            this.panelCenter.Controls.Add(this.panelDepartureBoard);
            this.panelCenter.Controls.Add(this.btnShare);
            this.panelCenter.Controls.Add(this.tabsContent);
            this.panelCenter.Controls.Add(this.panelDateFilter);
            this.panelCenter.Controls.Add(this.panelTo);
            this.panelCenter.Controls.Add(this.panelFrom);
            this.panelCenter.Controls.Add(this.btnSwitch);
            this.panelCenter.Location = new System.Drawing.Point(25, 27);
            this.panelCenter.Margin = new System.Windows.Forms.Padding(0);
            this.panelCenter.Name = "panelCenter";
            this.panelCenter.Size = new System.Drawing.Size(1582, 800);
            this.panelCenter.TabIndex = 0;
            // 
            // panelDepartureBoard
            // 
            this.panelDepartureBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDepartureBoard.Controls.Add(this.listBxDepBoard);
            this.panelDepartureBoard.Controls.Add(this.label3);
            this.panelDepartureBoard.Location = new System.Drawing.Point(1135, 287);
            this.panelDepartureBoard.Name = "panelDepartureBoard";
            this.panelDepartureBoard.Size = new System.Drawing.Size(431, 495);
            this.panelDepartureBoard.TabIndex = 99;
            // 
            // listBxDepBoard
            // 
            this.listBxDepBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listBxDepBoard.FormattingEnabled = true;
            this.listBxDepBoard.ItemHeight = 23;
            this.listBxDepBoard.Items.AddRange(new object[] {
            "",
            "     choose a starting location     "});
            this.listBxDepBoard.Location = new System.Drawing.Point(9, 66);
            this.listBxDepBoard.Name = "listBxDepBoard";
            this.listBxDepBoard.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBxDepBoard.Size = new System.Drawing.Size(409, 418);
            this.listBxDepBoard.TabIndex = 99;
            this.listBxDepBoard.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(125, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 99;
            this.label3.Text = "Departure Boards";
            // 
            // btnShare
            // 
            this.btnShare.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnShare.Location = new System.Drawing.Point(1006, 14);
            this.btnShare.Margin = new System.Windows.Forms.Padding(5);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(110, 50);
            this.btnShare.TabIndex = 5;
            this.btnShare.Text = "Share";
            this.btnShare.UseVisualStyleBackColor = true;
            // 
            // tabsContent
            // 
            this.tabsContent.Controls.Add(this.tabTim);
            this.tabsContent.Controls.Add(this.tabMap);
            this.tabsContent.Location = new System.Drawing.Point(14, 84);
            this.tabsContent.Name = "tabsContent";
            this.tabsContent.SelectedIndex = 0;
            this.tabsContent.Size = new System.Drawing.Size(1106, 698);
            this.tabsContent.TabIndex = 99;
            this.tabsContent.TabStop = false;
            // 
            // tabTim
            // 
            this.tabTim.Location = new System.Drawing.Point(4, 32);
            this.tabTim.Margin = new System.Windows.Forms.Padding(0);
            this.tabTim.Name = "tabTim";
            this.tabTim.Size = new System.Drawing.Size(1098, 662);
            this.tabTim.TabIndex = 0;
            this.tabTim.Text = "                     Timetable                      ";
            this.tabTim.UseVisualStyleBackColor = true;
            // 
            // tabMap
            // 
            this.tabMap.Location = new System.Drawing.Point(4, 32);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(1098, 662);
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
            this.panelDateFilter.Name = "panelDateFilter";
            this.panelDateFilter.Size = new System.Drawing.Size(431, 256);
            this.panelDateFilter.TabIndex = 3;
            // 
            // checkDateFilter
            // 
            this.checkDateFilter.AutoSize = true;
            this.checkDateFilter.Location = new System.Drawing.Point(101, 16);
            this.checkDateFilter.Name = "checkDateFilter";
            this.checkDateFilter.Size = new System.Drawing.Size(230, 27);
            this.checkDateFilter.TabIndex = 3;
            this.checkDateFilter.Text = "Filter travel date";
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
            this.tabDep.Name = "tabDep";
            this.tabDep.Padding = new System.Windows.Forms.Padding(3);
            this.tabDep.Size = new System.Drawing.Size(405, 150);
            this.tabDep.TabIndex = 0;
            this.tabDep.Text = "     Departure    ";
            this.tabDep.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(112, 86);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(162, 31);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(112, 27);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(162, 31);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // tabArr
            // 
            this.tabArr.Location = new System.Drawing.Point(4, 32);
            this.tabArr.Name = "tabArr";
            this.tabArr.Padding = new System.Windows.Forms.Padding(3);
            this.tabArr.Size = new System.Drawing.Size(405, 150);
            this.tabArr.TabIndex = 1;
            this.tabArr.Text = "     Arrival     ";
            this.tabArr.UseVisualStyleBackColor = true;
            // 
            // panelTo
            // 
            this.panelTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTo.Controls.Add(this.txtBxTo);
            this.panelTo.Controls.Add(this.label2);
            this.panelTo.Location = new System.Drawing.Point(558, 14);
            this.panelTo.Name = "panelTo";
            this.panelTo.Size = new System.Drawing.Size(432, 50);
            this.panelTo.TabIndex = 1;
            this.panelTo.TabStop = true;
            // 
            // txtBxTo
            // 
            this.txtBxTo.Location = new System.Drawing.Point(73, 9);
            this.txtBxTo.Name = "txtBxTo";
            this.txtBxTo.Size = new System.Drawing.Size(347, 31);
            this.txtBxTo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "To";
            // 
            // panelFrom
            // 
            this.panelFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFrom.Controls.Add(this.label1);
            this.panelFrom.Controls.Add(this.txtBxFrom);
            this.panelFrom.Location = new System.Drawing.Point(14, 14);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(432, 50);
            this.panelFrom.TabIndex = 0;
            this.panelFrom.TabStop = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "From";
            // 
            // txtBxFrom
            // 
            this.txtBxFrom.Location = new System.Drawing.Point(73, 9);
            this.txtBxFrom.Name = "txtBxFrom";
            this.txtBxFrom.Size = new System.Drawing.Size(347, 31);
            this.txtBxFrom.TabIndex = 0;
            this.txtBxFrom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBxFrom_KeyPress);
            this.txtBxFrom.Leave += new System.EventHandler(this.txtBxFrom_Leave);
            this.txtBxFrom.MouseLeave += new System.EventHandler(this.txtBxFrom_Leave);
            // 
            // btnSwitch
            // 
            this.btnSwitch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSwitch.Font = new System.Drawing.Font("Consolas", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSwitch.Location = new System.Drawing.Point(466, 14);
            this.btnSwitch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(72, 50);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1600, 850);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swiss Transport [Form UI v1.1]";
            this.panelCenter.ResumeLayout(false);
            this.panelDepartureBoard.ResumeLayout(false);
            this.panelDepartureBoard.PerformLayout();
            this.tabsContent.ResumeLayout(false);
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
        private Label label2;
        private Label label1;
        private Panel panelFrom;
        private CheckBox checkDateFilter;
        private Panel panelTo;
        private Label label3;
        private TextBox txtBxTo;
        private TabControl tabsContent;
        private TabPage tabTim;
        private TabPage tabMap;
        private Panel panelDateFilter;
        private Button btnShare;
        private DateTimePicker dateTimePicker1;
        private TabControl tabsDates;
        private TabPage tabDep;
        private TabPage tabArr;
        private DateTimePicker dateTimePicker2;
        private ListBox listBxDepBoard;
        private Panel panelDepartureBoard;
    }
}