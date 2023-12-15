namespace Opdracht_4
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
            plus_button = new Button();
            minus_button = new Button();
            multiply_button = new Button();
            divide_button = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            output = new Label();
            SuspendLayout();
            // 
            // plus_button
            // 
            plus_button.Location = new Point(184, 162);
            plus_button.Name = "plus_button";
            plus_button.Size = new Size(75, 23);
            plus_button.TabIndex = 0;
            plus_button.Text = "+";
            plus_button.UseVisualStyleBackColor = true;
            plus_button.Click += plus_button_Click;
            // 
            // minus_button
            // 
            minus_button.Location = new Point(293, 167);
            minus_button.Name = "minus_button";
            minus_button.Size = new Size(75, 23);
            minus_button.TabIndex = 1;
            minus_button.Text = "-";
            minus_button.UseVisualStyleBackColor = true;
            minus_button.Click += minus_button_Click;
            // 
            // multiply_button
            // 
            multiply_button.Location = new Point(411, 161);
            multiply_button.Name = "multiply_button";
            multiply_button.Size = new Size(75, 23);
            multiply_button.TabIndex = 2;
            multiply_button.Text = "*";
            multiply_button.UseVisualStyleBackColor = true;
            multiply_button.Click += multiply_button_Click;
            // 
            // divide_button
            // 
            divide_button.Location = new Point(519, 160);
            divide_button.Name = "divide_button";
            divide_button.Size = new Size(75, 23);
            divide_button.TabIndex = 3;
            divide_button.Text = "/";
            divide_button.UseVisualStyleBackColor = true;
            divide_button.Click += divide_button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(246, 86);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(417, 90);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(362, 244);
            output.Name = "output";
            output.Size = new Size(43, 15);
            output.TabIndex = 6;
            output.Text = "output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(output);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(divide_button);
            Controls.Add(multiply_button);
            Controls.Add(minus_button);
            Controls.Add(plus_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button plus_button;
        private Button minus_button;
        private Button multiply_button;
        private Button divide_button;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label output;
    }
}
