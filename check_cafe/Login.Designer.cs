namespace check_cafe
{
    partial class Login
    {
        // <summary>
        // Required designer variable.
        // </summary>
        private System.ComponentModel.IContainer components = null;

        // <summary>
        // Clean up any resources being used.
        // </summary>
        // <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.Text_adres = new MetroFramework.Controls.MetroTextBox();
            this.Text_pass = new MetroFramework.Controls.MetroTextBox();
            this.Combo_host = new MetroFramework.Controls.MetroComboBox();
            this.bStart = new MetroFramework.Controls.MetroButton();
            this.bCancel = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(128, 21);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(100, 19);
            this.metroLabel1.TabIndex = 8;
            this.metroLabel1.Text = "Введите адрес:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(128, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(50, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Логин:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(128, 124);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(57, 19);
            this.metroLabel3.TabIndex = 10;
            this.metroLabel3.Text = "Пароль:";
            // 
            // metroPanel1
            // 
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(381, 197);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(200, 100);
            this.metroPanel1.TabIndex = 11;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // Text_adres
            // 
            this.Text_adres.Location = new System.Drawing.Point(128, 43);
            this.Text_adres.Name = "Text_adres";
            this.Text_adres.Size = new System.Drawing.Size(278, 23);
            this.Text_adres.TabIndex = 12;
            // 
            // Text_pass
            // 
            this.Text_pass.Location = new System.Drawing.Point(128, 146);
            this.Text_pass.Name = "Text_pass";
            this.Text_pass.Size = new System.Drawing.Size(278, 23);
            this.Text_pass.TabIndex = 13;
            // 
            // Combo_host
            // 
            this.Combo_host.FormattingEnabled = true;
            this.Combo_host.ItemHeight = 23;
            this.Combo_host.Location = new System.Drawing.Point(128, 93);
            this.Combo_host.Name = "Combo_host";
            this.Combo_host.Size = new System.Drawing.Size(278, 29);
            this.Combo_host.TabIndex = 14;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(128, 187);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 15;
            this.bStart.Text = "ОК";
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(331, 187);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 16;
            this.bCancel.Text = "Cancel";
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 227);
            this.ControlBox = false;
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.Combo_host);
            this.Controls.Add(this.Text_pass);
            this.Controls.Add(this.Text_adres);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox Text_adres;
        private MetroFramework.Controls.MetroTextBox Text_pass;
        private MetroFramework.Controls.MetroComboBox Combo_host;
        private MetroFramework.Controls.MetroButton bStart;
        private MetroFramework.Controls.MetroButton bCancel;
    }
}