namespace ForLoopsPractice
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
            result = new ListBox();
            SuspendLayout();
            // 
            // result
            // 
            result.FormattingEnabled = true;
            result.Location = new Point(12, 12);
            result.Name = "result";
            result.Size = new Size(221, 364);
            result.TabIndex = 0;
            result.SelectedIndexChanged += result_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(result);
            Name = "Form1";
            Text = "For Loop";
            ResumeLayout(false);
        }

        #endregion

        private ListBox result;
    }
}
