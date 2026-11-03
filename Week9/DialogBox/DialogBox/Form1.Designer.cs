namespace DialogBox
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
            btnClear = new Button();
            button1 = new Button();
            ResultListBox = new ListBox();
            SuspendLayout();
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(30, 62);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(213, 71);
            btnClear.TabIndex = 0;
            btnClear.Text = "Open Dialog Box";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnOpen_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(30, 167);
            button1.Name = "button1";
            button1.Size = new Size(213, 71);
            button1.TabIndex = 1;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ResultListBox
            // 
            ResultListBox.FormattingEnabled = true;
            ResultListBox.Location = new Point(431, 22);
            ResultListBox.Name = "ResultListBox";
            ResultListBox.Size = new Size(343, 264);
            ResultListBox.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 319);
            Controls.Add(ResultListBox);
            Controls.Add(button1);
            Controls.Add(btnClear);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnClear;
        private Button button1;
        private ListBox ResultListBox;
    }
}
