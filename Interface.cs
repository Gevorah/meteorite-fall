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
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;
using meteorite_falls.Model;

namespace meteorite_falls
{
    public partial class Interface : Form
    {
        private DataManager dm;
        private DataTable dt;
        private List<PointLatLng> points;
        private List<PointLatLng> polygs;
        GMapOverlay markers = new GMapOverlay("markers");
        GMapOverlay polygons = new GMapOverlay("polygons");

        public Interface()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            dm = new DataManager();
            dt = dm.GetDataTable();
            points = new List<PointLatLng>();
            polygs = new List<PointLatLng>();
            data.DataSource = dt;
            lbcat.Visible = false;
            cbcat.Visible = false;
            lbst.Visible = false;
            tbst.Visible = false;
            lbto.Visible = false;
            lbra.Visible = false;
            tbx1.Visible = false;
            tbx2.Visible = false;
            AddPoints();
            setMarkers();
        }

        private void gMap_Load(object sender, EventArgs e)
        {
            map.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            map.Overlays.Add(markers);
            map.Overlays.Add(polygons);
        }

        private void setMarkers()
        {
            foreach (PointLatLng p in points)
            {
                GMapMarker marker = new GMarkerGoogle(p, GMarkerGoogleType.red_dot);
                markers.Markers.Add(marker);
            }
        }
        private void setPolygons()
        {
            GMapPolygon polygon = new GMapPolygon(polygs, "Polygon");

            polygon.Fill = new SolidBrush(Color.FromArgb(50, Color.Red));
            polygon.Stroke = new Pen(Color.Red, 1);
            polygons.Polygons.Add(polygon);
        }

        private void AddPoints()
        {
            DataRow[] dr = dt.Select();
            for (int i = 0; i < dr.Length; i++)
            {
                string lat = dr[i]["reclat"].ToString();
                string lng = dr[i]["reclong"].ToString();
                if(!lat.Equals("NA") && !lng.Equals("NA"))
                points.Add(new PointLatLng(Convert.ToDouble(lat),Convert.ToDouble(lng)));
            }
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
            else if (selected.Equals("Name") || selected.Equals("ID") || selected.Equals("Recclass"))
            {
                lbcat.Visible = false;
                cbcat.Visible = false;
                lbst.Visible = true;
                tbst.Visible = true;
                lbto.Visible = false;
                lbra.Visible = false;
                tbx1.Visible = false;
                tbx2.Visible = false;


            }
            else if (selected.Equals("Mass") || selected.Equals("Year"))
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
            string s = attribute.Text;
            try
            {
                if (s.Equals("Mass"))
                {
                    if (Int32.Parse(tbx1.Text) >= 0)
                    {
                        dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') > '{1}'", "mass", Int32.Parse(tbx1.Text) - 1);
                        if (!tbx2.Text.Equals(""))
                        {
                            dt.DefaultView.RowFilter = string.Format("Convert([{0}], 'System.String') < '{1}'", "mass", Int32.Parse(tbx2.Text) + 1);
                        }
                    }
                    else
                    {
                        throw new ArgumentException("Less");
                    }
                }
                else if (s.Equals("Year"))
                {
                    if (Int32.Parse(tbx1.Text) >= 2000)
                    {

                    }
                    else
                    {
                        throw new ArgumentException("Less");
                    }
                }

            }
            catch (Exception)
            {

            }
        }
        private void RangeFilter()
        {

        }

        private void tbx2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(tbx2.Text) <= 2010)
                {

                }
                else
                {
                    throw new ArgumentException("More");
                }

            }
            catch (IOException)
            { }
        }
    }
}
