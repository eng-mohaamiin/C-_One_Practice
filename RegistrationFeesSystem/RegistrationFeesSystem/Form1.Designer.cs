namespace RegistrationFeesSystem
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
            lblName = new Label();
            inputName = new TextBox();
            textId = new TextBox();
            lblId = new Label();
            textCourse = new TextBox();
            lblCourse = new Label();
            textLevel = new TextBox();
            lblLevel = new Label();
            textBoxTransportFee = new TextBox();
            lblfee = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            resultName = new TextBox();
            resultTranportFee = new TextBox();
            resultDiscount = new TextBox();
            resultId = new TextBox();
            resultTuitionFee = new TextBox();
            resultNumberOfCourse = new TextBox();
            resultFinalAmount = new TextBox();
            resultStudy = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(156, 36);
            label1.Name = "label1";
            label1.Size = new Size(240, 28);
            label1.TabIndex = 0;
            label1.Text = "Registration Fee System";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(21, 100);
            lblName.Name = "lblName";
            lblName.Size = new Size(207, 28);
            lblName.TabIndex = 1;
            lblName.Text = "Enter Student Name: ";
            lblName.Click += lblName_Click;
            // 
            // inputName
            // 
            inputName.Location = new Point(290, 104);
            inputName.Multiline = true;
            inputName.Name = "inputName";
            inputName.Size = new Size(291, 34);
            inputName.TabIndex = 2;
            // 
            // textId
            // 
            textId.Location = new Point(290, 159);
            textId.Multiline = true;
            textId.Name = "textId";
            textId.Size = new Size(291, 34);
            textId.TabIndex = 4;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblId.Location = new Point(21, 155);
            lblId.Name = "lblId";
            lblId.Size = new Size(171, 28);
            lblId.TabIndex = 3;
            lblId.Text = "Enter Student Id: ";
            // 
            // textCourse
            // 
            textCourse.Location = new Point(290, 220);
            textCourse.Multiline = true;
            textCourse.Name = "textCourse";
            textCourse.Size = new Size(291, 34);
            textCourse.TabIndex = 6;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCourse.Location = new Point(21, 216);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(248, 28);
            lblCourse.TabIndex = 5;
            lblCourse.Text = "Enter Number Of Course: ";
            // 
            // textLevel
            // 
            textLevel.Location = new Point(290, 277);
            textLevel.Multiline = true;
            textLevel.Name = "textLevel";
            textLevel.Size = new Size(291, 34);
            textLevel.TabIndex = 8;
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLevel.Location = new Point(21, 273);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(186, 28);
            lblLevel.TabIndex = 7;
            lblLevel.Text = "Entery Study Leve: ";
            // 
            // textBoxTransportFee
            // 
            textBoxTransportFee.Location = new Point(290, 336);
            textBoxTransportFee.Multiline = true;
            textBoxTransportFee.Name = "textBoxTransportFee";
            textBoxTransportFee.Size = new Size(291, 34);
            textBoxTransportFee.TabIndex = 10;
            // 
            // lblfee
            // 
            lblfee.AutoSize = true;
            lblfee.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfee.Location = new Point(21, 332);
            lblfee.Name = "lblfee";
            lblfee.Size = new Size(135, 28);
            lblfee.TabIndex = 9;
            lblfee.Text = "Tranport fee: ";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.ForestGreen;
            btnCalculate.ForeColor = SystemColors.ButtonHighlight;
            btnCalculate.Location = new Point(21, 437);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(154, 52);
            btnCalculate.TabIndex = 11;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Yellow;
            btnClear.Location = new Point(217, 437);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(154, 52);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.ForeColor = SystemColors.ButtonHighlight;
            btnExit.Location = new Point(427, 437);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(154, 52);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // resultName
            // 
            resultName.BackColor = Color.FromArgb(224, 224, 225);
            resultName.BorderStyle = BorderStyle.FixedSingle;
            resultName.Location = new Point(21, 586);
            resultName.Multiline = true;
            resultName.Name = "resultName";
            resultName.Size = new Size(260, 34);
            resultName.TabIndex = 14;
            // 
            // resultTranportFee
            // 
            resultTranportFee.BackColor = Color.FromArgb(224, 224, 225);
            resultTranportFee.BorderStyle = BorderStyle.FixedSingle;
            resultTranportFee.Location = new Point(315, 586);
            resultTranportFee.Multiline = true;
            resultTranportFee.Name = "resultTranportFee";
            resultTranportFee.Size = new Size(266, 34);
            resultTranportFee.TabIndex = 15;
            // 
            // resultDiscount
            // 
            resultDiscount.BackColor = Color.FromArgb(224, 224, 225);
            resultDiscount.BorderStyle = BorderStyle.FixedSingle;
            resultDiscount.Location = new Point(315, 647);
            resultDiscount.Multiline = true;
            resultDiscount.Name = "resultDiscount";
            resultDiscount.Size = new Size(266, 34);
            resultDiscount.TabIndex = 17;
            // 
            // resultId
            // 
            resultId.BackColor = Color.FromArgb(224, 224, 225);
            resultId.BorderStyle = BorderStyle.FixedSingle;
            resultId.Location = new Point(21, 647);
            resultId.Multiline = true;
            resultId.Name = "resultId";
            resultId.Size = new Size(260, 34);
            resultId.TabIndex = 16;
            // 
            // resultTuitionFee
            // 
            resultTuitionFee.BackColor = Color.FromArgb(224, 224, 225);
            resultTuitionFee.BorderStyle = BorderStyle.FixedSingle;
            resultTuitionFee.Location = new Point(315, 700);
            resultTuitionFee.Multiline = true;
            resultTuitionFee.Name = "resultTuitionFee";
            resultTuitionFee.Size = new Size(266, 34);
            resultTuitionFee.TabIndex = 19;
            // 
            // resultNumberOfCourse
            // 
            resultNumberOfCourse.BackColor = Color.FromArgb(224, 224, 225);
            resultNumberOfCourse.BorderStyle = BorderStyle.FixedSingle;
            resultNumberOfCourse.Location = new Point(21, 700);
            resultNumberOfCourse.Multiline = true;
            resultNumberOfCourse.Name = "resultNumberOfCourse";
            resultNumberOfCourse.Size = new Size(260, 34);
            resultNumberOfCourse.TabIndex = 18;
            // 
            // resultFinalAmount
            // 
            resultFinalAmount.BackColor = Color.FromArgb(224, 224, 225);
            resultFinalAmount.BorderStyle = BorderStyle.FixedSingle;
            resultFinalAmount.Location = new Point(315, 751);
            resultFinalAmount.Multiline = true;
            resultFinalAmount.Name = "resultFinalAmount";
            resultFinalAmount.Size = new Size(266, 34);
            resultFinalAmount.TabIndex = 21;
            // 
            // resultStudy
            // 
            resultStudy.BackColor = Color.FromArgb(224, 224, 225);
            resultStudy.BorderStyle = BorderStyle.FixedSingle;
            resultStudy.Location = new Point(21, 751);
            resultStudy.Multiline = true;
            resultStudy.Name = "resultStudy";
            resultStudy.Size = new Size(260, 34);
            resultStudy.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 929);
            Controls.Add(resultFinalAmount);
            Controls.Add(resultStudy);
            Controls.Add(resultTuitionFee);
            Controls.Add(resultNumberOfCourse);
            Controls.Add(resultDiscount);
            Controls.Add(resultId);
            Controls.Add(resultTranportFee);
            Controls.Add(resultName);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(textBoxTransportFee);
            Controls.Add(lblfee);
            Controls.Add(textLevel);
            Controls.Add(lblLevel);
            Controls.Add(textCourse);
            Controls.Add(lblCourse);
            Controls.Add(textId);
            Controls.Add(lblId);
            Controls.Add(inputName);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "University Registration";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private TextBox inputName;
        private TextBox textId;
        private Label lblId;
        private TextBox textCourse;
        private Label lblCourse;
        private TextBox textLevel;
        private Label lblLevel;
        private TextBox textBoxTransportFee;
        private Label lblfee;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private TextBox resultName;
        private TextBox resultTranportFee;
        private TextBox resultDiscount;
        private TextBox resultId;
        private TextBox resultTuitionFee;
        private TextBox resultNumberOfCourse;
        private TextBox resultFinalAmount;
        private TextBox resultStudy;
    }
}
