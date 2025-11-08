namespace TimeSeriesForm
{
    partial class TimeSeriesFrm
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
            this.dgvForecast = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvForecast)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvForecast
            // 
            this.dgvForecast.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvForecast.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvForecast.Location = new System.Drawing.Point(0, 0);
            this.dgvForecast.Name = "dgvForecast";
            this.dgvForecast.ReadOnly = true;
            this.dgvForecast.RowHeadersWidth = 62;
            this.dgvForecast.RowTemplate.Height = 28;
            this.dgvForecast.Size = new System.Drawing.Size(546, 327);
            this.dgvForecast.TabIndex = 0;
            // 
            // TimeSeriesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 327);
            this.Controls.Add(this.dgvForecast);
            this.Name = "TimeSeriesFrm";
            this.Text = "TimeSeriesFrm";
            this.Shown += new System.EventHandler(this.TimeSeriesFrm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvForecast)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvForecast;
    }
}

