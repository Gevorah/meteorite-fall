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
								dt.Columns.Add(sl[k]);
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
				b[i] = a[i];
            }
			return b;
        }

		public DataTable GetDataTable()
		{
			return dt;
		}
	}
}
