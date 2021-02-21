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
			lbcat.Visible = false;
			cbcat.Visible = false;
			lbst.Visible = false;
			tbst.Visible = false;
			lbto.Visible = false;
			lbra.Visible = false;
			tbx1.Visible = false;
			tbx2.Visible = false;
		}


		private void attribute_SelectedIndexChanged(object sender, EventArgs e)
		{
			string selected = attribute.Text;
			if (selected.Equals("Name Type") || selected.Equals("Fall"))
			{
                Categories(selected);
				lbcat.Visible = true;
				cbcat.Visible = true;
				lbst.Visible = false;
				tbst.Visible = false;
				lbto.Visible = false;
				lbra.Visible = false;
				tbx1.Visible = false;
				tbx2.Visible = false;
			}
			else if (selected.Equals ("Name" )|| selected.Equals("ID")|| selected.Equals("Recclass"))
			{
				lbcat.Visible = false;
				cbcat.Visible = false;
				lbst.Visible = true;
				tbst.Visible = true;
				lbto.Visible = false;
				lbra.Visible = false;
				tbx1.Visible = false;
				tbx2.Visible = false;
				

			} else if (selected.Equals("Mass") || selected.Equals("Year") || selected.Equals("Reclat") || selected.Equals("Reclong"))
			{
				lbcat.Visible = false;
				cbcat.Visible = false;
				lbst.Visible = false;
				tbst.Visible = false;
				lbto.Visible = true;
				lbra.Visible = true;
				tbx1.Visible = true;
				tbx2.Visible = true;
			}
		}

		private void Categories(string s)
		{
			if (s.Equals("Name Type"))
			{
				cbcat.Items.Clear();
				cbcat.Items.Add("Valid");
				cbcat.Items.Add("Relict");
			}
			else if (s.Equals("Fall"))
			{
				cbcat.Items.Clear();
				cbcat.Items.Add("Fell");
				cbcat.Items.Add("Found");

			}

		}

        private void cbcat_SelectedIndexChanged(object sender, EventArgs e)
        {
			string s = cbcat.Text;
			if (s.Equals("Valid"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "nametype", cbcat.Text);
			}
			else if (s.Equals("Relict"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "nametype", cbcat.Text);
			}
			else if (s.Equals("Fell"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "fall", cbcat.Text);
			}
			else if (s.Equals("Found"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "fall", cbcat.Text);
			}
		}

        private void tbst_TextChanged(object sender, EventArgs e)
        {
			string s = attribute.Text;
			if (s.Equals("Name"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "name", tbst.Text);
			}
			else if (s.Equals("ID"))
			{
                dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "id", tbst.Text);
            }
			else if (s.Equals("Recclass"))
			{
				dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "recclass", tbst.Text);
            }
           
        }


		private void tbx1_SelectedIndexChanged(object sender, EventArgs e)
        { 
			
		}

        private void tbx2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
