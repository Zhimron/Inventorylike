
namespace Decent__
{
    partial class UcPos
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_sample = new Guna.UI2.WinForms.Guna2DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Out = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtcode = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtprod = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtqty = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbmeasurement = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_insert = new Guna.UI2.WinForms.Guna2Button();
            this.txtmeasure = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sample)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.guna2Button1);
            this.panel2.Controls.Add(this.guna2Panel1);
            this.panel2.Controls.Add(this.dgv_sample);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 704);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(0, 300);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(174, 72);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "LOAD";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dgv_sample
            // 
            this.dgv_sample.AllowUserToDeleteRows = false;
            this.dgv_sample.AllowUserToOrderColumns = true;
            this.dgv_sample.AllowUserToResizeColumns = false;
            this.dgv_sample.AllowUserToResizeRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgv_sample.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sample.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_sample.ColumnHeadersHeight = 50;
            this.dgv_sample.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.prod,
            this.mea,
            this.QTY,
            this.prc,
            this.p,
            this.Out});
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sample.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_sample.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_sample.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_sample.Location = new System.Drawing.Point(0, 0);
            this.dgv_sample.Name = "dgv_sample";
            this.dgv_sample.RowHeadersVisible = false;
            this.dgv_sample.RowHeadersWidth = 51;
            this.dgv_sample.RowTemplate.Height = 24;
            this.dgv_sample.Size = new System.Drawing.Size(1071, 300);
            this.dgv_sample.TabIndex = 0;
            this.dgv_sample.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_sample.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_sample.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_sample.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_sample.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_sample.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_sample.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_sample.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_sample.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_sample.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_sample.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_sample.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_sample.ThemeStyle.HeaderStyle.Height = 50;
            this.dgv_sample.ThemeStyle.ReadOnly = false;
            this.dgv_sample.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_sample.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_sample.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_sample.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_sample.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_sample.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_sample.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_sample.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_sample_CellContentClick);
            // 
            // code
            // 
            this.code.HeaderText = "Product_code";
            this.code.MinimumWidth = 6;
            this.code.Name = "code";
            // 
            // prod
            // 
            this.prod.HeaderText = "Product";
            this.prod.MinimumWidth = 6;
            this.prod.Name = "prod";
            // 
            // mea
            // 
            this.mea.HeaderText = "Measurement";
            this.mea.MinimumWidth = 6;
            this.mea.Name = "mea";
            // 
            // QTY
            // 
            this.QTY.HeaderText = "QTY";
            this.QTY.MinimumWidth = 6;
            this.QTY.Name = "QTY";
            // 
            // prc
            // 
            this.prc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.prc.HeaderText = "Price";
            this.prc.MinimumWidth = 6;
            this.prc.Name = "prc";
            this.prc.Width = 70;
            // 
            // p
            // 
            this.p.HeaderText = "Portioning";
            this.p.MinimumWidth = 6;
            this.p.Name = "p";
            this.p.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.p.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Out
            // 
            this.Out.HeaderText = "Out";
            this.Out.MinimumWidth = 6;
            this.Out.Name = "Out";
            this.Out.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Out.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtmeasure);
            this.guna2Panel1.Controls.Add(this.btn_insert);
            this.guna2Panel1.Controls.Add(this.cmbmeasurement);
            this.guna2Panel1.Controls.Add(this.txtprice);
            this.guna2Panel1.Controls.Add(this.txtqty);
            this.guna2Panel1.Controls.Add(this.txtprod);
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Controls.Add(this.txtcode);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel1.Location = new System.Drawing.Point(174, 300);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(897, 404);
            this.guna2Panel1.TabIndex = 3;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // txtcode
            // 
            this.txtcode.AutoRoundedCorners = true;
            this.txtcode.BorderRadius = 26;
            this.txtcode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcode.DefaultText = "";
            this.txtcode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcode.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtcode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcode.Location = new System.Drawing.Point(17, 111);
            this.txtcode.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtcode.Name = "txtcode";
            this.txtcode.PasswordChar = '\0';
            this.txtcode.PlaceholderText = "New Product Code";
            this.txtcode.SelectedText = "";
            this.txtcode.Size = new System.Drawing.Size(258, 55);
            this.txtcode.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(897, 88);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // txtprod
            // 
            this.txtprod.AutoRoundedCorners = true;
            this.txtprod.BorderRadius = 26;
            this.txtprod.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprod.DefaultText = "";
            this.txtprod.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprod.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprod.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprod.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprod.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprod.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtprod.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprod.Location = new System.Drawing.Point(17, 176);
            this.txtprod.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtprod.Name = "txtprod";
            this.txtprod.PasswordChar = '\0';
            this.txtprod.PlaceholderText = "New Product";
            this.txtprod.SelectedText = "";
            this.txtprod.Size = new System.Drawing.Size(258, 55);
            this.txtprod.TabIndex = 2;
            // 
            // txtqty
            // 
            this.txtqty.AutoRoundedCorners = true;
            this.txtqty.BorderRadius = 26;
            this.txtqty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtqty.DefaultText = "";
            this.txtqty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtqty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtqty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtqty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqty.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtqty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtqty.Location = new System.Drawing.Point(306, 111);
            this.txtqty.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtqty.Name = "txtqty";
            this.txtqty.PasswordChar = '\0';
            this.txtqty.PlaceholderText = "Qty";
            this.txtqty.SelectedText = "";
            this.txtqty.Size = new System.Drawing.Size(133, 55);
            this.txtqty.TabIndex = 3;
            // 
            // txtprice
            // 
            this.txtprice.AutoRoundedCorners = true;
            this.txtprice.BorderRadius = 26;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.Location = new System.Drawing.Point(306, 176);
            this.txtprice.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "Price";
            this.txtprice.SelectedText = "";
            this.txtprice.Size = new System.Drawing.Size(133, 55);
            this.txtprice.TabIndex = 4;
            // 
            // cmbmeasurement
            // 
            this.cmbmeasurement.BackColor = System.Drawing.Color.Transparent;
            this.cmbmeasurement.BorderRadius = 10;
            this.cmbmeasurement.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbmeasurement.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbmeasurement.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbmeasurement.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbmeasurement.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.cmbmeasurement.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbmeasurement.ItemHeight = 30;
            this.cmbmeasurement.Items.AddRange(new object[] {
            "Others"});
            this.cmbmeasurement.Location = new System.Drawing.Point(17, 251);
            this.cmbmeasurement.Name = "cmbmeasurement";
            this.cmbmeasurement.Size = new System.Drawing.Size(258, 36);
            this.cmbmeasurement.TabIndex = 5;
            this.cmbmeasurement.SelectedIndexChanged += new System.EventHandler(this.cmbmeasurement_SelectedIndexChanged);
            // 
            // btn_insert
            // 
            this.btn_insert.AutoRoundedCorners = true;
            this.btn_insert.BorderRadius = 33;
            this.btn_insert.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_insert.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_insert.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_insert.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_insert.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_insert.ForeColor = System.Drawing.Color.White;
            this.btn_insert.Location = new System.Drawing.Point(17, 309);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(258, 69);
            this.btn_insert.TabIndex = 4;
            this.btn_insert.Text = "Insert";
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txtmeasure
            // 
            this.txtmeasure.BorderThickness = 0;
            this.txtmeasure.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtmeasure.DefaultText = "";
            this.txtmeasure.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtmeasure.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtmeasure.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmeasure.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtmeasure.Enabled = false;
            this.txtmeasure.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmeasure.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtmeasure.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtmeasure.Location = new System.Drawing.Point(27, 253);
            this.txtmeasure.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtmeasure.Name = "txtmeasure";
            this.txtmeasure.PasswordChar = '\0';
            this.txtmeasure.PlaceholderText = "Measure";
            this.txtmeasure.SelectedText = "";
            this.txtmeasure.Size = new System.Drawing.Size(218, 36);
            this.txtmeasure.TabIndex = 6;
            this.txtmeasure.Visible = false;
            // 
            // UcPos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UcPos";
            this.Size = new System.Drawing.Size(1071, 704);
            this.Load += new System.EventHandler(this.UcPos_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sample)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_sample;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn mea;
        private System.Windows.Forms.DataGridViewTextBoxColumn QTY;
        private System.Windows.Forms.DataGridViewTextBoxColumn prc;
        private System.Windows.Forms.DataGridViewButtonColumn p;
        private System.Windows.Forms.DataGridViewButtonColumn Out;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtmeasure;
        private Guna.UI2.WinForms.Guna2Button btn_insert;
        private Guna.UI2.WinForms.Guna2ComboBox cmbmeasurement;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private Guna.UI2.WinForms.Guna2TextBox txtqty;
        private Guna.UI2.WinForms.Guna2TextBox txtprod;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtcode;
    }
}
