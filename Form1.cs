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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BettingSimulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static int ghp { get; set; }
        [DllImport("shlwapi.dll")]
        public static extern int ColorHLSToRGB(int H, int L, int S);
        public void timer_Tick(object sender, EventArgs e)
        {
            if (ghp == 240)
            {
                ghp = 0;
            }
            else
            {
                ghp++;


                label4.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
                label8.ForeColor = ColorTranslator.FromWin32(ColorHLSToRGB(ghp, 100, 150));
            }
        }
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        public struct Randomizers
        {
            public string name;
            public int start;
            public int end;
            public List<string> items;
            public Randomizers(string Rname, int Rstart, int Rend)
            {
                name = Rname;
                start = Rstart;
                end = Rend;
                items = new List<string>();
                for (int i = start; i <= end; i++) items.Add(i.ToString());
            }
            public Randomizers(string Rname, int Rstart, int Rend, List<string> Ritems)
            {
                name = Rname;
                start = Rstart;
                end = Rend;
                items = Ritems;
            }
        }
        static List<Randomizers> Options = new List<Randomizers>();
        public static Random rnd = new Random();
        public static int counter = 0;
        public static int money = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 40;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Enabled = true;
            timer.Start();
            Console.Title = "Epic Random Simulator [DEBUG CONSOLE]";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("---Epic Random Simulator---");
            Options.Add(new Randomizers("Coin", 1, 2, new List<string>(new[] { "Heads", "Tails" })));
            Options.Add(new Randomizers("Die", 1, 6));
            List<string> doc = new List<string>();
            string[] firstdoc = { "Clubs", "Diamonds", "Hearts", "Spades" };
            string[] firstdoc2 = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "king" };
            foreach (string n in firstdoc) 
                foreach (string m in firstdoc2) doc.Add(m + " of " + n);
            Options.Add(new Randomizers("Deck of cards", 1, doc.Count, doc));
            Options.Add(new Randomizers("Roulette", 1, 38, "0-32-15-19-4-21-2-25-17-34-6-27-13-36-11-30-8-23-10-5-24-16-33-1-20-14-31-9-22-18-29-7-28-12-35-3-26".Split('-').ToList()));
            Randomizables.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (var items in Options) Randomizables.Items.Add(items.name);
            objectCount.Text = "1";
            OutDelay.Text = "500";
            Randomizables.SelectedIndex = 0;
            Rewardtxtbox.Text = "";
            Bettxtbox.Text = "";
            Bettxtbox.Enabled = false;
            Rewardtxtbox.Enabled = false;
            started = false;
            stopBtn.Enabled = false;
            SimulateBtn.Enabled = true;
        }
        private List<Tuple<double, double>> calcRange()
        {
            List<Tuple<double, double>> tmp = new List<Tuple<double, double>>();
            double prev = 0;
            double curr = 0;
            for(int i = 0; i < SubItemsList.Items.Count; i++)
            {
                double tmpf;
                double.TryParse(SubItemsList.Items[i].SubItems[1].Text, out tmpf);
                curr = prev + tmpf;
                if (curr > 100) curr = 100;
                tmp.Add(Tuple.Create(prev, curr));
                prev = curr;
            }
            return tmp;
        }
        public static bool started = false;
        private async void SimulateBtn_Click(object sender, EventArgs e)
        {
            started = true;
            stopBtn.Enabled = true;
            SimulateBtn.Enabled = false;
            resetxd.Enabled = false;
            Randomizers selected = Options.First(x => x.name.Equals(Randomizables.Text));
            int.TryParse(objectCount.Text, out int num);
            int.TryParse(OutDelay.Text, out int num2);
            var t = calcRange();
            for (int i = 0; i < num; i++)
            {
                if (started == false) goto okmen;
                counter++;
                double resultorig = rnd.NextDouble() * ((double)(100) - (double)0) + (double)0;
                int result = t.IndexOf(t.First(x => resultorig >= x.Item1 && resultorig <= x.Item2));
                ProbabilityChart.Series[0].Points[result ].YValues[0]++;
                ProbabilityChart.Series[0].Points[result ].XValue++;
                ProbabilityChart.Series[0].Points[result ].LegendText = selected.items[result ] + " = " + (ProbabilityChart.Series[0].Points[result ].XValue - 1) + "/" + counter + " = " + Math.Round((ProbabilityChart.Series[0].Points[result ].XValue-1) / counter, 3, MidpointRounding.AwayFromZero);
                for(int o = 0; o < ProbabilityChart.Series[0].Points.Count; o++)
                {
                    ProbabilityChart.Series[0].Points[o].LegendText = selected.items[o] + " = " + (ProbabilityChart.Series[0].Points[o].XValue-1) + "/" + counter + " = " + Math.Round((ProbabilityChart.Series[0].Points[o].XValue - 1) / counter, 3, MidpointRounding.AwayFromZero);
                }
                if (betChk.Checked)
                {
                    int.TryParse(Bettxtbox.Text, out int currbet);
                    int.TryParse(Rewardtxtbox.Text, out int currreward);
                    List<string> temp = new List<string>();
                    if (SubItemsList.Items[result].SubItems[2].Text.Equals("true")) money += currreward;
                    else money -= currbet;
                }
                if (selected.items.Count > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("[DEBUG] ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("[" + counter +"] ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(selected.name);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" has been simulated and got ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(selected.items[result]);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(".");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("[DEBUG] ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("[" + counter + "] ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(selected.name);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(" has been simulated and got ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(result);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(".");
                }
                await Task.Delay(num2);
            }
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[DEBUG] ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Simulation complete!");
            if(betChk.Checked)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("[DEBUG] ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Money earned: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(money);
                int.TryParse(Bettxtbox.Text, out int currbet);
                int.TryParse(Rewardtxtbox.Text, out int currreward);
                double expectedValue = 0;
                foreach(ListViewItem itemg in SubItemsList.Items)
                {
                      expectedValue += (((double.Parse(itemg.SubItems[1].Text) / (double)100)) * (itemg.SubItems[2].Text.Equals("true") ? currreward : currbet));
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("[DEBUG] ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Expected value: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(expectedValue * num);
            }
        okmen:
            started = false;
            stopBtn.Enabled = false;
            SimulateBtn.Enabled = true;
            resetxd.Enabled = true;
        }

        private void CloseApp_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Randomizables_SelectedIndexChanged(object sender, EventArgs e)
        {
            counter = 0;
            money = 0;
            Randomizers selected = Options.First(x => x.name.Equals(Randomizables.Text));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[DEBUG] ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(selected.name);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" has been selected!");
            ProbabilityChart.Series[0].Points.Clear();
            if(selected.items.Count > 0)
            {
                foreach (var a in selected.items)
                {
                    var c = new System.Windows.Forms.DataVisualization.Charting.Series(a, 0);
                    var d = new System.Windows.Forms.DataVisualization.Charting.DataPoint(c);
                    d.Label = a;
                    d.LegendText = a;
                    d.XValue = 1;
                    d.YValues = new double[]{1};
                    ProbabilityChart.Series[0].Points.Add(d);
                }
            }
            else
            {
                for(int i = selected.start; i <= selected.end; i++)
                {
                    var c = new System.Windows.Forms.DataVisualization.Charting.Series(i.ToString(), 0);
                    var d = new System.Windows.Forms.DataVisualization.Charting.DataPoint(c);
                    d.LegendText = i.ToString();
                    d.Label = i.ToString();
                    d.XValue = 1;
                    d.YValues = new double[] { 1 };
                    ProbabilityChart.Series[0].Points.Add(d);
                }
            }
            SubItemsList.Items.Clear();
            for (int i = 0; i < selected.items.Count; i++)
            {
                string[] arr = { selected.items[i], Math.Round(((((double)1) * (double)100) / (double)selected.items.Count), 3, MidpointRounding.AwayFromZero).ToString(), "false" };
                ListViewItem a = new ListViewItem(arr);
                SubItemsList.Items.Add(a);
            }
            if (betChk.Checked)
            {
                Bettxtbox.Enabled = true;
                Rewardtxtbox.Enabled = true;
            }
            else
            {
                Rewardtxtbox.Text = "";
                Bettxtbox.Text = "";
                Bettxtbox.Enabled = false;
                Rewardtxtbox.Enabled = false;
            }
        }

        private void BetChk_Click(object sender, EventArgs e)
        {
            if (betChk.Checked)
            {
                Bettxtbox.Enabled = true;
                Rewardtxtbox.Enabled = true;
            }
            else
            {
                Rewardtxtbox.Text = "";
                Bettxtbox.Text = "";
                Bettxtbox.Enabled = false;
                Rewardtxtbox.Enabled = false;
            }
        }
        public static ListViewItem curritem = null;
        public static List<ListViewItem> currlistitem = new List<ListViewItem>();
        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            curritem = null;
            currlistitem = new List<ListViewItem>();
            if(SubItemsList.Items.Count > 0)
            {
                if(SubItemsList.SelectedItems.Count == 1)
                {
                    curritem = SubItemsList.SelectedItems[0];
                    foreach (var items in SubItemsList.Items) currlistitem.Add((ListViewItem)items);
                    EditForm a = new EditForm();
                    a.ShowDialog();
                    SubItemsList.Items.Clear();
                    foreach (var items in currlistitem) SubItemsList.Items.Add(items);

                }
            }
        }

        private void Resetxd_Click(object sender, EventArgs e)
        {
            counter = 0;
            money = 0;
            Randomizers selected = Options.First(x => x.name.Equals(Randomizables.Text));
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[DEBUG] ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Data and Table has been reset!");
            ProbabilityChart.Series[0].Points.Clear();
            if (selected.items.Count > 0)
            {
                foreach (var a in selected.items)
                {
                    var c = new System.Windows.Forms.DataVisualization.Charting.Series(a, 0);
                    var d = new System.Windows.Forms.DataVisualization.Charting.DataPoint(c);
                    d.Label = a;
                    d.LegendText = a;
                    d.XValue = 1;
                    d.YValues = new double[] { 1 };
                    ProbabilityChart.Series[0].Points.Add(d);
                }
            }
            else
            {
                for (int i = selected.start; i <= selected.end; i++)
                {
                    var c = new System.Windows.Forms.DataVisualization.Charting.Series(i.ToString(), 0);
                    var d = new System.Windows.Forms.DataVisualization.Charting.DataPoint(c);
                    d.LegendText = i.ToString();
                    d.Label = i.ToString();
                    d.XValue = 1;
                    d.YValues = new double[] { 1 };
                    ProbabilityChart.Series[0].Points.Add(d);
                }
            }
            SubItemsList.Items.Clear();
            for (int i = 0; i < selected.items.Count; i++)
            {
                string[] arr = { selected.items[i], Math.Round(((((double)1) * (double)100) / (double)selected.items.Count), 3, MidpointRounding.AwayFromZero).ToString(), "false" };
                ListViewItem a = new ListViewItem(arr);
                SubItemsList.Items.Add(a);
            }
            if (betChk.Checked)
            {
                Bettxtbox.Enabled = true;
                Rewardtxtbox.Enabled = true;
            }
            else
            {
                Rewardtxtbox.Text = "";
                Bettxtbox.Text = "";
                Bettxtbox.Enabled = false;
                Rewardtxtbox.Enabled = false;
            }
        }

        private void Label4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void StopBtn_Click(object sender, EventArgs e)
        {
            started = false;
            stopBtn.Enabled = false;
            SimulateBtn.Enabled = true;
            resetxd.Enabled = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("[DEBUG] ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Simulation has been interrupted!");
            resetxd.PerformClick();
        }
    }
}
