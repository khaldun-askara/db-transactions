namespace SERIALIZATION_ANIMALY_FST_TRANSACTION
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1181, 701);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 353);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1175, 345);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_3);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 344);
            this.panel1.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(709, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 51);
            this.label4.TabIndex = 8;
            this.label4.Text = "BEGIN TRANSACTION ISOLATION LEVEL SERIALIZABLE;\r\nUPDATE branch SET branch_area = " +
    "branch_area+100;\r\nSELECT * FROM branch;";
            // 
            // btn_3
            // 
            this.btn_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_3.Location = new System.Drawing.Point(594, 96);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(109, 60);
            this.btn_3.TabIndex = 7;
            this.btn_3.Text = "Выполнить";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(601, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "INSERT INTO branch (branch_address, branch_phone, branch_area, branch_working_hou" +
    "rs)\r\nVALUES (\'test\', \'test\', 100, \'test\')";
            // 
            // btn_2
            // 
            this.btn_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_2.Location = new System.Drawing.Point(368, 185);
            this.btn_2.Name = "btn_2";
            this.btn_2.Size = new System.Drawing.Size(109, 60);
            this.btn_2.TabIndex = 5;
            this.btn_2.Text = "Выполнить";
            this.btn_2.UseVisualStyleBackColor = true;
            this.btn_2.Click += new System.EventHandler(this.btn_2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(152, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "BEGIN TRANSACTION ISOLATION LEVEL REPEATABLE READ;\r\nUPDATE branch SET branch_area" +
    " = branch_area+100;\r\nSELECT * FROM branch;";
            // 
            // btn_1
            // 
            this.btn_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_1.Location = new System.Drawing.Point(37, 96);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(109, 60);
            this.btn_1.TabIndex = 3;
            this.btn_1.Text = "Выполнить";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "SELECT * FROM branch;\r\nCOMMIT;\r\n";
            // 
            // btn_4
            // 
            this.btn_4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_4.Location = new System.Drawing.Point(368, 251);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(109, 60);
            this.btn_4.TabIndex = 10;
            this.btn_4.Text = "Выполнить";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(499, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "SELECT * FROM branch;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 701);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "SERIALIZATION ANOMALY FST TRANSACTION";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Label label5;
    }
}

