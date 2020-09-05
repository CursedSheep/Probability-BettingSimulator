/**********************************************************************************
        Copyright (C) 2020  CursedSheep
        This program is free software: you can redistribute it and/or modify
        it under the terms of the GNU General Public License as published by
        the Free Software Foundation, either version 3 of the License, or
        (at your option) any later version.
        This program is distributed in the hope that it will be useful,
        but WITHOUT ANY WARRANTY; without even the implied warranty of
        MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
        GNU General Public License for more details.
**********************************************************************************/



namespace BettingSimulator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label4 = new System.Windows.Forms.Label();
            this.Randomizables = new System.Windows.Forms.ComboBox();
            this.objectCount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SimulateBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.OutDelay = new System.Windows.Forms.TextBox();
            this.ProbabilityChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.betChk = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Bettxtbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Rewardtxtbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SubItemsList = new System.Windows.Forms.ListView();
            this.ColName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Percentage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Win = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EditListView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetxd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityChart)).BeginInit();
            this.EditListView.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Betting Simulator";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label4_MouseDown);
            // 
            // Randomizables
            // 
            this.Randomizables.FormattingEnabled = true;
            this.Randomizables.Location = new System.Drawing.Point(9, 27);
            this.Randomizables.Name = "Randomizables";
            this.Randomizables.Size = new System.Drawing.Size(112, 21);
            this.Randomizables.TabIndex = 2;
            this.Randomizables.SelectedIndexChanged += new System.EventHandler(this.Randomizables_SelectedIndexChanged);
            // 
            // objectCount
            // 
            this.objectCount.Location = new System.Drawing.Point(127, 28);
            this.objectCount.Name = "objectCount";
            this.objectCount.Size = new System.Drawing.Size(41, 20);
            this.objectCount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(6, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Items:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(124, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Count:";
            // 
            // SimulateBtn
            // 
            this.SimulateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SimulateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SimulateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SimulateBtn.Location = new System.Drawing.Point(244, 28);
            this.SimulateBtn.Name = "SimulateBtn";
            this.SimulateBtn.Size = new System.Drawing.Size(79, 22);
            this.SimulateBtn.TabIndex = 6;
            this.SimulateBtn.Text = "Simulate";
            this.SimulateBtn.UseVisualStyleBackColor = false;
            this.SimulateBtn.Click += new System.EventHandler(this.SimulateBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(171, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Delay(ms):";
            // 
            // OutDelay
            // 
            this.OutDelay.Location = new System.Drawing.Point(174, 28);
            this.OutDelay.Name = "OutDelay";
            this.OutDelay.Size = new System.Drawing.Size(64, 20);
            this.OutDelay.TabIndex = 7;
            // 
            // ProbabilityChart
            // 
            this.ProbabilityChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProbabilityChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(64)))));
            chartArea3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            chartArea3.Name = "ChartArea1";
            this.ProbabilityChart.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(33)))), ((int)(((byte)(77)))));
            legend3.ForeColor = System.Drawing.Color.Lime;
            legend3.Name = "Legend1";
            this.ProbabilityChart.Legends.Add(legend3);
            this.ProbabilityChart.Location = new System.Drawing.Point(12, 187);
            this.ProbabilityChart.Name = "ProbabilityChart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.ProbabilityChart.Series.Add(series3);
            this.ProbabilityChart.Size = new System.Drawing.Size(590, 229);
            this.ProbabilityChart.TabIndex = 9;
            this.ProbabilityChart.Text = "chart1";
            // 
            // betChk
            // 
            this.betChk.AutoSize = true;
            this.betChk.Location = new System.Drawing.Point(10, 71);
            this.betChk.Name = "betChk";
            this.betChk.Size = new System.Drawing.Size(42, 17);
            this.betChk.TabIndex = 10;
            this.betChk.Text = "Bet";
            this.betChk.UseVisualStyleBackColor = true;
            this.betChk.Click += new System.EventHandler(this.BetChk_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(49, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bet:";
            // 
            // Bettxtbox
            // 
            this.Bettxtbox.Location = new System.Drawing.Point(52, 69);
            this.Bettxtbox.Name = "Bettxtbox";
            this.Bettxtbox.Size = new System.Drawing.Size(42, 20);
            this.Bettxtbox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(97, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Reward:";
            // 
            // Rewardtxtbox
            // 
            this.Rewardtxtbox.Location = new System.Drawing.Point(100, 69);
            this.Rewardtxtbox.Name = "Rewardtxtbox";
            this.Rewardtxtbox.Size = new System.Drawing.Size(51, 20);
            this.Rewardtxtbox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(326, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Subitems:";
            // 
            // SubItemsList
            // 
            this.SubItemsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColName,
            this.Percentage,
            this.Win});
            this.SubItemsList.ContextMenuStrip = this.EditListView;
            this.SubItemsList.FullRowSelect = true;
            this.SubItemsList.HideSelection = false;
            this.SubItemsList.Location = new System.Drawing.Point(329, 24);
            this.SubItemsList.Name = "SubItemsList";
            this.SubItemsList.Size = new System.Drawing.Size(252, 98);
            this.SubItemsList.TabIndex = 22;
            this.SubItemsList.UseCompatibleStateImageBehavior = false;
            this.SubItemsList.View = System.Windows.Forms.View.Details;
            // 
            // ColName
            // 
            this.ColName.Text = "Name";
            this.ColName.Width = 71;
            // 
            // Percentage
            // 
            this.Percentage.Text = "Percentage";
            this.Percentage.Width = 97;
            // 
            // Win
            // 
            this.Win.Text = "Win";
            this.Win.Width = 80;
            // 
            // EditListView
            // 
            this.EditListView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.EditListView.Name = "EditListView";
            this.EditListView.Size = new System.Drawing.Size(95, 26);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(94, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditToolStripMenuItem_Click);
            // 
            // resetxd
            // 
            this.resetxd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.resetxd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetxd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetxd.Location = new System.Drawing.Point(157, 67);
            this.resetxd.Name = "resetxd";
            this.resetxd.Size = new System.Drawing.Size(91, 22);
            this.resetxd.TabIndex = 24;
            this.resetxd.Text = "Reset table";
            this.resetxd.UseVisualStyleBackColor = false;
            this.resetxd.Click += new System.EventHandler(this.Resetxd_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(484, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "By CursedSheep";
            // 
            // stopBtn
            // 
            this.stopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopBtn.Location = new System.Drawing.Point(254, 67);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(69, 22);
            this.stopBtn.TabIndex = 26;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = false;
            this.stopBtn.Click += new System.EventHandler(this.StopBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.SubItemsList);
            this.panel2.Controls.Add(this.Randomizables);
            this.panel2.Controls.Add(this.stopBtn);
            this.panel2.Controls.Add(this.objectCount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.resetxd);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SimulateBtn);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.OutDelay);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Rewardtxtbox);
            this.panel2.Controls.Add(this.betChk);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Bettxtbox);
            this.panel2.Location = new System.Drawing.Point(12, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(591, 136);
            this.panel2.TabIndex = 27;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(608, 443);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProbabilityChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProbabilityChart)).EndInit();
            this.EditListView.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Randomizables;
        private System.Windows.Forms.TextBox objectCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SimulateBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OutDelay;
        private System.Windows.Forms.DataVisualization.Charting.Chart ProbabilityChart;
        private System.Windows.Forms.CheckBox betChk;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Bettxtbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Rewardtxtbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView SubItemsList;
        private System.Windows.Forms.ColumnHeader ColName;
        private System.Windows.Forms.ColumnHeader Percentage;
        private System.Windows.Forms.ColumnHeader Win;
        private System.Windows.Forms.ContextMenuStrip EditListView;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Button resetxd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Panel panel2;
    }
}

