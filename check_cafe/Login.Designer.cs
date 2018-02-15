namespace check_cafe
{
    partial class Login
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
            this.Combo_host = new System.Windows.Forms.ComboBox();
            this.Text_pass = new System.Windows.Forms.TextBox();
            this.Text_adres = new System.Windows.Forms.TextBox();
            this.bStart = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Combo_host
            // 
            this.Combo_host.FormattingEnabled = true;
            this.Combo_host.Location = new System.Drawing.Point(45, 82);
            this.Combo_host.Name = "Combo_host";
            this.Combo_host.Size = new System.Drawing.Size(263, 21);
            this.Combo_host.TabIndex = 0;
            // 
            // Text_pass
            // 
            this.Text_pass.Location = new System.Drawing.Point(45, 129);
            this.Text_pass.Name = "Text_pass";
            this.Text_pass.Size = new System.Drawing.Size(263, 20);
            this.Text_pass.TabIndex = 1;
            this.Text_pass.UseSystemPasswordChar = true;
            this.Text_pass.WordWrap = false;
            // 
            // Text_adres
            // 
            this.Text_adres.Location = new System.Drawing.Point(45, 34);
            this.Text_adres.Name = "Text_adres";
            this.Text_adres.Size = new System.Drawing.Size(263, 20);
            this.Text_adres.TabIndex = 2;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(45, 178);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 3;
            this.bStart.Text = "OK";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(233, 178);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите адрес:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Пароль:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 228);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.Text_adres);
            this.Controls.Add(this.Text_pass);
            this.Controls.Add(this.Combo_host);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Combo_host;
        private System.Windows.Forms.TextBox Text_pass;
        private System.Windows.Forms.TextBox Text_adres;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}