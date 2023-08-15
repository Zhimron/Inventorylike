
namespace Decent__
{
    partial class Ucproduct
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
            this.lblprod = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblprod
            // 
            this.lblprod.AutoSize = true;
            this.lblprod.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprod.Location = new System.Drawing.Point(20, 24);
            this.lblprod.Name = "lblprod";
            this.lblprod.Size = new System.Drawing.Size(67, 20);
            this.lblprod.TabIndex = 0;
            this.lblprod.Text = "Product";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.Location = new System.Drawing.Point(20, 67);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(46, 20);
            this.lblprice.TabIndex = 1;
            this.lblprice.Text = "Price";
            // 
            // Ucproduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblprice);
            this.Controls.Add(this.lblprod);
            this.Name = "Ucproduct";
            this.Size = new System.Drawing.Size(304, 119);
            this.Load += new System.EventHandler(this.Ucproduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprod;
        private System.Windows.Forms.Label lblprice;
    }
}
