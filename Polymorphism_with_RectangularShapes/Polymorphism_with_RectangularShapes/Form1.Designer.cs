namespace Polymorphism_with_RectangularShapes
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
            this.btnCreateRectPyramid = new System.Windows.Forms.Button();
            this.btnBox = new System.Windows.Forms.Button();
            this.btnCreateSquare = new System.Windows.Forms.Button();
            this.btnCreateRectangle = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnCreateCube = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateRectPyramid
            // 
            this.btnCreateRectPyramid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRectPyramid.Location = new System.Drawing.Point(425, 414);
            this.btnCreateRectPyramid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateRectPyramid.Name = "btnCreateRectPyramid";
            this.btnCreateRectPyramid.Size = new System.Drawing.Size(404, 43);
            this.btnCreateRectPyramid.TabIndex = 14;
            this.btnCreateRectPyramid.Text = "Create Rectangular Pyramid";
            this.btnCreateRectPyramid.UseVisualStyleBackColor = true;
            this.btnCreateRectPyramid.Click += new System.EventHandler(this.btnCreateRectPyramid_Click);
            // 
            // btnBox
            // 
            this.btnBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBox.Location = new System.Drawing.Point(425, 362);
            this.btnBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBox.Name = "btnBox";
            this.btnBox.Size = new System.Drawing.Size(404, 43);
            this.btnBox.TabIndex = 13;
            this.btnBox.Text = "Create Box";
            this.btnBox.UseVisualStyleBackColor = true;
            this.btnBox.Click += new System.EventHandler(this.btnBox_Click);
            // 
            // btnCreateSquare
            // 
            this.btnCreateSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSquare.Location = new System.Drawing.Point(13, 414);
            this.btnCreateSquare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateSquare.Name = "btnCreateSquare";
            this.btnCreateSquare.Size = new System.Drawing.Size(404, 43);
            this.btnCreateSquare.TabIndex = 12;
            this.btnCreateSquare.Text = "Create Square";
            this.btnCreateSquare.UseVisualStyleBackColor = true;
            this.btnCreateSquare.Click += new System.EventHandler(this.btnCreateSquare_Click);
            // 
            // btnCreateRectangle
            // 
            this.btnCreateRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRectangle.Location = new System.Drawing.Point(13, 362);
            this.btnCreateRectangle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateRectangle.Name = "btnCreateRectangle";
            this.btnCreateRectangle.Size = new System.Drawing.Size(404, 43);
            this.btnCreateRectangle.TabIndex = 11;
            this.btnCreateRectangle.Text = "Create Rectangle";
            this.btnCreateRectangle.UseVisualStyleBackColor = true;
            this.btnCreateRectangle.Click += new System.EventHandler(this.btnCreateRectangle_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(13, 14);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1123, 307);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Length";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 2;
            this.columnHeader3.Text = "Height";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.DisplayIndex = 3;
            this.columnHeader4.Text = "Perimeter";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.DisplayIndex = 4;
            this.columnHeader5.Text = "Area";
            this.columnHeader5.Width = 120;
            // 
            // columnHeader6
            // 
            this.columnHeader6.DisplayIndex = 5;
            this.columnHeader6.Text = "Volume";
            this.columnHeader6.Width = 120;
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 6;
            this.columnHeader7.Text = "Width";
            this.columnHeader7.Width = 90;
            // 
            // btnCreateCube
            // 
            this.btnCreateCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateCube.Location = new System.Drawing.Point(13, 467);
            this.btnCreateCube.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateCube.Name = "btnCreateCube";
            this.btnCreateCube.Size = new System.Drawing.Size(404, 43);
            this.btnCreateCube.TabIndex = 15;
            this.btnCreateCube.Text = "Create Cube";
            this.btnCreateCube.UseVisualStyleBackColor = true;
            this.btnCreateCube.Click += new System.EventHandler(this.btnCreateCube_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 537);
            this.Controls.Add(this.btnCreateCube);
            this.Controls.Add(this.btnCreateRectPyramid);
            this.Controls.Add(this.btnBox);
            this.Controls.Add(this.btnCreateSquare);
            this.Controls.Add(this.btnCreateRectangle);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateRectPyramid;
        private System.Windows.Forms.Button btnBox;
        private System.Windows.Forms.Button btnCreateSquare;
        private System.Windows.Forms.Button btnCreateRectangle;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btnCreateCube;
    }
}

