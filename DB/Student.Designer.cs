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
            this.btnWorker = new System.Windows.Forms.Button();
            this.btnOrderType = new System.Windows.Forms.Button();
            this.btnOrders = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOrderByDate = new System.Windows.Forms.Button();
            this.btnOrdersByWorker = new System.Windows.Forms.Button();
            this.btnOrderByWorker = new System.Windows.Forms.Button();
            this.tbParam1 = new System.Windows.Forms.TextBox();
            this.btnObject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOrderQuantity
            // 
            this.btnOrderQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderQuantity.Location = new System.Drawing.Point(0, 78);
            this.btnOrderQuantity.Name = "btnOrderQuantity";
            this.btnOrderQuantity.Size = new System.Drawing.Size(208, 23);
            this.btnOrderQuantity.TabIndex = 0;
            this.btnOrderQuantity.Text = "Выбор";
            this.btnOrderQuantity.UseVisualStyleBackColor = true;
            this.btnOrderQuantity.Click += new System.EventHandler(this.btnOrderQuantity_Click);
            // 
            // btnWorkerProfit
            // 
            this.btnWorkerProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorkerProfit.Location = new System.Drawing.Point(839, 479);
            this.btnWorkerProfit.Name = "btnWorkerProfit";
            this.btnWorkerProfit.Size = new System.Drawing.Size(208, 23);
            this.btnWorkerProfit.TabIndex = 1;
            this.btnWorkerProfit.Text = "Доход работника";
            this.btnWorkerProfit.UseVisualStyleBackColor = true;
            this.btnWorkerProfit.Visible = false;
            this.btnWorkerProfit.Click += new System.EventHandler(this.btnWorkerProfit_Click);
            // 
            // btnFirmProfit
            // 
            this.btnFirmProfit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirmProfit.Location = new System.Drawing.Point(839, 508);
            this.btnFirmProfit.Name = "btnFirmProfit";
            this.btnFirmProfit.Size = new System.Drawing.Size(208, 23);
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(821, 522);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(849, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(198, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnWorker
            // 
            this.btnWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWorker.Location = new System.Drawing.Point(849, 94);
            this.btnWorker.Name = "btnWorker";
            this.btnWorker.Size = new System.Drawing.Size(198, 23);
            this.btnWorker.TabIndex = 5;
            this.btnWorker.Text = "Класс";
            this.btnWorker.UseVisualStyleBackColor = true;
            this.btnWorker.Click += new System.EventHandler(this.btnWorker_Click);
            // 
            // btnOrderType
            // 
            this.btnOrderType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderType.Location = new System.Drawing.Point(849, 123);
            this.btnOrderType.Name = "btnOrderType";
            this.btnOrderType.Size = new System.Drawing.Size(198, 23);
            this.btnOrderType.TabIndex = 6;
            this.btnOrderType.Text = "Предметы";
            this.btnOrderType.UseVisualStyleBackColor = true;
            this.btnOrderType.Click += new System.EventHandler(this.btnOrderType_Click);
            // 
            // btnOrders
            // 
            this.btnOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrders.Location = new System.Drawing.Point(849, 152);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(198, 23);
            this.btnOrders.TabIndex = 7;
            this.btnOrders.Text = "Ученик";
            this.btnOrders.UseVisualStyleBackColor = true;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnObject);
            this.groupBox1.Location = new System.Drawing.Point(849, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 222);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод и редактирование данных";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnOrderByDate);
            this.groupBox2.Controls.Add(this.btnOrdersByWorker);
            this.groupBox2.Controls.Add(this.btnOrderByWorker);
            this.groupBox2.Controls.Add(this.tbParam1);
            this.groupBox2.Controls.Add(this.btnOrderQuantity);
            this.groupBox2.Location = new System.Drawing.Point(839, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 281);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Отчеты";
            // 
            // btnOrderByDate
            // 
            this.btnOrderByDate.Location = new System.Drawing.Point(0, 167);
            this.btnOrderByDate.Name = "btnOrderByDate";
            this.btnOrderByDate.Size = new System.Drawing.Size(208, 23);
            this.btnOrderByDate.TabIndex = 3;
            this.btnOrderByDate.Text = "Колчество заказов на дату";
            this.btnOrderByDate.UseVisualStyleBackColor = true;
            this.btnOrderByDate.Visible = false;
            this.btnOrderByDate.Click += new System.EventHandler(this.btnOrderByDate_Click);
            // 
            // btnOrdersByWorker
            // 
            this.btnOrdersByWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrdersByWorker.Location = new System.Drawing.Point(6, 138);
            this.btnOrdersByWorker.Name = "btnOrdersByWorker";
            this.btnOrdersByWorker.Size = new System.Drawing.Size(208, 23);
            this.btnOrdersByWorker.TabIndex = 2;
            this.btnOrdersByWorker.Text = "Заказы сотрудника";
            this.btnOrdersByWorker.UseVisualStyleBackColor = true;
            this.btnOrdersByWorker.Visible = false;
            this.btnOrdersByWorker.Click += new System.EventHandler(this.btnOrderByWorker_Click);
            // 
            // btnOrderByWorker
            // 
            this.btnOrderByWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOrderByWorker.Location = new System.Drawing.Point(0, 49);
            this.btnOrderByWorker.Name = "btnOrderByWorker";
            this.btnOrderByWorker.Size = new System.Drawing.Size(208, 23);
            this.btnOrderByWorker.TabIndex = 1;
            this.btnOrderByWorker.Text = "Ученики";
            this.btnOrderByWorker.UseVisualStyleBackColor = true;
            this.btnOrderByWorker.Click += new System.EventHandler(this.btnWorkersOrder_Click);
            // 
            // tbParam1
            // 
            this.tbParam1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tbParam1.Location = new System.Drawing.Point(0, 21);
            this.tbParam1.Name = "tbParam1";
            this.tbParam1.Size = new System.Drawing.Size(202, 22);
            this.tbParam1.TabIndex = 0;
            this.tbParam1.Visible = false;
            // 
            // btnObject
            // 
            this.btnObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnObject.Location = new System.Drawing.Point(0, 169);
            this.btnObject.Name = "btnObject";
            this.btnObject.Size = new System.Drawing.Size(198, 23);
            this.btnObject.TabIndex = 10;
            this.btnObject.Text = "Выбор ученика";
            this.btnObject.UseVisualStyleBackColor = true;
            this.btnObject.Click += new System.EventHandler(this.btnObject_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 547);
            this.Controls.Add(this.btnOrders);
            this.Controls.Add(this.btnOrderType);
            this.Controls.Add(this.btnWorker);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFirmProfit);
            this.Controls.Add(this.btnWorkerProfit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Ученик";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Button btnWorker;
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

