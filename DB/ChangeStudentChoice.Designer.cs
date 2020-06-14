namespace DB
{
    partial class ChangeStudentChoice
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStudentChoiceId = new System.Windows.Forms.Label();
            this.cbxStudent = new System.Windows.Forms.ComboBox();
            this.cbxObject = new System.Windows.Forms.ComboBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(295, 73);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblStudentChoiceId
            // 
            this.lblStudentChoiceId.AutoSize = true;
            this.lblStudentChoiceId.Location = new System.Drawing.Point(12, 39);
            this.lblStudentChoiceId.Name = "lblStudentChoiceId";
            this.lblStudentChoiceId.Size = new System.Drawing.Size(0, 13);
            this.lblStudentChoiceId.TabIndex = 7;
            // 
            // cbxStudent
            // 
            this.cbxStudent.FormattingEnabled = true;
            this.cbxStudent.Location = new System.Drawing.Point(57, 31);
            this.cbxStudent.Name = "cbxStudent";
            this.cbxStudent.Size = new System.Drawing.Size(437, 21);
            this.cbxStudent.TabIndex = 8;
            // 
            // cbxObject
            // 
            this.cbxObject.FormattingEnabled = true;
            this.cbxObject.Location = new System.Drawing.Point(513, 31);
            this.cbxObject.Name = "cbxObject";
            this.cbxObject.Size = new System.Drawing.Size(264, 21);
            this.cbxObject.TabIndex = 9;
            // 
            // btnChange
            // 
            this.btnChange.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnChange.Location = new System.Drawing.Point(52, 73);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(75, 23);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdd.Location = new System.Drawing.Point(133, 73);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDelete.Location = new System.Drawing.Point(214, 73);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ChangeStudentChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(794, 126);
            this.ControlBox = false;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.cbxObject);
            this.Controls.Add(this.cbxStudent);
            this.Controls.Add(this.lblStudentChoiceId);
            this.Controls.Add(this.btnCancel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeStudentChoice";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ChangeStudentChoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        internal System.Windows.Forms.Label lblStudentChoiceId;
        internal System.Windows.Forms.ComboBox cbxStudent;
        internal System.Windows.Forms.ComboBox cbxObject;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}