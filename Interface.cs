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
using meteorite_falls.Model;

namespace meteorite_falls
{
    public partial class Interface : Form
    {
        private DataManager dm;
        private DataTable dt;

        public Interface()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            dm = new DataManager();
            dt = dm.GetDataTable();
            data.DataSource = dt;
        }

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '{1}*'", "Nombre Departamento", "");
        }

    }
}
