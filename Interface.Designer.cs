namespace meteorite_falls
{
    partial class Interface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.data = new System.Windows.Forms.DataGridView();
            this.attribute = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.tbst = new System.Windows.Forms.TextBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.lbcat = new System.Windows.Forms.Label();
            this.lbst = new System.Windows.Forms.Label();
            this.lbra = new System.Windows.Forms.Label();
            this.lbto = new System.Windows.Forms.Label();
            this.barras = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.point = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.point)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).BeginInit();
            this.SuspendLayout();
            // 
            // map
            // 
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemmory = 5;
            this.map.Location = new System.Drawing.Point(600, 98);
            this.map.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 20;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(540, 390);
            this.map.TabIndex = 0;
            this.map.Zoom = 4D;
            this.map.Load += new System.EventHandler(this.gMap_Load);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(8, 98);
            this.data.Name = "data";
            this.data.RowHeadersWidth = 51;
            this.data.Size = new System.Drawing.Size(540, 390);
            this.data.TabIndex = 1;
            // 
            // attribute
            // 
            this.attribute.FormattingEnabled = true;
            this.attribute.Items.AddRange(new object[] {
            "Name",
            "ID",
            "Name Type",
            "Recclass",
            "Mass",
            "Fall",
            "Year"});
            this.attribute.Location = new System.Drawing.Point(87, 32);
            this.attribute.Name = "attribute";
            this.attribute.Size = new System.Drawing.Size(88, 21);
            this.attribute.TabIndex = 3;
            this.attribute.SelectedIndexChanged += new System.EventHandler(this.attribute_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "attribute";
            // 
            // cbcat
            // 
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Location = new System.Drawing.Point(87, 58);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(121, 21);
            this.cbcat.TabIndex = 6;
            this.cbcat.SelectedIndexChanged += new System.EventHandler(this.cbcat_SelectedIndexChanged);
            // 
            // tbst
            // 
            this.tbst.Location = new System.Drawing.Point(87, 58);
            this.tbst.Name = "tbst";
            this.tbst.Size = new System.Drawing.Size(100, 20);
            this.tbst.TabIndex = 7;
            this.tbst.TextChanged += new System.EventHandler(this.tbst_TextChanged);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(87, 58);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(42, 20);
            this.tbx1.TabIndex = 8;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(155, 58);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(42, 20);
            this.tbx2.TabIndex = 9;
            // 
            // lbcat
            // 
            this.lbcat.AutoSize = true;
            this.lbcat.Location = new System.Drawing.Point(10, 61);
            this.lbcat.Name = "lbcat";
            this.lbcat.Size = new System.Drawing.Size(52, 13);
            this.lbcat.TabIndex = 11;
            this.lbcat.Text = "Categorie";
            // 
            // lbst
            // 
            this.lbst.AutoSize = true;
            this.lbst.Location = new System.Drawing.Point(10, 61);
            this.lbst.Name = "lbst";
            this.lbst.Size = new System.Drawing.Size(34, 13);
            this.lbst.TabIndex = 12;
            this.lbst.Text = "String";
            // 
            // lbra
            // 
            this.lbra.AutoSize = true;
            this.lbra.Location = new System.Drawing.Point(10, 61);
            this.lbra.Name = "lbra";
            this.lbra.Size = new System.Drawing.Size(39, 13);
            this.lbra.TabIndex = 13;
            this.lbra.Text = "Range";
            // 
            // lbto
            // 
            this.lbto.AutoSize = true;
            this.lbto.Location = new System.Drawing.Point(134, 61);
            this.lbto.Name = "lbto";
            this.lbto.Size = new System.Drawing.Size(16, 13);
            this.lbto.TabIndex = 14;
            this.lbto.Text = "to";
            // 
            // barras
            // 
            chartArea1.Name = "ChartArea1";
            this.barras.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.barras.Legends.Add(legend1);
            this.barras.Location = new System.Drawing.Point(449, 504);
            this.barras.Name = "barras";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.barras.Series.Add(series1);
            this.barras.Size = new System.Drawing.Size(262, 179);
            this.barras.TabIndex = 15;
            this.barras.Text = "chart1";
            // 
            // point
            // 
            chartArea2.Name = "ChartArea1";
            this.point.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.point.Legends.Add(legend2);
            this.point.Location = new System.Drawing.Point(878, 504);
            this.point.Name = "point";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.point.Series.Add(series2);
            this.point.Size = new System.Drawing.Size(262, 179);
            this.point.TabIndex = 16;
            this.point.Text = "chart2";
            // 
            // pie
            // 
            chartArea3.Name = "ChartArea1";
            this.pie.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.pie.Legends.Add(legend3);
            this.pie.Location = new System.Drawing.Point(8, 504);
            this.pie.Name = "pie";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.pie.Series.Add(series3);
            this.pie.Size = new System.Drawing.Size(262, 179);
            this.pie.TabIndex = 17;
            this.pie.Text = "chart3";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.pie);
            this.Controls.Add(this.point);
            this.Controls.Add(this.barras);
            this.Controls.Add(this.lbto);
            this.Controls.Add(this.lbra);
            this.Controls.Add(this.lbst);
            this.Controls.Add(this.lbcat);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.tbst);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.attribute);
            this.Controls.Add(this.data);
            this.Controls.Add(this.map);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Interface";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.point)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.ComboBox attribute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.TextBox tbst;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.Label lbcat;
        private System.Windows.Forms.Label lbst;
        private System.Windows.Forms.Label lbra;
        private System.Windows.Forms.Label lbto;
        private System.Windows.Forms.DataVisualization.Charting.Chart barras;
        private System.Windows.Forms.DataVisualization.Charting.Chart point;
        private System.Windows.Forms.DataVisualization.Charting.Chart pie;
    }
}

