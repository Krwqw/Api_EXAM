
namespace demo_exam
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonClear = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            textsql = new TextBox();
            buttonExecute = new Button();
            groupBox1 = new GroupBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            lblStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(12, 79);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(82, 23);
            buttonClear.TabIndex = 0;
            buttonClear.Text = "Очистить";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 2;
            label1.Text = "Введите sql запрос:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(698, 220);
            dataGridView1.TabIndex = 3;
            // 
            // textsql
            // 
            textsql.Location = new Point(146, 42);
            textsql.Multiline = true;
            textsql.Name = "textsql";
            textsql.ScrollBars = ScrollBars.Vertical;
            textsql.Size = new Size(384, 106);
            textsql.TabIndex = 4;
            // 
            // buttonExecute
            // 
            buttonExecute.Location = new Point(12, 108);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(82, 23);
            buttonExecute.TabIndex = 5;
            buttonExecute.Text = "Выполнить";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += buttonExecute_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(550, 42);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 144);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Быстрые запросы:";
            // 
            // button5
            // 
            button5.Location = new Point(123, 66);
            button5.Name = "button5";
            button5.Size = new Size(85, 40);
            button5.TabIndex = 4;
            button5.Text = "Клиенты\r\nФевраль\r\n";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(123, 20);
            button4.Name = "button4";
            button4.Size = new Size(85, 40);
            button4.TabIndex = 3;
            button4.Text = "Свободные\r\nбизнес\r\n";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Location = new Point(16, 95);
            button3.Name = "button3";
            button3.Size = new Size(85, 40);
            button3.TabIndex = 2;
            button3.Text = "Всего\r\nномеров\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(16, 49);
            button2.Name = "button2";
            button2.Size = new Size(85, 40);
            button2.TabIndex = 1;
            button2.Text = "Свободные \r\nстандарт\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(16, 20);
            button1.Name = "button1";
            button1.Size = new Size(85, 23);
            button1.TabIndex = 0;
            button1.Text = "Свободные номера";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(0, 0);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(100, 23);
            lblStatus.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(lblStatus);
            Controls.Add(buttonExecute);
            Controls.Add(textsql);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Controls.Add(buttonClear);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button buttonClear;
        private Label label1;
        private DataGridView dataGridView1;
        private TextBox textsql;
        private Button buttonExecute;
        private GroupBox groupBox1;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label lblStatus;
    }
}
