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


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingSimulator
{
    public partial class EditForm : Form
    {
        public EditForm()
        {
            InitializeComponent();
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            rowName.Text = Form1.curritem.SubItems[0].Text;
            Percentagetxt.Text = Form1.curritem.SubItems[1].Text;
            if (Form1.curritem.SubItems[2].Text.Equals("true")) WinRadio.Checked = true;
            else LoseRadio.Checked = true;
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            List<ListViewItem> retard = Form1.currlistitem;
            int getindex = retard.IndexOf(Form1.curritem);
            double.TryParse(Percentagetxt.Text, out double c);
            double.TryParse(Form1.curritem.SubItems[1].Text, out double prev);
            double cmp = (c - prev)/(retard.Count - 1);
            string[] arr = { rowName.Text, Percentagetxt.Text, (WinRadio.Checked ? "true" : "false") };
            ListViewItem n = new ListViewItem(arr);
            retard[getindex] = n;
            if (!retard.All(x => double.Parse(x.SubItems[1].Text) == c))
            {
                for(int i = 0; i < retard.Count; i++)
                {
                    double.TryParse(retard[i].SubItems[1].Text, out double tmp);
                    if (tmp == c) continue;
                    else retard[i].SubItems[1].Text = (tmp - cmp).ToString();
                }
            }
            Form1.currlistitem = retard;
            this.Close();
        }
    }
}
