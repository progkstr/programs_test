namespace check_cafe
{
    partial class Check_cafe
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
            this.Add_client = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Add_client
            // 
            this.Add_client.Location = new System.Drawing.Point(183, 202);
            this.Add_client.Name = "Add_client";
            this.Add_client.Size = new System.Drawing.Size(75, 35);
            this.Add_client.TabIndex = 0;
            this.Add_client.Text = "Добавить клиента";
            this.Add_client.UseVisualStyleBackColor = true;
            this.Add_client.Click += new System.EventHandler(this.Add_client_Click);
            // 
            // Check_cafe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Add_client);
            this.Name = "Check_cafe";
            this.Text = "Check_cafe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Add_client;
    }
}

