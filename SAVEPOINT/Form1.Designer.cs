namespace SAVEPOINT
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
            this.label4 = new System.Windows.Forms.Label();
            this.btn_2000 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ROLLBACK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_1000 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_ROLLBACKTO = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(715, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 51);
            this.label4.TabIndex = 8;
            this.label4.Text = "UPDATE branch SET branch_area = 2000 \r\nWHERE branch_address = \'test\';\r\nSELECT * F" +
    "ROM branch;";
            // 
            // btn_2000
            // 
            this.btn_2000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_2000.Location = new System.Drawing.Point(592, 187);
            this.btn_2000.Name = "btn_2000";
            this.btn_2000.Size = new System.Drawing.Size(109, 60);
            this.btn_2000.TabIndex = 7;
            this.btn_2000.Text = "Выполнить";
            this.btn_2000.UseVisualStyleBackColor = true;
            this.btn_2000.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(280, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(601, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "INSERT INTO branch (branch_address, branch_phone, branch_area, branch_working_hou" +
    "rs)\r\nVALUES (\'test\', \'test\', 100, \'test\');\r\nSELECT * FROM branch;";
            // 
            // btn_ROLLBACK
            // 
            this.btn_ROLLBACK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ROLLBACK.AutoSize = true;
            this.btn_ROLLBACK.Location = new System.Drawing.Point(377, 264);
            this.btn_ROLLBACK.Name = "btn_ROLLBACK";
            this.btn_ROLLBACK.Size = new System.Drawing.Size(176, 60);
            this.btn_ROLLBACK.TabIndex = 5;
            this.btn_ROLLBACK.Text = "ROLLBACK;\r\nSELECT * FROM branch;";
            this.btn_ROLLBACK.UseVisualStyleBackColor = true;
            this.btn_ROLLBACK.Click += new System.EventHandler(this.btnres1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "UPDATE branch SET branch_area = 1000\r\nWHERE branch_address = \'test\';\r\nSELECT * FR" +
    "OM branch;";
            // 
            // btn_1000
            // 
            this.btn_1000.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_1000.Location = new System.Drawing.Point(167, 187);
            this.btn_1000.Name = "btn_1000";
            this.btn_1000.Size = new System.Drawing.Size(109, 60);
            this.btn_1000.TabIndex = 3;
            this.btn_1000.Text = "Выполнить";
            this.btn_1000.UseVisualStyleBackColor = true;
            this.btn_1000.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 685);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 345);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1154, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_ROLLBACKTO);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_2000);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_ROLLBACK);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_1000);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1154, 336);
            this.panel1.TabIndex = 5;
            // 
            // btn_ROLLBACKTO
            // 
            this.btn_ROLLBACKTO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ROLLBACKTO.AutoSize = true;
            this.btn_ROLLBACKTO.Location = new System.Drawing.Point(601, 264);
            this.btn_ROLLBACKTO.Name = "btn_ROLLBACKTO";
            this.btn_ROLLBACKTO.Size = new System.Drawing.Size(176, 60);
            this.btn_ROLLBACKTO.TabIndex = 12;
            this.btn_ROLLBACKTO.Text = "ROLLBACK TO test2;\r\nSELECT * FROM branch;";
            this.btn_ROLLBACKTO.UseVisualStyleBackColor = true;
            this.btn_ROLLBACKTO.Click += new System.EventHandler(this.btnres2_Click);
            // 
            // btn_start
            // 
            this.btn_start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_start.AutoSize = true;
            this.btn_start.Location = new System.Drawing.Point(337, 92);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(513, 78);
            this.btn_start.TabIndex = 9;
            this.btn_start.Text = "BEGIN TRANSACTION;\r\nUPDATE branch SET branch_phone = \'test2\' WHERE branch_address" +
    " = \'test\';\r\nSELECT * FROM branch;\r\nSAVEPOINT test2;\r\n";
            this.btn_start.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 685);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "SAVEPOINTS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_2000;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ROLLBACK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_1000;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_ROLLBACKTO;
    }
}

