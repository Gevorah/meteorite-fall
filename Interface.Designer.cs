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
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.data = new System.Windows.Forms.DataGridView();
            this.attribute = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbcat = new System.Windows.Forms.ComboBox();
            this.tbst = new System.Windows.Forms.TextBox();
            this.tbx1 = new System.Windows.Forms.TextBox();
            this.tbx2 = new System.Windows.Forms.TextBox();
            this.lbcat = new System.Windows.Forms.Label();
            this.lbst = new System.Windows.Forms.Label();
            this.lbra = new System.Windows.Forms.Label();
            this.lbto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(466, 192);
            this.gMapControl1.Margin = new System.Windows.Forms.Padding(2);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(296, 217);
            this.gMapControl1.TabIndex = 0;
            this.gMapControl1.Zoom = 0D;
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(22, 192);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(413, 217);
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
            "Year",
            "Reclat",
            "Relong"});
            this.attribute.Location = new System.Drawing.Point(132, 94);
            this.attribute.Name = "attribute";
            this.attribute.Size = new System.Drawing.Size(88, 21);
            this.attribute.TabIndex = 3;
            this.attribute.SelectedIndexChanged += new System.EventHandler(this.attribute_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "attribute";
            // 
            // cbcat
            // 
            this.cbcat.FormattingEnabled = true;
            this.cbcat.Location = new System.Drawing.Point(132, 147);
            this.cbcat.Name = "cbcat";
            this.cbcat.Size = new System.Drawing.Size(121, 21);
            this.cbcat.TabIndex = 6;
            this.cbcat.SelectedIndexChanged += new System.EventHandler(this.cbcat_SelectedIndexChanged);
            // 
            // tbst
            // 
            this.tbst.Location = new System.Drawing.Point(356, 148);
            this.tbst.Name = "tbst";
            this.tbst.Size = new System.Drawing.Size(100, 20);
            this.tbst.TabIndex = 7;
            this.tbst.TextChanged += new System.EventHandler(this.tbst_TextChanged);
            // 
            // tbx1
            // 
            this.tbx1.Location = new System.Drawing.Point(591, 152);
            this.tbx1.Name = "tbx1";
            this.tbx1.Size = new System.Drawing.Size(42, 20);
            this.tbx1.TabIndex = 8;
            // 
            // tbx2
            // 
            this.tbx2.Location = new System.Drawing.Point(675, 154);
            this.tbx2.Name = "tbx2";
            this.tbx2.Size = new System.Drawing.Size(42, 20);
            this.tbx2.TabIndex = 9;
            // 
            // lbcat
            // 
            this.lbcat.AutoSize = true;
            this.lbcat.Location = new System.Drawing.Point(69, 155);
            this.lbcat.Name = "lbcat";
            this.lbcat.Size = new System.Drawing.Size(52, 13);
            this.lbcat.TabIndex = 11;
            this.lbcat.Text = "Categorie";
            // 
            // lbst
            // 
            this.lbst.AutoSize = true;
            this.lbst.Location = new System.Drawing.Point(316, 154);
            this.lbst.Name = "lbst";
            this.lbst.Size = new System.Drawing.Size(34, 13);
            this.lbst.TabIndex = 12;
            this.lbst.Text = "String";
            // 
            // lbra
            // 
            this.lbra.AutoSize = true;
            this.lbra.Location = new System.Drawing.Point(546, 154);
            this.lbra.Name = "lbra";
            this.lbra.Size = new System.Drawing.Size(39, 13);
            this.lbra.TabIndex = 13;
            this.lbra.Text = "Range";
            // 
            // lbto
            // 
            this.lbto.AutoSize = true;
            this.lbto.Location = new System.Drawing.Point(653, 154);
            this.lbto.Name = "lbto";
            this.lbto.Size = new System.Drawing.Size(16, 13);
            this.lbto.TabIndex = 14;
            this.lbto.Text = "to";
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(793, 420);
            this.Controls.Add(this.lbto);
            this.Controls.Add(this.lbra);
            this.Controls.Add(this.lbst);
            this.Controls.Add(this.lbcat);
            this.Controls.Add(this.tbx2);
            this.Controls.Add(this.tbx1);
            this.Controls.Add(this.tbst);
            this.Controls.Add(this.cbcat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.attribute);
            this.Controls.Add(this.data);
            this.Controls.Add(this.gMapControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Interface";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.ComboBox attribute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbcat;
        private System.Windows.Forms.TextBox tbst;
        private System.Windows.Forms.TextBox tbx1;
        private System.Windows.Forms.TextBox tbx2;
        private System.Windows.Forms.Label lbcat;
        private System.Windows.Forms.Label lbst;
        private System.Windows.Forms.Label lbra;
        private System.Windows.Forms.Label lbto;
    }
}

