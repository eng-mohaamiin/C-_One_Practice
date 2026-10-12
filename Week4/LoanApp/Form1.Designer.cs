namespace LoanApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQualification = new System.Windows.Forms.Button();
            this.btnChangeBg = new System.Windows.Forms.Button();
            this.SalaryInput = new System.Windows.Forms.TextBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblExpreience = new System.Windows.Forms.Label();
            this.experienceInput = new System.Windows.Forms.TextBox();
            this.resultInput = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQualification
            // 
            this.btnQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQualification.Location = new System.Drawing.Point(198, 406);
            this.btnQualification.Name = "btnQualification";
            this.btnQualification.Size = new System.Drawing.Size(183, 82);
            this.btnQualification.TabIndex = 2;
            this.btnQualification.Text = "Calculate Qual";
            this.btnQualification.UseVisualStyleBackColor = true;
            this.btnQualification.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnChangeBg
            // 
            this.btnChangeBg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeBg.Location = new System.Drawing.Point(387, 420);
            this.btnChangeBg.Name = "btnChangeBg";
            this.btnChangeBg.Size = new System.Drawing.Size(139, 55);
            this.btnChangeBg.TabIndex = 3;
            this.btnChangeBg.Text = "Change Bg";
            this.btnChangeBg.UseVisualStyleBackColor = true;
            this.btnChangeBg.Click += new System.EventHandler(this.btnChangeBg_Click);
            // 
            // SalaryInput
            // 
            this.SalaryInput.Location = new System.Drawing.Point(380, 60);
            this.SalaryInput.Multiline = true;
            this.SalaryInput.Name = "SalaryInput";
            this.SalaryInput.Size = new System.Drawing.Size(377, 43);
            this.SalaryInput.TabIndex = 0;
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(118, 60);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(229, 29);
            this.lblSalary.TabIndex = 6;
            this.lblSalary.Text = "Entery Your Salary";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(536, 420);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(73, 55);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblExpreience
            // 
            this.lblExpreience.AutoSize = true;
            this.lblExpreience.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblExpreience.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpreience.Location = new System.Drawing.Point(76, 142);
            this.lblExpreience.Name = "lblExpreience";
            this.lblExpreience.Size = new System.Drawing.Size(276, 29);
            this.lblExpreience.TabIndex = 7;
            this.lblExpreience.Text = "Enter Your Experience";
            // 
            // experienceInput
            // 
            this.experienceInput.Location = new System.Drawing.Point(380, 142);
            this.experienceInput.Multiline = true;
            this.experienceInput.Name = "experienceInput";
            this.experienceInput.Size = new System.Drawing.Size(377, 43);
            this.experienceInput.TabIndex = 1;
            // 
            // resultInput
            // 
            this.resultInput.Location = new System.Drawing.Point(76, 295);
            this.resultInput.Multiline = true;
            this.resultInput.Name = "resultInput";
            this.resultInput.Size = new System.Drawing.Size(681, 82);
            this.resultInput.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(266, 244);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(218, 32);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "Dicision Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoanApp.Properties.Resources.Gemini_Generated_Image_cbmiancbmiancbmi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(889, 530);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.resultInput);
            this.Controls.Add(this.lblExpreience);
            this.Controls.Add(this.experienceInput);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.SalaryInput);
            this.Controls.Add(this.btnChangeBg);
            this.Controls.Add(this.btnQualification);
            this.Name = "Form1";
            this.Text = "Week Four";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQualification;
        private System.Windows.Forms.Button btnChangeBg;
        private System.Windows.Forms.TextBox SalaryInput;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblExpreience;
        private System.Windows.Forms.TextBox experienceInput;
        private System.Windows.Forms.TextBox resultInput;
        private System.Windows.Forms.Label lblResult;
    }
}

