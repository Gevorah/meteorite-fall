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
using System.Windows.Forms.DataVisualization.Charting;

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
			AddPoints("");
			Graphics();
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

		private void AddPoints(string filter)
		{
            deletePoints();
			DataRow[] dr = dt.Select(filter);
			for (int i = 0; i < dr.Length; i++)
			{
				string lat = dr[i]["reclat"].ToString();
				string lng = dr[i]["reclong"].ToString();
				if (!lat.Equals("NA") && !lng.Equals("NA"))
					points.Add(new PointLatLng(Convert.ToDouble(lat), Convert.ToDouble(lng)));
			}
            setMarkers();
		}

		private void deletePoints()
		{
			points.Clear();
			markers.Clear();
            polygs.Clear();
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
                string filter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "nametype", cbcat.Text);
				dt.DefaultView.RowFilter = filter;
                AddPoints(filter);
			}
			else if (s.Equals("Relict"))
			{
                string filter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "nametype", cbcat.Text);
				dt.DefaultView.RowFilter = filter;
                AddPoints(filter);
            }
			else if (s.Equals("Fell"))
			{
                string filter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "fall", cbcat.Text);
				dt.DefaultView.RowFilter = filter;
                AddPoints(filter);
            }
			else if (s.Equals("Found"))
			{
                string filter = string.Format("Convert([{0}], 'System.String') IN ('{1}')", "fall", cbcat.Text);
				dt.DefaultView.RowFilter = filter;
                AddPoints(filter);
            }
		}

		private void tbst_TextChanged(object sender, EventArgs e)
		{
			string s = attribute.Text;
			if (s.Equals("Name"))
			{
                string filter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "name", tbst.Text);
				dt.DefaultView.RowFilter = filter;
                AddPoints(filter);
            }
			else if (s.Equals("ID"))
			{
                string filter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "id", tbst.Text);
				dt.DefaultView.RowFilter = filter;
                AddPoints(filter);
            }
			else if (s.Equals("Recclass"))
			{
                string filter = string.Format("Convert([{0}], 'System.String') LIKE '%{1}%'", "recclass", tbst.Text);
				dt.DefaultView.RowFilter = filter;
                AddPoints(filter);
            }

		}


		private void tbx1_TextChanged(object sender, EventArgs e)
		{
			string s = attribute.Text;
			if (s.Equals("Year"))
			{
				if (tbx2.Text.Equals(""))
				{
					string filter = string.Format("Convert([{0}], 'System.String') >= '{1}'", "year", int.Parse(tbx1.Text)); dt.DefaultView.RowFilter = filter;
					AddPoints(filter);
				}
				else
				{
					string filter = string.Format("Convert([{0}], 'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "year", int.Parse(tbx1.Text), int.Parse(tbx2.Text));
					dt.DefaultView.RowFilter = filter;
					AddPoints(filter);
				}
			}

		}
	

		private void tbx2_TextChanged(object sender, EventArgs e)
		{
			string s = attribute.Text;
			if (s.Equals("Year")){
				if (tbx1.Text.Equals(""))
				{
					string filter = string.Format("Convert([{0}], 'System.String') <= '{1}'", "year", int.Parse(tbx2.Text)); dt.DefaultView.RowFilter = filter;
					AddPoints(filter);
				}
				else
				{
					string filter = string.Format("Convert([{0}], 'System.String') >= '{1}' AND Convert([{0}], 'System.String') <= '{2}'", "year", int.Parse(tbx1.Text), int.Parse(tbx2.Text));
					dt.DefaultView.RowFilter = filter;
					AddPoints(filter);
				}
			}

		}



		private void Graphics()
		{
			PieChart();
			BarChart();
			PointsChart();
		}

		private void BarChart() 
		{
			barras.Series.Clear();
			barras.Legends.Clear();

			//Add a new Legend(if needed) and do some formating
			barras.Legends.Add("Year");
			barras.Legends[0].LegendStyle = LegendStyle.Table;
			barras.Legends[0].Docking = Docking.Bottom;
			barras.Legends[0].Alignment = StringAlignment.Center;
			barras.Legends[0].Title = "Year";
			barras.Legends[0].BorderColor = Color.Black;

			//Add a new chart-series
			string seriesname = "Year";
			barras.Series.Add(seriesname);
			//set the chart-type to "Pie"
			barras.Series[seriesname].ChartType = SeriesChartType.Bar;
			barras.Series[seriesname]["BarLabelStyle"] = "Disabled";

			//Add some datapoints so the series. in this case you can pass the values to this method
			barras.Series[seriesname].Points.AddXY("2000", dm.count()[2, 0]);
			barras.Series[seriesname].Points.AddXY("2001", dm.count()[3, 0]);
			barras.Series[seriesname].Points.AddXY("2002", dm.count()[4, 0]);
			barras.Series[seriesname].Points.AddXY("2003", dm.count()[5, 0]);
			barras.Series[seriesname].Points.AddXY("2004", dm.count()[6, 0]);
			barras.Series[seriesname].Points.AddXY("2005", dm.count()[7, 0]);
			barras.Series[seriesname].Points.AddXY("2006", dm.count()[8, 0]);
			barras.Series[seriesname].Points.AddXY("2007", dm.count()[9, 0]);
			barras.Series[seriesname].Points.AddXY("2008", dm.count()[10, 0]);
			barras.Series[seriesname].Points.AddXY("2009", dm.count()[11, 0]);
			barras.Series[seriesname].Points.AddXY("2010", dm.count()[12, 0]);
			
		}



		private void PieChart()
		{
			pie.Series.Clear();
			pie.Legends.Clear();

			//Add a new Legend(if needed) and do some formating
			pie.Legends.Add("Fall Type");
			pie.Legends[0].LegendStyle = LegendStyle.Table;
			pie.Legends[0].Docking = Docking.Bottom;
			pie.Legends[0].Alignment = StringAlignment.Center;
			pie.Legends[0].Title = "Fall Type";
			pie.Legends[0].BorderColor = Color.Black;

			//Add a new chart-series
			string seriesname = "Fall Type";
			pie.Series.Add(seriesname);
			//set the chart-type to "Pie"
			pie.Series[seriesname].ChartType = SeriesChartType.Pie;
			pie.Series[seriesname]["PieLabelStyle"] = "Disabled";

			//Add some datapoints so the series. in this case you can pass the values to this method
			pie.Series[seriesname].Points.AddXY("Fell", dm.count()[0, 0]);
			pie.Series[seriesname].Points.AddXY("Found", dm.count()[1, 0]);
		}

		private void PointsChart()
		{
			point.Series.Clear();
			point.Legends.Clear();

			//Add a new Legend(if needed) and do some formating
			point.Legends.Add("Year");
			point.Legends[0].LegendStyle = LegendStyle.Table;
			point.Legends[0].Docking = Docking.Bottom;
			point.Legends[0].Alignment = StringAlignment.Center;
			point.Legends[0].Title = "Year";
			point.Legends[0].BorderColor = Color.Black;

			//Add a new chart-series
			string seriesname = "Year";
			point.Series.Add(seriesname);
			//set the chart-type to "Pie"
			point.Series[seriesname].ChartType = SeriesChartType.Point;
			point.Series[seriesname]["PointLabelStyle"] = "Disabled";

			//Add some datapoints so the series. in this case you can pass the values to this method
			point.Series[seriesname].Points.AddXY("2000", dm.count()[2, 0]);
			point.Series[seriesname].Points.AddXY("2001", dm.count()[3, 0]);
			point.Series[seriesname].Points.AddXY("2002", dm.count()[4, 0]);
			point.Series[seriesname].Points.AddXY("2003", dm.count()[5, 0]);
			point.Series[seriesname].Points.AddXY("2004", dm.count()[6, 0]);
			point.Series[seriesname].Points.AddXY("2005", dm.count()[7, 0]);
			point.Series[seriesname].Points.AddXY("2006", dm.count()[8, 0]);
			point.Series[seriesname].Points.AddXY("2007", dm.count()[9, 0]);
			point.Series[seriesname].Points.AddXY("2008", dm.count()[10, 0]);
			point.Series[seriesname].Points.AddXY("2009", dm.count()[11, 0]);
			point.Series[seriesname].Points.AddXY("2010", dm.count()[12, 0]);

		}
	}
}
