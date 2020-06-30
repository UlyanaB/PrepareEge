namespace DB
{
    partial class InputAdmin
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
            this.BtnInput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxLogin = new System.Windows.Forms.TextBox();
            this.TxPassword = new System.Windows.Forms.TextBox();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.LbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnInput
            // 
            this.BtnInput.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnInput.Location = new System.Drawing.Point(40, 119);
            this.BtnInput.Name = "BtnInput";
            this.BtnInput.Size = new System.Drawing.Size(75, 23);
            this.BtnInput.TabIndex = 3;
            this.BtnInput.Text = "Вход";
            this.BtnInput.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // TxLogin
            // 
            this.TxLogin.Location = new System.Drawing.Point(69, 13);
            this.TxLogin.Name = "TxLogin";
            this.TxLogin.Size = new System.Drawing.Size(100, 20);
            this.TxLogin.TabIndex = 1;
            // 
            // TxPassword
            // 
            this.TxPassword.Location = new System.Drawing.Point(69, 50);
            this.TxPassword.Name = "TxPassword";
            this.TxPassword.PasswordChar = '*';
            this.TxPassword.Size = new System.Drawing.Size(100, 20);
            this.TxPassword.TabIndex = 2;
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(122, 119);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 23);
            this.BtnCancel.TabIndex = 4;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            // 
            // LbMessage
            // 
            this.LbMessage.AutoSize = true;
            this.LbMessage.ForeColor = System.Drawing.Color.Red;
            this.LbMessage.Location = new System.Drawing.Point(12, 151);
            this.LbMessage.Name = "LbMessage";
            this.LbMessage.Size = new System.Drawing.Size(0, 13);
            this.LbMessage.TabIndex = 6;
            // 
            // InputAdmin
            // 
            this.AcceptButton = this.BtnInput;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancel;
            this.ClientSize = new System.Drawing.Size(235, 173);
            this.ControlBox = false;
            this.Controls.Add(this.LbMessage);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.TxPassword);
            this.Controls.Add(this.TxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnInput);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InputAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox TxLogin;
        internal System.Windows.Forms.TextBox TxPassword;
        private System.Windows.Forms.Button BtnCancel;
        internal System.Windows.Forms.Label LbMessage;
    }
}