namespace Vehicle_Rental_Maanagement_System
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
            panel1 = new Panel();
            lblHeaderText = new Label();
            lblCustomInfo = new Label();
            lblCustomerName = new Label();
            lblCustomerAge = new Label();
            lblRentDays = new Label();
            lblYearsDrvingExprience = new Label();
            textName = new TextBox();
            txtAge = new TextBox();
            txtDays = new TextBox();
            txtExperience = new TextBox();
            lblType = new Label();
            label1 = new Label();
            radioBtnEconomy = new RadioButton();
            radioBtnSuv = new RadioButton();
            label2 = new Label();
            radioBtnLuxury = new RadioButton();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnCalculate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            checkboxInsurance = new CheckBox();
            result = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(lblHeaderText);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1015, 47);
            panel1.TabIndex = 0;
            // 
            // lblHeaderText
            // 
            lblHeaderText.AutoSize = true;
            lblHeaderText.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderText.ForeColor = SystemColors.ButtonHighlight;
            lblHeaderText.Location = new Point(258, 9);
            lblHeaderText.Name = "lblHeaderText";
            lblHeaderText.Size = new Size(407, 31);
            lblHeaderText.TabIndex = 1;
            lblHeaderText.Text = "Vehicle Rental Maanagement System";
            // 
            // lblCustomInfo
            // 
            lblCustomInfo.AutoSize = true;
            lblCustomInfo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomInfo.ForeColor = Color.CornflowerBlue;
            lblCustomInfo.Location = new Point(22, 107);
            lblCustomInfo.Name = "lblCustomInfo";
            lblCustomInfo.Size = new Size(200, 25);
            lblCustomInfo.TabIndex = 2;
            lblCustomInfo.Text = "Customer Information";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerName.ForeColor = SystemColors.ActiveCaptionText;
            lblCustomerName.Location = new Point(60, 160);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(156, 25);
            lblCustomerName.TabIndex = 3;
            lblCustomerName.Text = "Customer Name: ";
            // 
            // lblCustomerAge
            // 
            lblCustomerAge.AutoSize = true;
            lblCustomerAge.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerAge.ForeColor = SystemColors.ActiveCaptionText;
            lblCustomerAge.Location = new Point(60, 206);
            lblCustomerAge.Name = "lblCustomerAge";
            lblCustomerAge.Size = new Size(135, 25);
            lblCustomerAge.TabIndex = 4;
            lblCustomerAge.Text = "Customer Age:";
            // 
            // lblRentDays
            // 
            lblRentDays.AutoSize = true;
            lblRentDays.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRentDays.ForeColor = SystemColors.ActiveCaptionText;
            lblRentDays.Location = new Point(60, 251);
            lblRentDays.Name = "lblRentDays";
            lblRentDays.Size = new Size(217, 25);
            lblRentDays.TabIndex = 5;
            lblRentDays.Text = "Number Of Rental Days: ";
            // 
            // lblYearsDrvingExprience
            // 
            lblYearsDrvingExprience.AutoSize = true;
            lblYearsDrvingExprience.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblYearsDrvingExprience.ForeColor = SystemColors.ActiveCaptionText;
            lblYearsDrvingExprience.Location = new Point(60, 297);
            lblYearsDrvingExprience.Name = "lblYearsDrvingExprience";
            lblYearsDrvingExprience.Size = new Size(249, 25);
            lblYearsDrvingExprience.TabIndex = 6;
            lblYearsDrvingExprience.Text = "Years Of Driving Experience: ";
            // 
            // textName
            // 
            textName.Location = new Point(316, 161);
            textName.Multiline = true;
            textName.Name = "textName";
            textName.Size = new Size(232, 36);
            textName.TabIndex = 7;
            textName.TextChanged += textName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(316, 203);
            txtAge.Multiline = true;
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(232, 36);
            txtAge.TabIndex = 8;
            // 
            // txtDays
            // 
            txtDays.Location = new Point(316, 245);
            txtDays.Multiline = true;
            txtDays.Name = "txtDays";
            txtDays.Size = new Size(232, 36);
            txtDays.TabIndex = 9;
            // 
            // txtExperience
            // 
            txtExperience.Location = new Point(315, 287);
            txtExperience.Multiline = true;
            txtExperience.Name = "txtExperience";
            txtExperience.Size = new Size(232, 36);
            txtExperience.TabIndex = 10;
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblType.ForeColor = Color.CornflowerBlue;
            lblType.Location = new Point(60, 359);
            lblType.Name = "lblType";
            lblType.Size = new Size(119, 25);
            lblType.TabIndex = 12;
            lblType.Text = "Vehicle Type";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(103, 396);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 13;
            label1.Text = "rdoeconomy";
            // 
            // radioBtnEconomy
            // 
            radioBtnEconomy.AutoSize = true;
            radioBtnEconomy.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnEconomy.Location = new Point(82, 434);
            radioBtnEconomy.Name = "radioBtnEconomy";
            radioBtnEconomy.Size = new Size(116, 32);
            radioBtnEconomy.TabIndex = 14;
            radioBtnEconomy.TabStop = true;
            radioBtnEconomy.Text = "Economy";
            radioBtnEconomy.UseVisualStyleBackColor = true;
            // 
            // radioBtnSuv
            // 
            radioBtnSuv.AutoSize = true;
            radioBtnSuv.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnSuv.Location = new Point(260, 434);
            radioBtnSuv.Name = "radioBtnSuv";
            radioBtnSuv.Size = new Size(64, 32);
            radioBtnSuv.TabIndex = 16;
            radioBtnSuv.TabStop = true;
            radioBtnSuv.Text = "suv";
            radioBtnSuv.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(281, 396);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 15;
            label2.Text = "rdosuv";
            // 
            // radioBtnLuxury
            // 
            radioBtnLuxury.AutoSize = true;
            radioBtnLuxury.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnLuxury.Location = new Point(431, 434);
            radioBtnLuxury.Name = "radioBtnLuxury";
            radioBtnLuxury.Size = new Size(95, 32);
            radioBtnLuxury.TabIndex = 18;
            radioBtnLuxury.TabStop = true;
            radioBtnLuxury.Text = "Luxury";
            radioBtnLuxury.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(452, 396);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 17;
            label3.Text = "rdoluxury";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.car_image1_removebg_preview;
            pictureBox1.Location = new Point(60, 472);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(147, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.car_image4_removebg_preview;
            pictureBox2.Location = new Point(231, 472);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(165, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.car_image3_removebg_preview;
            pictureBox3.Location = new Point(422, 476);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(125, 62);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // btnCalculate
            // 
            btnCalculate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalculate.Location = new Point(142, 721);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(182, 49);
            btnCalculate.TabIndex = 24;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(365, 721);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(182, 49);
            btnClear.TabIndex = 26;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(575, 721);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(182, 49);
            btnExit.TabIndex = 27;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkboxInsurance);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.CornflowerBlue;
            groupBox1.Location = new Point(60, 568);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(488, 87);
            groupBox1.TabIndex = 29;
            groupBox1.TabStop = false;
            groupBox1.Text = "Insurance Option";
            // 
            // checkboxInsurance
            // 
            checkboxInsurance.AutoSize = true;
            checkboxInsurance.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkboxInsurance.ForeColor = Color.Black;
            checkboxInsurance.Location = new Point(34, 41);
            checkboxInsurance.Name = "checkboxInsurance";
            checkboxInsurance.Size = new Size(171, 27);
            checkboxInsurance.TabIndex = 30;
            checkboxInsurance.Text = "Insurance Options";
            checkboxInsurance.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            result.Location = new Point(584, 70);
            result.Multiline = true;
            result.Name = "result";
            result.Size = new Size(357, 566);
            result.TabIndex = 30;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 801);
            Controls.Add(result);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(radioBtnLuxury);
            Controls.Add(label3);
            Controls.Add(radioBtnSuv);
            Controls.Add(label2);
            Controls.Add(radioBtnEconomy);
            Controls.Add(label1);
            Controls.Add(lblType);
            Controls.Add(txtExperience);
            Controls.Add(txtDays);
            Controls.Add(txtAge);
            Controls.Add(textName);
            Controls.Add(lblYearsDrvingExprience);
            Controls.Add(lblRentDays);
            Controls.Add(lblCustomerAge);
            Controls.Add(lblCustomerName);
            Controls.Add(lblCustomInfo);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Vehicle Rental Maanagement System";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblHeaderText;
        private Label lblCustomInfo;
        private Label lblCustomerName;
        private Label lblCustomerAge;
        private Label lblRentDays;
        private Label lblYearsDrvingExprience;
        private TextBox textName;
        private TextBox txtAge;
        private TextBox txtDays;
        private TextBox txtExperience;
        private Label lblType;
        private Label label1;
        private RadioButton radioBtnEconomy;
        private RadioButton radioBtnSuv;
        private Label label2;
        private RadioButton radioBtnLuxury;
        private Label label3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Button btnCalculate;
        private Button btnClear;
        private Button btnExit;
        private GroupBox groupBox1;
        private CheckBox checkboxInsurance;
        private TextBox result;
    }
}
