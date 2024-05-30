namespace practica
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(190, 375);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "LIMPIAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(397, 375);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "ENVIAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(86, 54);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 2;
            label1.Text = "I.P.P.\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 91);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "CARATULA\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(86, 168);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "IMPUTADO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 132);
            label4.Name = "label4";
            label4.Size = new Size(87, 15);
            label4.TabIndex = 5;
            label4.Text = "DENUNCIANTE";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 202);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 6;
            label5.Text = "U.F.I.D.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 241);
            label6.Name = "label6";
            label6.Size = new Size(75, 15);
            label6.TabIndex = 7;
            label6.Text = "INSTRUCTOR";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 280);
            label7.Name = "label7";
            label7.Size = new Size(72, 15);
            label7.TabIndex = 8;
            label7.Text = "SECRETARIO";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(86, 316);
            label8.Name = "label8";
            label8.Size = new Size(44, 15);
            label8.TabIndex = 9;
            label8.Text = "FECHA";
            // 
            // textBox1
            // 
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(190, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(282, 23);
            textBox1.TabIndex = 10;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(190, 88);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(282, 23);
            textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(190, 124);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(282, 23);
            textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(190, 165);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(282, 23);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(190, 199);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(282, 23);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(190, 233);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(282, 23);
            textBox6.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(190, 272);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(282, 23);
            textBox7.TabIndex = 16;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(190, 308);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(282, 23);
            textBox8.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 487);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Ofelia - Sara";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
    }
}
