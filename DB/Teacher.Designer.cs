namespace DB
{
    partial class BtnLesson
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnPrepod = new System.Windows.Forms.Button();
            this.BtnTeacher = new System.Windows.Forms.Button();
            this.BtnObject = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnClassLesson = new System.Windows.Forms.Button();
            this.BtnLessonVid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(889, 379);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btnPrepod);
            this.groupBox1.Controls.Add(this.BtnTeacher);
            this.groupBox1.Controls.Add(this.BtnObject);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(914, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(150, 159);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод и редактирование данных";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 132);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 19);
            this.button2.TabIndex = 8;
            this.button2.Text = "Классы учителей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPrepod
            // 
            this.btnPrepod.Location = new System.Drawing.Point(0, 109);
            this.btnPrepod.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrepod.Name = "btnPrepod";
            this.btnPrepod.Size = new System.Drawing.Size(150, 19);
            this.btnPrepod.TabIndex = 0;
            this.btnPrepod.Text = "Преподаёт";
            this.btnPrepod.UseVisualStyleBackColor = true;
            this.btnPrepod.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnTeacher
            // 
            this.BtnTeacher.Location = new System.Drawing.Point(0, 85);
            this.BtnTeacher.Margin = new System.Windows.Forms.Padding(2);
            this.BtnTeacher.Name = "BtnTeacher";
            this.BtnTeacher.Size = new System.Drawing.Size(150, 19);
            this.BtnTeacher.TabIndex = 7;
            this.BtnTeacher.Text = "Учитель";
            this.BtnTeacher.UseVisualStyleBackColor = true;
            this.BtnTeacher.Click += new System.EventHandler(this.BtnTeacher_Click);
            // 
            // BtnObject
            // 
            this.BtnObject.Location = new System.Drawing.Point(0, 61);
            this.BtnObject.Margin = new System.Windows.Forms.Padding(2);
            this.BtnObject.Name = "BtnObject";
            this.BtnObject.Size = new System.Drawing.Size(150, 19);
            this.BtnObject.TabIndex = 6;
            this.BtnObject.Text = "Предмет";
            this.BtnObject.UseVisualStyleBackColor = true;
            this.BtnObject.Click += new System.EventHandler(this.BtnObject_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(0, 37);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 19);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnClassLesson);
            this.groupBox2.Controls.Add(this.BtnLessonVid);
            this.groupBox2.Location = new System.Drawing.Point(914, 202);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(150, 188);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчёты";
            // 
            // BtnClassLesson
            // 
            this.BtnClassLesson.Location = new System.Drawing.Point(0, 51);
            this.BtnClassLesson.Margin = new System.Windows.Forms.Padding(2);
            this.BtnClassLesson.Name = "BtnClassLesson";
            this.BtnClassLesson.Size = new System.Drawing.Size(150, 19);
            this.BtnClassLesson.TabIndex = 1;
            this.BtnClassLesson.Text = "Классы учителей";
            this.BtnClassLesson.UseVisualStyleBackColor = true;
            this.BtnClassLesson.Click += new System.EventHandler(this.BtnClassLesson_Click);
            // 
            // BtnLessonVid
            // 
            this.BtnLessonVid.Location = new System.Drawing.Point(0, 27);
            this.BtnLessonVid.Margin = new System.Windows.Forms.Padding(2);
            this.BtnLessonVid.Name = "BtnLessonVid";
            this.BtnLessonVid.Size = new System.Drawing.Size(150, 19);
            this.BtnLessonVid.TabIndex = 0;
            this.BtnLessonVid.Text = "Преподаёт";
            this.BtnLessonVid.UseVisualStyleBackColor = true;
            this.BtnLessonVid.Click += new System.EventHandler(this.BtnLessonVid_Click);
            // 
            // BtnLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 400);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BtnLesson";
            this.Text = "Учитель";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button BtnObject;
        private System.Windows.Forms.Button BtnTeacher;
        private System.Windows.Forms.Button btnPrepod;
        private System.Windows.Forms.Button BtnLessonVid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnClassLesson;
    }
}