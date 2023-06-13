
namespace LR_25
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gamenametextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.graduationyeartextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.developertextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.genretextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.platformtextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.insertbutton = new System.Windows.Forms.Button();
            this.GenerateReport = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.searchtextbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(107, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // gamenametextbox
            // 
            this.gamenametextbox.Location = new System.Drawing.Point(107, 72);
            this.gamenametextbox.Name = "gamenametextbox";
            this.gamenametextbox.Size = new System.Drawing.Size(197, 22);
            this.gamenametextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Назва гри:";
            // 
            // graduationyeartextbox
            // 
            this.graduationyeartextbox.Location = new System.Drawing.Point(107, 109);
            this.graduationyeartextbox.Name = "graduationyeartextbox";
            this.graduationyeartextbox.Size = new System.Drawing.Size(197, 22);
            this.graduationyeartextbox.TabIndex = 4;
            this.graduationyeartextbox.TextChanged += new System.EventHandler(this.graduationyeartextbox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Рік випуску:";
            // 
            // developertextbox
            // 
            this.developertextbox.Location = new System.Drawing.Point(453, 32);
            this.developertextbox.Name = "developertextbox";
            this.developertextbox.Size = new System.Drawing.Size(197, 22);
            this.developertextbox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Розробники:";
            // 
            // genretextbox
            // 
            this.genretextbox.Location = new System.Drawing.Point(453, 72);
            this.genretextbox.Name = "genretextbox";
            this.genretextbox.Size = new System.Drawing.Size(197, 22);
            this.genretextbox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Жанр:";
            // 
            // platformtextbox
            // 
            this.platformtextbox.Location = new System.Drawing.Point(453, 109);
            this.platformtextbox.Name = "platformtextbox";
            this.platformtextbox.Size = new System.Drawing.Size(197, 22);
            this.platformtextbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Платформа:";
            // 
            // insertbutton
            // 
            this.insertbutton.Location = new System.Drawing.Point(712, 64);
            this.insertbutton.Name = "insertbutton";
            this.insertbutton.Size = new System.Drawing.Size(162, 32);
            this.insertbutton.TabIndex = 12;
            this.insertbutton.Text = "Внести дані";
            this.insertbutton.UseVisualStyleBackColor = true;
            this.insertbutton.Click += new System.EventHandler(this.insertbutton_Click);
            // 
            // GenerateReport
            // 
            this.GenerateReport.Location = new System.Drawing.Point(786, 432);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(162, 32);
            this.GenerateReport.TabIndex = 14;
            this.GenerateReport.Text = "Згенерувати звіти";
            this.GenerateReport.UseVisualStyleBackColor = true;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(932, 210);
            this.dataGridView1.TabIndex = 15;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 365);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(485, 208);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(786, 394);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Пошук ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchtextbox
            // 
            this.searchtextbox.Location = new System.Drawing.Point(529, 399);
            this.searchtextbox.Name = "searchtextbox";
            this.searchtextbox.Size = new System.Drawing.Size(226, 22);
            this.searchtextbox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(526, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Введіть назву гри:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 607);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchtextbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GenerateReport);
            this.Controls.Add(this.insertbutton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.platformtextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.genretextbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.developertextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.graduationyeartextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gamenametextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Комп\'ютерні ігри";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gamenametextbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox graduationyeartextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox developertextbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox genretextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox platformtextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insertbutton;
        private System.Windows.Forms.Button GenerateReport;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox searchtextbox;
        private System.Windows.Forms.Label label7;
    }
}

