using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace meteorite_falls.Model
{
	class DataManager
	{

		public DataManager()
		{
			Read();
		}

		private DataTable dt = new DataTable();
		private int columns;

		private void Read()
		{
			OpenFileDialog fd = new OpenFileDialog();
			if (fd.ShowDialog() == DialogResult.OK)
			{
				string file = fd.FileName;
				try
				{
					StreamReader sr = new StreamReader(file);
					string line;
					bool f = true;
					columns = 0;
					while ((line = sr.ReadLine()) != null)
					{
						string[] sl = line.Split(',');
						if (f == true)
						{
							for (int k = 0; k < sl.Length-1; k++)
							{
								dt.Columns.Add(sl[k].ToString().Replace('"',' ').Trim());
								columns++;
							}
							f = false;
						}
						else
						{ 
							dt.Rows.Add(Modify(sl));
						}
					}
				}
				catch (IOException)
				{

				}
			}
		}

		public string[] Modify(string[] a)
		{
			string[] b = new string[columns];
			for(int i = 0; i < columns; i++)
			{
				b[i] = a[i].ToString().Replace('"', ' ').Trim();
			}
			return b;
		}
		
		public int[,] count()
		{
            DataRow[] dr = dt.Select();
			int[,] n = new int[13,1];
			for(int i = 0; i < dr.Length; i++)
			{
                string fall = dr[i]["fall"].ToString();
                string year = dr[i]["year"].ToString();
                if (fall.Equals("Fell"))
                {
                    n[0, 0]++;
                }
                else if(fall.Equals("Found"))
                {
                    n[1, 0]++;
                }
                switch (year)
                {
					case "2000":
						n[2,0]++;
						break;

					case "2001":
                        n[3,0]++;
						break;

					case "2002":
						n[4,0]++;
						break;

					case "2003":
						n[5,0]++;
						break;

					case "2004":
						n[6,0]++;
						break;

					case "2005":
						n[7,0]++;
						break;

					case "2006":
						n[8,0]++;
						break;

					case "2007":
						n[9,0]++;
						break;

					case "2008":
						n[10,0]++;
						break;

					case "2009":
						n[11,0]++;
						break;

					case "2010":
						n[12,0]++;
						break;

				}
				
            }
			return n;
		}
		public DataTable GetDataTable()
		{
			return dt;
		}
	}
}
