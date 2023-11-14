namespace Trees
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
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            button1 = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            consoleOutputTextBox = new TextBox();
            button2 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            button3 = new Button();
            textBox5 = new TextBox();
            end = new Label();
            label5 = new Label();
            button4 = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(1, 157);
            panel1.Name = "panel1";
            panel1.Size = new Size(1082, 652);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 1;
            label1.Text = "Vertex 1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(66, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.KeyPress += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(66, 54);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 4;
            label2.Text = "Vertex 2";
            // 
            // button1
            // 
            button1.Location = new Point(213, 30);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "add Edge";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(424, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(373, 20);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "start:";
            // 
            // consoleOutputTextBox
            // 
            consoleOutputTextBox.Location = new Point(780, 96);
            consoleOutputTextBox.Name = "consoleOutputTextBox";
            consoleOutputTextBox.Size = new Size(100, 23);
            consoleOutputTextBox.TabIndex = 8;
            // 
            // button2
            // 
            button2.Location = new Point(437, 44);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "run";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 96);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Weight";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(66, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 11;
            textBox4.KeyPress += textBox4_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(869, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 12;
            // 
            // button3
            // 
            button3.Location = new Point(437, 73);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 13;
            button3.Text = "reset";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(595, 15);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 14;
            // 
            // end
            // 
            end.AutoSize = true;
            end.Location = new Point(543, 18);
            end.Name = "end";
            end.Size = new Size(27, 15);
            end.TabIndex = 15;
            end.Text = "end";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(780, 18);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 16;
            label5.Text = "Search Algo:";
            // 
            // button4
            // 
            button4.Location = new Point(437, 102);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 17;
            button4.Text = "pause";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 811);
            Controls.Add(button4);
            Controls.Add(label5);
            Controls.Add(end);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(consoleOutputTextBox);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private TextBox textBox3;
        private Label label3;
        private TextBox consoleOutputTextBox;
        private Button button2;
        private Label label4;
        private TextBox textBox4;
        private ComboBox comboBox1;
        private Button button3;
        private TextBox textBox5;
        private Label end;
        private Label label5;
        private Button button4;
    }
}