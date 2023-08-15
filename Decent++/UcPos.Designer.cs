
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_sample = new Guna.UI2.WinForms.Guna2DataGridView();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QTY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Out = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_sample)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_sample);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 704);
            this.panel2.TabIndex = 1;
            // 
            // dgv_sample
            // 
            this.dgv_sample.AllowUserToDeleteRows = false;
            this.dgv_sample.AllowUserToOrderColumns = true;
            this.dgv_sample.AllowUserToResizeColumns = false;
            this.dgv_sample.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_sample.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_sample.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_sample.ColumnHeadersHeight = 50;
            this.dgv_sample.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.prod,
            this.mea,
            this.QTY,
            this.prc,
            this.p,
            this.Out});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_sample.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_sample.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgv_sample.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_sample.Location = new System.Drawing.Point(0, 0);
            this.dgv_sample.Name = "dgv_sample";
            this.dgv_sample.RowHeadersVisible = false;
            this.dgv_sample.RowHeadersWidth = 51;
            this.dgv_sample.RowTemplate.Height = 24;
            this.dgv_sample.Size = new System.Drawing.Size(1071, 490);
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
    }
}
