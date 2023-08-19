using TscoreTable;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestRadar4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataProvider dataProvider = new DataProvider();
            dataProvider.CreateDataTable();
            dataProvider.AddRow(1, "Mexico", 0, "Canada", 0);
            dataProvider.AddRow(2, "Spain", 0, "Brazil", 0);
            dataProvider.AddRow(3, "Germany", 0, "France", 0);
            dataProvider.AddRow(4, "Uruguay", 0, "Italy", 0);
            dataProvider.AddRow(5, "Argentina", 0, "Australia", 0);
        }
        public void UpdateView()
        {
            listView1.
        }
        
    }
}
