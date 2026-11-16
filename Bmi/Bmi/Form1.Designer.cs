namespace Bmi
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
            label1 = new Label();
            txtWeight = new TextBox();
            txtHeight = new TextBox();
            lblHeight = new Label();
            lblResult = new Label();
            resultData = new TextBox();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(69, 57);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "Weigth";
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(207, 54);
            txtWeight.Multiline = true;
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(303, 34);
            txtWeight.TabIndex = 1;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(207, 119);
            txtHeight.Multiline = true;
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(303, 34);
            txtHeight.TabIndex = 3;
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeight.Location = new Point(69, 122);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(68, 25);
            lblHeight.TabIndex = 2;
            lblHeight.Text = "Height";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResult.Location = new Point(69, 216);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(64, 25);
            lblResult.TabIndex = 4;
            lblResult.Text = "Result";
            // 
            // resultData
            // 
            resultData.Location = new Point(69, 275);
            resultData.Multiline = true;
            resultData.Name = "resultData";
            resultData.Size = new Size(437, 75);
            resultData.TabIndex = 5;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(78, 407);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(698, 531);
            Controls.Add(btnCalculate);
            Controls.Add(resultData);
            Controls.Add(lblResult);
            Controls.Add(txtHeight);
            Controls.Add(lblHeight);
            Controls.Add(txtWeight);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtWeight;
        private TextBox txtHeight;
        private Label lblHeight;
        private Label lblResult;
        private TextBox resultData;
        private Button btnCalculate;
    }
}
