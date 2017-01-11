namespace SIKost
{
    partial class SIKost
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridViewTenant = new System.Windows.Forms.DataGridView();
            this.dataGridViewLocation = new System.Windows.Forms.DataGridView();
            this.groupBoxLocation = new System.Windows.Forms.GroupBox();
            this.groupBoxTenant = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).BeginInit();
            this.groupBoxLocation.SuspendLayout();
            this.groupBoxTenant.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxLocation);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxTenant);
            this.splitContainer1.Size = new System.Drawing.Size(592, 421);
            this.splitContainer1.SplitterDistance = 210;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridViewTenant
            // 
            this.dataGridViewTenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTenant.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewTenant.Name = "dataGridViewTenant";
            this.dataGridViewTenant.RowTemplate.Height = 24;
            this.dataGridViewTenant.Size = new System.Drawing.Size(586, 186);
            this.dataGridViewTenant.TabIndex = 0;
            // 
            // dataGridViewLocation
            // 
            this.dataGridViewLocation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLocation.Location = new System.Drawing.Point(3, 18);
            this.dataGridViewLocation.Name = "dataGridViewLocation";
            this.dataGridViewLocation.RowTemplate.Height = 24;
            this.dataGridViewLocation.Size = new System.Drawing.Size(586, 189);
            this.dataGridViewLocation.TabIndex = 0;
            // 
            // groupBoxLocation
            // 
            this.groupBoxLocation.Controls.Add(this.dataGridViewLocation);
            this.groupBoxLocation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLocation.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLocation.Name = "groupBoxLocation";
            this.groupBoxLocation.Size = new System.Drawing.Size(592, 210);
            this.groupBoxLocation.TabIndex = 2;
            this.groupBoxLocation.TabStop = false;
            this.groupBoxLocation.Text = "Location";
            // 
            // groupBoxTenant
            // 
            this.groupBoxTenant.Controls.Add(this.dataGridViewTenant);
            this.groupBoxTenant.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxTenant.Location = new System.Drawing.Point(0, 0);
            this.groupBoxTenant.Name = "groupBoxTenant";
            this.groupBoxTenant.Size = new System.Drawing.Size(592, 207);
            this.groupBoxTenant.TabIndex = 1;
            this.groupBoxTenant.TabStop = false;
            this.groupBoxTenant.Text = "Tenant";
            // 
            // SIKost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 421);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SIKost";
            this.Text = "SIKost";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTenant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLocation)).EndInit();
            this.groupBoxLocation.ResumeLayout(false);
            this.groupBoxTenant.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridViewTenant;
        private System.Windows.Forms.GroupBox groupBoxLocation;
        private System.Windows.Forms.DataGridView dataGridViewLocation;
        private System.Windows.Forms.GroupBox groupBoxTenant;
    }
}

