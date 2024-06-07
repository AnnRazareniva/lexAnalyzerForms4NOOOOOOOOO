namespace lexAnalyzerForms
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
            tbInput = new RichTextBox();
            tbOutput = new RichTextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // tbInput
            // 
            tbInput.Location = new Point(21, 28);
            tbInput.Margin = new Padding(3, 2, 3, 2);
            tbInput.Name = "tbInput";
            tbInput.Size = new Size(324, 280);
            tbInput.TabIndex = 1;
            tbInput.Text = "int a:=b;";
            // 
            // tbOutput
            // 
            tbOutput.Location = new Point(429, 28);
            tbOutput.Margin = new Padding(3, 2, 3, 2);
            tbOutput.Name = "tbOutput";
            tbOutput.Size = new Size(329, 280);
            tbOutput.TabIndex = 2;
            tbOutput.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(262, 324);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 3;
            button1.Text = "перевести";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 380);
            Controls.Add(button1);
            Controls.Add(tbOutput);
            Controls.Add(tbInput);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox tbInput;
        private RichTextBox tbOutput;
        private Button button1;
    }
}
