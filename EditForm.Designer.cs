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
    partial class EditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.rowName = new System.Windows.Forms.TextBox();
            this.Percentagetxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WinRadio = new System.Windows.Forms.RadioButton();
            this.LoseRadio = new System.Windows.Forms.RadioButton();
            this.okbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // rowName
            // 
            this.rowName.Location = new System.Drawing.Point(79, 28);
            this.rowName.Name = "rowName";
            this.rowName.Size = new System.Drawing.Size(184, 20);
            this.rowName.TabIndex = 1;
            // 
            // Percentagetxt
            // 
            this.Percentagetxt.Location = new System.Drawing.Point(79, 54);
            this.Percentagetxt.Name = "Percentagetxt";
            this.Percentagetxt.Size = new System.Drawing.Size(184, 20);
            this.Percentagetxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Percentage: ";
            // 
            // WinRadio
            // 
            this.WinRadio.AutoSize = true;
            this.WinRadio.Location = new System.Drawing.Point(16, 84);
            this.WinRadio.Name = "WinRadio";
            this.WinRadio.Size = new System.Drawing.Size(44, 17);
            this.WinRadio.TabIndex = 4;
            this.WinRadio.TabStop = true;
            this.WinRadio.Text = "Win";
            this.WinRadio.UseVisualStyleBackColor = true;
            // 
            // LoseRadio
            // 
            this.LoseRadio.AutoSize = true;
            this.LoseRadio.Location = new System.Drawing.Point(107, 84);
            this.LoseRadio.Name = "LoseRadio";
            this.LoseRadio.Size = new System.Drawing.Size(48, 17);
            this.LoseRadio.TabIndex = 5;
            this.LoseRadio.TabStop = true;
            this.LoseRadio.Text = "Lose";
            this.LoseRadio.UseVisualStyleBackColor = true;
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(258, 96);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(75, 23);
            this.okbtn.TabIndex = 6;
            this.okbtn.Text = "Ok";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.Okbtn_Click);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 131);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.LoseRadio);
            this.Controls.Add(this.WinRadio);
            this.Controls.Add(this.Percentagetxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rowName);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rowName;
        private System.Windows.Forms.TextBox Percentagetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton WinRadio;
        private System.Windows.Forms.RadioButton LoseRadio;
        private System.Windows.Forms.Button okbtn;
    }
}