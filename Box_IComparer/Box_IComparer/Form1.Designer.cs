namespace Box_IComparer
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.BtnSortByVolume = new System.Windows.Forms.Button();
            this.BtnSortByArea = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(48, 38);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(525, 311);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // BtnSortByVolume
            // 
            this.BtnSortByVolume.Location = new System.Drawing.Point(604, 73);
            this.BtnSortByVolume.Name = "BtnSortByVolume";
            this.BtnSortByVolume.Size = new System.Drawing.Size(213, 38);
            this.BtnSortByVolume.TabIndex = 1;
            this.BtnSortByVolume.Text = "Sort by Volume";
            this.BtnSortByVolume.UseVisualStyleBackColor = true;
            this.BtnSortByVolume.Click += new System.EventHandler(this.BtnSortByVolume_Click);
            // 
            // BtnSortByArea
            // 
            this.BtnSortByArea.Location = new System.Drawing.Point(604, 141);
            this.BtnSortByArea.Name = "BtnSortByArea";
            this.BtnSortByArea.Size = new System.Drawing.Size(213, 38);
            this.BtnSortByArea.TabIndex = 2;
            this.BtnSortByArea.Text = "Sort by Area";
            this.BtnSortByArea.UseVisualStyleBackColor = true;
            this.BtnSortByArea.Click += new System.EventHandler(this.BtnSortByArea_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Length";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Width";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Height";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Volume";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Area";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 465);
            this.Controls.Add(this.BtnSortByArea);
            this.Controls.Add(this.BtnSortByVolume);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button BtnSortByVolume;
        private System.Windows.Forms.Button BtnSortByArea;
    }
}

