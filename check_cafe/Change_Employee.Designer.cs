namespace check_cafe
{
    partial class Change_Employee
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
            this.AddNewEmployee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddNewEmployee
            // 
            this.AddNewEmployee.Location = new System.Drawing.Point(747, 12);
            this.AddNewEmployee.Name = "AddNewEmployee";
            this.AddNewEmployee.Size = new System.Drawing.Size(113, 49);
            this.AddNewEmployee.TabIndex = 0;
            this.AddNewEmployee.Text = "Зарегистрировать сотрудника";
            this.AddNewEmployee.UseVisualStyleBackColor = true;
            // 
            // Change_Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 452);
            this.Controls.Add(this.AddNewEmployee);
            this.Name = "Change_Employee";
            this.Text = "Change_Employee";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddNewEmployee;
    }
}