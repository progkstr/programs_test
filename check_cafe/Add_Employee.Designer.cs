namespace check_cafe
{
    partial class Add_Employee
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
            this.t_Name = new System.Windows.Forms.TextBox();
            this.t_Adres = new System.Windows.Forms.TextBox();
            this.t_Phone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_Position = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Add_emp = new System.Windows.Forms.Button();
            this.Close_f = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_Name
            // 
            this.t_Name.Location = new System.Drawing.Point(26, 70);
            this.t_Name.Name = "t_Name";
            this.t_Name.Size = new System.Drawing.Size(329, 20);
            this.t_Name.TabIndex = 0;
            // 
            // t_Adres
            // 
            this.t_Adres.Location = new System.Drawing.Point(26, 122);
            this.t_Adres.Name = "t_Adres";
            this.t_Adres.Size = new System.Drawing.Size(329, 20);
            this.t_Adres.TabIndex = 1;
            // 
            // t_Phone
            // 
            this.t_Phone.Location = new System.Drawing.Point(26, 171);
            this.t_Phone.Name = "t_Phone";
            this.t_Phone.Size = new System.Drawing.Size(329, 20);
            this.t_Phone.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Должность";
            // 
            // t_Position
            // 
            this.t_Position.FormattingEnabled = true;
            this.t_Position.Location = new System.Drawing.Point(26, 222);
            this.t_Position.Name = "t_Position";
            this.t_Position.Size = new System.Drawing.Size(329, 21);
            this.t_Position.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Добавить нового сотрудника";
            // 
            // Add_emp
            // 
            this.Add_emp.Location = new System.Drawing.Point(47, 279);
            this.Add_emp.Name = "Add_emp";
            this.Add_emp.Size = new System.Drawing.Size(84, 40);
            this.Add_emp.TabIndex = 10;
            this.Add_emp.Text = "Добавить";
            this.Add_emp.UseVisualStyleBackColor = true;
            // 
            // Close_f
            // 
            this.Close_f.Location = new System.Drawing.Point(250, 279);
            this.Close_f.Name = "Close_f";
            this.Close_f.Size = new System.Drawing.Size(84, 40);
            this.Close_f.TabIndex = 11;
            this.Close_f.Text = "Закрыть";
            this.Close_f.UseVisualStyleBackColor = true;
            this.Close_f.Click += new System.EventHandler(this.Close_f_Click);
            // 
            // Add_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 344);
            this.Controls.Add(this.Close_f);
            this.Controls.Add(this.Add_emp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.t_Position);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_Phone);
            this.Controls.Add(this.t_Adres);
            this.Controls.Add(this.t_Name);
            this.Name = "Add_Employee";
            this.Text = "Add_Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_Name;
        private System.Windows.Forms.TextBox t_Adres;
        private System.Windows.Forms.TextBox t_Phone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox t_Position;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Add_emp;
        private System.Windows.Forms.Button Close_f;
    }
}