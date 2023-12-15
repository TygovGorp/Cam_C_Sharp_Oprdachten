namespace Opdracht_1
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
            number_1 = new TextBox();
            number_2 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(283, 204);
            button1.Name = "button1";
            button1.Size = new Size(110, 58);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // number_1
            // 
            number_1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            number_1.Location = new Point(140, 74);
            number_1.Name = "number_1";
            number_1.Size = new Size(130, 43);
            number_1.TabIndex = 1;
            number_1.Text = "number_1";
            number_1.TextChanged += number_1_TextChanged;
            // 
            // number_2
            // 
            number_2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            number_2.Location = new Point(394, 74);
            number_2.Name = "number_2";
            number_2.Size = new Size(130, 43);
            number_2.TabIndex = 2;
            number_2.Text = "number_2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(294, 313);
            label1.Name = "label1";
            label1.Size = new Size(88, 37);
            label1.TabIndex = 3;
            label1.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(number_2);
            Controls.Add(number_1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox number_1;
        private TextBox number_2;
        private Label label1;
    }
}
