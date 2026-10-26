namespace WhileLoopPractice
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
            txtNumber = new TextBox();
            result = new ListBox();
            lblNum = new Label();
            btnSave = new Button();
            btnCleaer = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(35, 58);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(354, 54);
            txtNumber.TabIndex = 0;
            txtNumber.TextChanged += textBox1_TextChanged;
            // 
            // result
            // 
            result.FormattingEnabled = true;
            result.Location = new Point(35, 251);
            result.Name = "result";
            result.Size = new Size(354, 264);
            result.TabIndex = 1;
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNum.Location = new Point(35, 23);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(108, 20);
            lblNum.TabIndex = 2;
            lblNum.Text = "Enter Number";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(35, 166);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCleaer
            // 
            btnCleaer.Location = new Point(172, 166);
            btnCleaer.Name = "btnCleaer";
            btnCleaer.Size = new Size(94, 34);
            btnCleaer.TabIndex = 4;
            btnCleaer.Text = "Clear";
            btnCleaer.UseVisualStyleBackColor = true;
            btnCleaer.Click += btnCleaer_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(295, 166);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 34);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 527);
            Controls.Add(btnExit);
            Controls.Add(btnCleaer);
            Controls.Add(btnSave);
            Controls.Add(lblNum);
            Controls.Add(result);
            Controls.Add(txtNumber);
            Name = "Form1";
            Text = "While Loop Practice";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumber;
        private ListBox result;
        private Label lblNum;
        private Button btnSave;
        private Button btnCleaer;
        private Button btnExit;
    }
}
