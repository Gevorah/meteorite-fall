using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace meteorite_falls
{
    public partial class Form1 : Form
    {

        public const string FILE = "data/meteoritos_2000-2010.csv";

        public Form1()
        {
            InitializeComponent();
            init();
        }

        private DataTable dt = new DataTable();

        private void init()
        {
            try
            {
                StreamReader sr = new StreamReader(FILE);
                string line;
                bool f = true;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] sl = line.Split(',');
                    if (f == true)
                    {
                        for (int k = 0; k < sl.Length; k++)
                        {
                            dt.Columns.Add(sl[k]);
                        }
                        f = false;
                    }
                    else
                    {
                        dt.Rows.Add(sl);
                    }
                }
                data.DataSource = dt;
            }
            catch (IOException)
            {

            }
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}*'", "Nombre Departamento", "");
        }
    }
}
