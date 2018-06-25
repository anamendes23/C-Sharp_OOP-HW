namespace Exercise_3
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
            this.BtnDisplayAllStudents = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnGetStudentById = new System.Windows.Forms.Button();
            this.BtnRemoveStudentById = new System.Windows.Forms.Button();
            this.BtnAddGrade = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn10Points = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnCopyDictionaryToQueue = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BtnRemoveLastFromQueue = new System.Windows.Forms.Button();
            this.BtnRemoveBottomFromStack = new System.Windows.Forms.Button();
            this.BtnConvertQueueToStack = new System.Windows.Forms.Button();
            this.BtnCopyDicToOtherDic = new System.Windows.Forms.Button();
            this.BtnCopyDicToQueue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDisplayAllStudents
            // 
            this.BtnDisplayAllStudents.Location = new System.Drawing.Point(23, 369);
            this.BtnDisplayAllStudents.Name = "BtnDisplayAllStudents";
            this.BtnDisplayAllStudents.Size = new System.Drawing.Size(240, 47);
            this.BtnDisplayAllStudents.TabIndex = 1;
            this.BtnDisplayAllStudents.Text = "Display Students";
            this.BtnDisplayAllStudents.UseVisualStyleBackColor = true;
            this.BtnDisplayAllStudents.Click += new System.EventHandler(this.BtnDisplayAllStudents_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(290, 369);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 26);
            this.textBox1.TabIndex = 2;
            // 
            // BtnGetStudentById
            // 
            this.BtnGetStudentById.Location = new System.Drawing.Point(290, 415);
            this.BtnGetStudentById.Name = "BtnGetStudentById";
            this.BtnGetStudentById.Size = new System.Drawing.Size(212, 47);
            this.BtnGetStudentById.TabIndex = 3;
            this.BtnGetStudentById.Text = "Get Student By Id";
            this.BtnGetStudentById.UseVisualStyleBackColor = true;
            this.BtnGetStudentById.Click += new System.EventHandler(this.BtnGetStudentById_Click);
            // 
            // BtnRemoveStudentById
            // 
            this.BtnRemoveStudentById.Location = new System.Drawing.Point(290, 477);
            this.BtnRemoveStudentById.Name = "BtnRemoveStudentById";
            this.BtnRemoveStudentById.Size = new System.Drawing.Size(212, 47);
            this.BtnRemoveStudentById.TabIndex = 4;
            this.BtnRemoveStudentById.Text = "Remove Student By Id";
            this.BtnRemoveStudentById.UseVisualStyleBackColor = true;
            this.BtnRemoveStudentById.Click += new System.EventHandler(this.BtnRemoveStudentById_Click);
            // 
            // BtnAddGrade
            // 
            this.BtnAddGrade.Location = new System.Drawing.Point(540, 415);
            this.BtnAddGrade.Name = "BtnAddGrade";
            this.BtnAddGrade.Size = new System.Drawing.Size(240, 95);
            this.BtnAddGrade.TabIndex = 5;
            this.BtnAddGrade.Text = "Add Grade to Selected Student";
            this.BtnAddGrade.UseVisualStyleBackColor = true;
            this.BtnAddGrade.Click += new System.EventHandler(this.BtnAddGrade_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(540, 369);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(240, 26);
            this.textBox2.TabIndex = 6;
            // 
            // Btn10Points
            // 
            this.Btn10Points.Location = new System.Drawing.Point(813, 369);
            this.Btn10Points.Name = "Btn10Points";
            this.Btn10Points.Size = new System.Drawing.Size(240, 95);
            this.Btn10Points.TabIndex = 7;
            this.Btn10Points.Text = "Add 10 points to lowest Grade of Selected Student";
            this.Btn10Points.UseVisualStyleBackColor = true;
            this.Btn10Points.Click += new System.EventHandler(this.Btn10Points_Click);
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
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(23, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1045, 323);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Average";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Grade 1";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Grade 2";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Grade 3";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Grade 4";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Grade 5";
            // 
            // BtnCopyDictionaryToQueue
            // 
            this.BtnCopyDictionaryToQueue.Location = new System.Drawing.Point(23, 429);
            this.BtnCopyDictionaryToQueue.Name = "BtnCopyDictionaryToQueue";
            this.BtnCopyDictionaryToQueue.Size = new System.Drawing.Size(240, 95);
            this.BtnCopyDictionaryToQueue.TabIndex = 9;
            this.BtnCopyDictionaryToQueue.Text = "Pass Students from Dictionary to Queue and Display Queue";
            this.BtnCopyDictionaryToQueue.UseVisualStyleBackColor = true;
            this.BtnCopyDictionaryToQueue.Click += new System.EventHandler(this.BtnCopyDictionaryToQueue_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnCopyDicToQueue);
            this.groupBox1.Controls.Add(this.BtnCopyDicToOtherDic);
            this.groupBox1.Controls.Add(this.BtnConvertQueueToStack);
            this.groupBox1.Controls.Add(this.BtnRemoveBottomFromStack);
            this.groupBox1.Controls.Add(this.BtnRemoveLastFromQueue);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(1101, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 502);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extra tests";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(25, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(456, 154);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // BtnRemoveLastFromQueue
            // 
            this.BtnRemoveLastFromQueue.Location = new System.Drawing.Point(25, 224);
            this.BtnRemoveLastFromQueue.Name = "BtnRemoveLastFromQueue";
            this.BtnRemoveLastFromQueue.Size = new System.Drawing.Size(214, 62);
            this.BtnRemoveLastFromQueue.TabIndex = 1;
            this.BtnRemoveLastFromQueue.Text = "Remove Last Item from Queue";
            this.BtnRemoveLastFromQueue.UseVisualStyleBackColor = true;
            this.BtnRemoveLastFromQueue.Click += new System.EventHandler(this.BtnRemoveLastFromQueue_Click);
            // 
            // BtnRemoveBottomFromStack
            // 
            this.BtnRemoveBottomFromStack.Location = new System.Drawing.Point(269, 224);
            this.BtnRemoveBottomFromStack.Name = "BtnRemoveBottomFromStack";
            this.BtnRemoveBottomFromStack.Size = new System.Drawing.Size(212, 62);
            this.BtnRemoveBottomFromStack.TabIndex = 2;
            this.BtnRemoveBottomFromStack.Text = "Remove Bottom Item from Stack";
            this.BtnRemoveBottomFromStack.UseVisualStyleBackColor = true;
            this.BtnRemoveBottomFromStack.Click += new System.EventHandler(this.BtnRemoveBottomFromStack_Click);
            // 
            // BtnConvertQueueToStack
            // 
            this.BtnConvertQueueToStack.Location = new System.Drawing.Point(147, 311);
            this.BtnConvertQueueToStack.Name = "BtnConvertQueueToStack";
            this.BtnConvertQueueToStack.Size = new System.Drawing.Size(214, 62);
            this.BtnConvertQueueToStack.TabIndex = 3;
            this.BtnConvertQueueToStack.Text = "Convert Queue to Stack";
            this.BtnConvertQueueToStack.UseVisualStyleBackColor = true;
            this.BtnConvertQueueToStack.Click += new System.EventHandler(this.BtnConvertQueueToStack_Click);
            // 
            // BtnCopyDicToOtherDic
            // 
            this.BtnCopyDicToOtherDic.Location = new System.Drawing.Point(25, 393);
            this.BtnCopyDicToOtherDic.Name = "BtnCopyDicToOtherDic";
            this.BtnCopyDicToOtherDic.Size = new System.Drawing.Size(214, 62);
            this.BtnCopyDicToOtherDic.TabIndex = 4;
            this.BtnCopyDicToOtherDic.Text = "Copy Student Dictionary to Other Dictionary";
            this.BtnCopyDicToOtherDic.UseVisualStyleBackColor = true;
            this.BtnCopyDicToOtherDic.Click += new System.EventHandler(this.BtnCopyDicToOtherDic_Click);
            // 
            // BtnCopyDicToQueue
            // 
            this.BtnCopyDicToQueue.Location = new System.Drawing.Point(256, 393);
            this.BtnCopyDicToQueue.Name = "BtnCopyDicToQueue";
            this.BtnCopyDicToQueue.Size = new System.Drawing.Size(214, 62);
            this.BtnCopyDicToQueue.TabIndex = 5;
            this.BtnCopyDicToQueue.Text = "Copy Student Dictionary to Queue";
            this.BtnCopyDicToQueue.UseVisualStyleBackColor = true;
            this.BtnCopyDicToQueue.Click += new System.EventHandler(this.BtnCopyDicToQueue_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1633, 583);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtnCopyDictionaryToQueue);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Btn10Points);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.BtnAddGrade);
            this.Controls.Add(this.BtnRemoveStudentById);
            this.Controls.Add(this.BtnGetStudentById);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BtnDisplayAllStudents);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnDisplayAllStudents;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnGetStudentById;
        private System.Windows.Forms.Button BtnRemoveStudentById;
        private System.Windows.Forms.Button BtnAddGrade;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Btn10Points;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Button BtnCopyDictionaryToQueue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnRemoveBottomFromStack;
        private System.Windows.Forms.Button BtnRemoveLastFromQueue;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button BtnConvertQueueToStack;
        private System.Windows.Forms.Button BtnCopyDicToQueue;
        private System.Windows.Forms.Button BtnCopyDicToOtherDic;
    }
}

