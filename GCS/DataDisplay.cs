using System;
using System.Windows.Forms;
using System.Collections.Generic;
namespace GCS
{
    public partial class DataDisplay : Form
    {
        public DataDisplay()
        {
            InitializeComponent();
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(3);
            list.Add(4);
            list.Add(7);
            list.Add(1);
            chart1.DataSource = list;
        }

        private void DataDisplay_Load(object sender, EventArgs e)
        {
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}