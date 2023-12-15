namespace Opdracht_5
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
            prijs = new TextBox();
            korting = new TextBox();
            output = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(337, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "bereken";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // prijs
            // 
            prijs.Location = new Point(192, 91);
            prijs.Name = "prijs";
            prijs.Size = new Size(100, 23);
            prijs.TabIndex = 1;
            prijs.Text = "prijs";
            // 
            // korting
            // 
            korting.Location = new Point(441, 91);
            korting.Name = "korting";
            korting.Size = new Size(100, 23);
            korting.TabIndex = 2;
            korting.Text = "korting in %";
            // 
            // output
            // 
            output.AutoSize = true;
            output.Location = new Point(364, 244);
            output.Name = "output";
            output.Size = new Size(43, 15);
            output.TabIndex = 3;
            output.Text = "output";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(output);
            Controls.Add(korting);
            Controls.Add(prijs);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox prijs;
        private TextBox korting;
        private Label output;
    }
}
