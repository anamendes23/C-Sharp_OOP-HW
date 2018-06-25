namespace Exercise_1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnLion = new System.Windows.Forms.Button();
            this.BtnElephant = new System.Windows.Forms.Button();
            this.BtnWhale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(83, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(305, 247);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(83, 328);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(305, 96);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // BtnLion
            // 
            this.BtnLion.Location = new System.Drawing.Point(422, 63);
            this.BtnLion.Name = "BtnLion";
            this.BtnLion.Size = new System.Drawing.Size(127, 54);
            this.BtnLion.TabIndex = 2;
            this.BtnLion.Text = "Lion";
            this.BtnLion.UseVisualStyleBackColor = true;
            this.BtnLion.Click += new System.EventHandler(this.BtnLion_Click);
            // 
            // BtnElephant
            // 
            this.BtnElephant.Location = new System.Drawing.Point(422, 136);
            this.BtnElephant.Name = "BtnElephant";
            this.BtnElephant.Size = new System.Drawing.Size(127, 54);
            this.BtnElephant.TabIndex = 3;
            this.BtnElephant.Text = "Elephant";
            this.BtnElephant.UseVisualStyleBackColor = true;
            this.BtnElephant.Click += new System.EventHandler(this.BtnElephant_Click);
            // 
            // BtnWhale
            // 
            this.BtnWhale.Location = new System.Drawing.Point(422, 210);
            this.BtnWhale.Name = "BtnWhale";
            this.BtnWhale.Size = new System.Drawing.Size(127, 54);
            this.BtnWhale.TabIndex = 4;
            this.BtnWhale.Text = "Whale";
            this.BtnWhale.UseVisualStyleBackColor = true;
            this.BtnWhale.Click += new System.EventHandler(this.BtnWhale_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnWhale);
            this.Controls.Add(this.BtnElephant);
            this.Controls.Add(this.BtnLion);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnLion;
        private System.Windows.Forms.Button BtnElephant;
        private System.Windows.Forms.Button BtnWhale;
    }
}

