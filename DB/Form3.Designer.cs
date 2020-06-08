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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.BtnObject = new System.Windows.Forms.Button();
            this.BtnTeacher = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.BtnLessonVid = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BtnClassLesson = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(600, 467);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.BtnTeacher);
            this.groupBox1.Controls.Add(this.BtnObject);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Location = new System.Drawing.Point(633, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 196);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод и редактирование данных";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.BtnClassLesson);
            this.groupBox2.Controls.Add(this.BtnLessonVid);
            this.groupBox2.Location = new System.Drawing.Point(633, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 231);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчёты";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(0, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(200, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // BtnObject
            // 
            this.BtnObject.Location = new System.Drawing.Point(0, 75);
            this.BtnObject.Name = "BtnObject";
            this.BtnObject.Size = new System.Drawing.Size(200, 23);
            this.BtnObject.TabIndex = 6;
            this.BtnObject.Text = "Предмет";
            this.BtnObject.UseVisualStyleBackColor = true;
            this.BtnObject.Click += new System.EventHandler(this.BtnObject_Click);
            // 
            // BtnTeacher
            // 
            this.BtnTeacher.Location = new System.Drawing.Point(0, 105);
            this.BtnTeacher.Name = "BtnTeacher";
            this.BtnTeacher.Size = new System.Drawing.Size(200, 23);
            this.BtnTeacher.TabIndex = 7;
            this.BtnTeacher.Text = "Учитель";
            this.BtnTeacher.UseVisualStyleBackColor = true;
            this.BtnTeacher.Click += new System.EventHandler(this.BtnTeacher_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Препадаёт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnLessonVid
            // 
            this.BtnLessonVid.Location = new System.Drawing.Point(0, 33);
            this.BtnLessonVid.Name = "BtnLessonVid";
            this.BtnLessonVid.Size = new System.Drawing.Size(200, 23);
            this.BtnLessonVid.TabIndex = 0;
            this.BtnLessonVid.Text = "Препадаёт";
            this.BtnLessonVid.UseVisualStyleBackColor = true;
            this.BtnLessonVid.Click += new System.EventHandler(this.BtnLessonVid_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(0, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Классы учителей";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BtnClassLesson
            // 
            this.BtnClassLesson.Location = new System.Drawing.Point(0, 63);
            this.BtnClassLesson.Name = "BtnClassLesson";
            this.BtnClassLesson.Size = new System.Drawing.Size(200, 23);
            this.BtnClassLesson.TabIndex = 1;
            this.BtnClassLesson.Text = "Классы учителей";
            this.BtnClassLesson.UseVisualStyleBackColor = true;
            this.BtnClassLesson.Click += new System.EventHandler(this.BtnClassLesson_Click);
            // 
            // BtnLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 492);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BtnLesson";
            this.Text = "Учитель";
            this.Load += new System.EventHandler(this.Form3_Load);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnLessonVid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BtnClassLesson;
    }
}