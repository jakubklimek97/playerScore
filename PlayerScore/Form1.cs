using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerScore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            parser pars = new parser("3f7ea984a4ad3e1b579fc28ecb5958b6");
            // Report[] tmp = await pars.GetReportsAsync(1553109180900);
            List<Report> res = new List<Report>();
            res.Clear();
            res.AddRange(Task<Report[]>.Run(async() => { return await pars.GetReportsAsync(new DateTimeOffset(monthCalendar1.SelectionStart).ToUnixTimeMilliseconds()); }).Result);
            reportsTable.DataSource = res;
            for(int i = 0; i < reportsTable.RowCount; ++i)       
            {
                reportsTable.Rows[i].Cells[1].Value = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(res[i].start)).ToLocalTime().ToString();
                reportsTable.Rows[i].Cells[2].Value = DateTimeOffset.FromUnixTimeMilliseconds(long.Parse(res[i].end)).ToLocalTime().ToString();
            }
        }

        private void genButton_Click(object sender, EventArgs e)
        {
            if(reportsTable.SelectedRows.Count > 0)
            {
                
            }
        }
    }
}
