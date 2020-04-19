namespace READ_COMMITED_SND_TRANSACTION
{
    partial class Form1
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_1.Location = new System.Drawing.Point(66, 73);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(109, 60);
            this.btn_1.TabIndex = 4;
            this.btn_1.Text = "Выполнить";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(408, 51);
            this.label2.TabIndex = 5;
            this.label2.Text = "BEGIN TRANSACTION ISOLATION LEVEL READ COMMITTED;\r\nUPDATE branch SET branch_area " +
    "= branch_area+100;\r\nCOMMIT;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 208);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "READ COMMITED SND TRANSACTION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label label2;
    }
}

