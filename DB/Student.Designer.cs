namespace DB
{
    partial class Student
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrderQuantity = new System.Windows.Forms.Button();
            this.btnWorkerProfit = new System.Windows.Forms.Button();
            this.btnFirmProfit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClass = new System.Windows.Forms.Button();
            this.btnOrderType = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObject = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrderByDate = new System.Windows.Forms.Button();
            this.btnOrdersByWorker = new System.Windows.Forms.Button();
            this.btnOrderByWorker = new System.Windows.Forms.Button();
            this.tbParam1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderQuantity
            // 
            this.btnOrderQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderQuantity.Location = new System.Drawing.Point(0, 63);
            this.btnOrderQuantity.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderQuantity.Name = "btnOrderQuantity";
            this.btnOrderQuantity.Size = new System.Drawing.Size(156, 19);
            this.btnOrderQuantity.TabIndex = 0;
            this.btnOrderQuantity.Text = "Выбор";
            this.btnOrderQuantity.UseVisualStyleBackColor = true;
            this.btnOrderQuantity.Click += new System.EventHandler(this.btnOrderQuantity_Click);
            // 
            // btnWorkerProfit
            // 
            this.btnWorkerProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkerProfit.Location = new System.Drawing.Point(924, 389);
            this.btnWorkerProfit.Margin = new System.Windows.Forms.Padding(2);
            this.btnWorkerProfit.Name = "btnWorkerProfit";
            this.btnWorkerProfit.Size = new System.Drawing.Size(156, 19);
            this.btnWorkerProfit.TabIndex = 1;
            this.btnWorkerProfit.Text = "Доход работника";
            this.btnWorkerProfit.UseVisualStyleBackColor = true;
            this.btnWorkerProfit.Visible = false;
            this.btnWorkerProfit.Click += new System.EventHandler(this.btnWorkerProfit_Click);
            // 
            // btnFirmProfit
            // 
            this.btnFirmProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirmProfit.Location = new System.Drawing.Point(924, 413);
            this.btnFirmProfit.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirmProfit.Name = "btnFirmProfit";
            this.btnFirmProfit.Size = new System.Drawing.Size(156, 19);
            this.btnFirmProfit.TabIndex = 2;
            this.btnFirmProfit.Text = "Прибыль организации";
            this.btnFirmProfit.UseVisualStyleBackColor = true;
            this.btnFirmProfit.Visible = false;
            this.btnFirmProfit.Click += new System.EventHandler(this.btnFirmProfit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(911, 424);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(932, 41);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 19);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClass
            // 
            this.btnClass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClass.Location = new System.Drawing.Point(932, 76);
            this.btnClass.Margin = new System.Windows.Forms.Padding(2);
            this.btnClass.Name = "btnClass";
            this.btnClass.Size = new System.Drawing.Size(148, 19);
            this.btnClass.TabIndex = 5;
            this.btnClass.Text = "Класс";
            this.btnClass.UseVisualStyleBackColor = true;
            this.btnClass.Click += new System.EventHandler(this.btnClass_Click);
            // 
            // btnOrderType
            // 
            this.btnOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderType.Location = new System.Drawing.Point(932, 100);
            this.btnOrderType.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderType.Name = "btnOrderType";
            this.btnOrderType.Size = new System.Drawing.Size(148, 19);
            this.btnOrderType.TabIndex = 6;
            this.btnOrderType.Text = "Предметы";
            this.btnOrderType.UseVisualStyleBackColor = true;
            this.btnOrderType.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrders.Location = new System.Drawing.Point(932, 124);
            this.btnOrders.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(148, 19);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "Ученик";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnObject);
            this.groupBox1.Location = new System.Drawing.Point(932, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(148, 180);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод и редактирование данных";
            // 
            // btnObject
            // 
            this.btnObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObject.Location = new System.Drawing.Point(0, 158);
            this.btnObject.Margin = new System.Windows.Forms.Padding(2);
            this.btnObject.Name = "btnObject";
            this.btnObject.Size = new System.Drawing.Size(148, 19);
            this.btnObject.TabIndex = 10;
            this.btnObject.Text = "Выбор ученика";
            this.btnObject.UseVisualStyleBackColor = true;
            this.btnObject.Click += new System.EventHandler(this.btnStudentChoice_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnOrderByDate);
            this.groupBox2.Controls.Add(this.btnOrdersByWorker);
            this.groupBox2.Controls.Add(this.btnOrderByWorker);
            this.groupBox2.Controls.Add(this.tbParam1);
            this.groupBox2.Controls.Add(this.btnOrderQuantity);
            this.groupBox2.Location = new System.Drawing.Point(924, 206);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(156, 228);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчеты";
            // 
            // btnOrderByDate
            // 
            this.btnOrderByDate.Location = new System.Drawing.Point(0, 136);
            this.btnOrderByDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderByDate.Name = "btnOrderByDate";
            this.btnOrderByDate.Size = new System.Drawing.Size(156, 19);
            this.btnOrderByDate.TabIndex = 3;
            this.btnOrderByDate.Text = "Колчество заказов на дату";
            this.btnOrderByDate.UseVisualStyleBackColor = true;
            this.btnOrderByDate.Visible = false;
            this.btnOrderByDate.Click += new System.EventHandler(this.btnOrderByDate_Click);
            // 
            // btnOrdersByWorker
            // 
            this.btnOrdersByWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdersByWorker.Location = new System.Drawing.Point(4, 112);
            this.btnOrdersByWorker.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrdersByWorker.Name = "btnOrdersByWorker";
            this.btnOrdersByWorker.Size = new System.Drawing.Size(156, 19);
            this.btnOrdersByWorker.TabIndex = 2;
            this.btnOrdersByWorker.Text = "Заказы сотрудника";
            this.btnOrdersByWorker.UseVisualStyleBackColor = true;
            this.btnOrdersByWorker.Visible = false;
            this.btnOrdersByWorker.Click += new System.EventHandler(this.btnOrderByWorker_Click);
            // 
            // btnOrderByWorker
            // 
            this.btnOrderByWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderByWorker.Location = new System.Drawing.Point(0, 40);
            this.btnOrderByWorker.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrderByWorker.Name = "btnOrderByWorker";
            this.btnOrderByWorker.Size = new System.Drawing.Size(156, 19);
            this.btnOrderByWorker.TabIndex = 1;
            this.btnOrderByWorker.Text = "Ученики";
            this.btnOrderByWorker.UseVisualStyleBackColor = true;
            this.btnOrderByWorker.Click += new System.EventHandler(this.btnWorkersOrder_Click);
            // 
            // tbParam1
            // 
            this.tbParam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbParam1.Location = new System.Drawing.Point(0, 17);
            this.tbParam1.Margin = new System.Windows.Forms.Padding(2);
            this.tbParam1.Name = "tbParam1";
            this.tbParam1.Size = new System.Drawing.Size(152, 20);
            this.tbParam1.TabIndex = 0;
            this.tbParam1.Visible = false;
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 444);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnOrderType);
            this.Controls.Add(this.btnClass);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFirmProfit);
            this.Controls.Add(this.btnWorkerProfit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Student";
            this.Text = "Ученик";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOrderQuantity;
        private System.Windows.Forms.Button btnWorkerProfit;
        private System.Windows.Forms.Button btnFirmProfit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClass;
        private System.Windows.Forms.Button btnOrderType;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrderByWorker;
        private System.Windows.Forms.TextBox tbParam1;
        private System.Windows.Forms.Button btnOrdersByWorker;
        private System.Windows.Forms.Button btnOrderByDate;
        private System.Windows.Forms.Button btnObject;
    }
}

