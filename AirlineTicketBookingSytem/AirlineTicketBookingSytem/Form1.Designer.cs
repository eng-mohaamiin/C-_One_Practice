namespace Assigment_TWO_Part2
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
            groupBox3 = new GroupBox();
            chkTravelInsurance = new CheckBox();
            BtnCalculate = new Button();
            BtnClear = new Button();
            BtnExit = new Button();
            LstResult = new ListBox();
            GrpRoomType = new GroupBox();
            RdoBusinessClass = new RadioButton();
            RdoNormalClass = new RadioButton();
            RdoFirstclass = new RadioButton();
            txtNumberOfTickets = new TextBox();
            txtPassengerAge = new TextBox();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            TxtName = new TextBox();
            txtBaggageWeight = new TextBox();
            label5 = new Label();
            label4 = new Label();
            LblHeaderName = new Label();
            groupBox3.SuspendLayout();
            GrpRoomType.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(chkTravelInsurance);
            groupBox3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(26, 535);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(594, 131);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Aditional Option";
            // 
            // chkTravelInsurance
            // 
            chkTravelInsurance.AutoSize = true;
            chkTravelInsurance.Location = new Point(37, 60);
            chkTravelInsurance.Margin = new Padding(3, 4, 3, 4);
            chkTravelInsurance.Name = "chkTravelInsurance";
            chkTravelInsurance.Size = new Size(398, 29);
            chkTravelInsurance.TabIndex = 1;
            chkTravelInsurance.Text = "Add Travel Insurance( $25 Per Tiket )";
            chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // BtnCalculate
            // 
            BtnCalculate.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCalculate.Location = new Point(26, 674);
            BtnCalculate.Margin = new Padding(3, 4, 3, 4);
            BtnCalculate.Name = "BtnCalculate";
            BtnCalculate.Size = new Size(241, 62);
            BtnCalculate.TabIndex = 26;
            BtnCalculate.Text = "Calculate";
            BtnCalculate.UseVisualStyleBackColor = true;
            BtnCalculate.Click += BtnCalculate_Click;
            // 
            // BtnClear
            // 
            BtnClear.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnClear.Location = new Point(288, 674);
            BtnClear.Margin = new Padding(3, 4, 3, 4);
            BtnClear.Name = "BtnClear";
            BtnClear.Size = new Size(214, 62);
            BtnClear.TabIndex = 27;
            BtnClear.Text = "Clear";
            BtnClear.UseVisualStyleBackColor = true;
            BtnClear.Click += BtnClear_Click;
            // 
            // BtnExit
            // 
            BtnExit.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnExit.Location = new Point(508, 674);
            BtnExit.Margin = new Padding(3, 4, 3, 4);
            BtnExit.Name = "BtnExit";
            BtnExit.Size = new Size(112, 62);
            BtnExit.TabIndex = 28;
            BtnExit.Text = "Exit";
            BtnExit.UseVisualStyleBackColor = true;
            BtnExit.Click += BtnExit_Click;
            // 
            // LstResult
            // 
            LstResult.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LstResult.FormattingEnabled = true;
            LstResult.ItemHeight = 18;
            LstResult.Items.AddRange(new object[] { "Airline Booking", "____________________________________________________________________________" });
            LstResult.Location = new Point(634, 101);
            LstResult.Margin = new Padding(3, 4, 3, 4);
            LstResult.Name = "LstResult";
            LstResult.Size = new Size(423, 634);
            LstResult.TabIndex = 29;
            // 
            // GrpRoomType
            // 
            GrpRoomType.Controls.Add(RdoBusinessClass);
            GrpRoomType.Controls.Add(RdoNormalClass);
            GrpRoomType.Controls.Add(RdoFirstclass);
            GrpRoomType.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GrpRoomType.Location = new Point(26, 388);
            GrpRoomType.Margin = new Padding(3, 4, 3, 4);
            GrpRoomType.Name = "GrpRoomType";
            GrpRoomType.Padding = new Padding(3, 4, 3, 4);
            GrpRoomType.Size = new Size(594, 121);
            GrpRoomType.TabIndex = 24;
            GrpRoomType.TabStop = false;
            GrpRoomType.Text = "Room Type";
            // 
            // RdoBusinessClass
            // 
            RdoBusinessClass.AutoSize = true;
            RdoBusinessClass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RdoBusinessClass.Location = new Point(396, 56);
            RdoBusinessClass.Margin = new Padding(3, 4, 3, 4);
            RdoBusinessClass.Name = "RdoBusinessClass";
            RdoBusinessClass.Size = new Size(182, 29);
            RdoBusinessClass.TabIndex = 17;
            RdoBusinessClass.TabStop = true;
            RdoBusinessClass.Text = "Business Class";
            RdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // RdoNormalClass
            // 
            RdoNormalClass.AutoSize = true;
            RdoNormalClass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RdoNormalClass.Location = new Point(207, 56);
            RdoNormalClass.Margin = new Padding(3, 4, 3, 4);
            RdoNormalClass.Name = "RdoNormalClass";
            RdoNormalClass.Size = new Size(162, 29);
            RdoNormalClass.TabIndex = 1;
            RdoNormalClass.TabStop = true;
            RdoNormalClass.Text = "Normal Class";
            RdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // RdoFirstclass
            // 
            RdoFirstclass.AutoSize = true;
            RdoFirstclass.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RdoFirstclass.Location = new Point(37, 56);
            RdoFirstclass.Margin = new Padding(3, 4, 3, 4);
            RdoFirstclass.Name = "RdoFirstclass";
            RdoFirstclass.Size = new Size(136, 29);
            RdoFirstclass.TabIndex = 0;
            RdoFirstclass.TabStop = true;
            RdoFirstclass.Text = "First Class";
            RdoFirstclass.UseVisualStyleBackColor = true;
            // 
            // txtNumberOfTickets
            // 
            txtNumberOfTickets.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNumberOfTickets.Location = new Point(263, 149);
            txtNumberOfTickets.Margin = new Padding(3, 4, 3, 4);
            txtNumberOfTickets.Name = "txtNumberOfTickets";
            txtNumberOfTickets.Size = new Size(314, 30);
            txtNumberOfTickets.TabIndex = 9;
            // 
            // txtPassengerAge
            // 
            txtPassengerAge.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassengerAge.Location = new Point(263, 101);
            txtPassengerAge.Margin = new Padding(3, 4, 3, 4);
            txtPassengerAge.Name = "txtPassengerAge";
            txtPassengerAge.Size = new Size(314, 30);
            txtPassengerAge.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.LightBlue;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(TxtName);
            groupBox1.Controls.Add(txtBaggageWeight);
            groupBox1.Controls.Add(txtPassengerAge);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtNumberOfTickets);
            groupBox1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(25, 108);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(595, 259);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 56);
            label2.Name = "label2";
            label2.Size = new Size(184, 25);
            label2.TabIndex = 15;
            label2.Text = "Passanger Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(75, 101);
            label3.Name = "label3";
            label3.Size = new Size(167, 25);
            label3.TabIndex = 14;
            label3.Text = "Passanger Age:";
            // 
            // TxtName
            // 
            TxtName.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtName.Location = new Point(263, 52);
            TxtName.Margin = new Padding(3, 4, 3, 4);
            TxtName.Name = "TxtName";
            TxtName.Size = new Size(314, 30);
            TxtName.TabIndex = 5;
            // 
            // txtBaggageWeight
            // 
            txtBaggageWeight.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtBaggageWeight.Location = new Point(263, 196);
            txtBaggageWeight.Margin = new Padding(3, 4, 3, 4);
            txtBaggageWeight.Name = "txtBaggageWeight";
            txtBaggageWeight.Size = new Size(314, 30);
            txtBaggageWeight.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 199);
            label5.Name = "label5";
            label5.Size = new Size(226, 25);
            label5.TabIndex = 10;
            label5.Text = "Baggage Weight(KG):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(48, 152);
            label4.Name = "label4";
            label4.Size = new Size(194, 25);
            label4.TabIndex = 8;
            label4.Text = "Number of Tickets:";
            // 
            // LblHeaderName
            // 
            LblHeaderName.BackColor = Color.MediumBlue;
            LblHeaderName.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblHeaderName.ForeColor = Color.White;
            LblHeaderName.Location = new Point(10, 11);
            LblHeaderName.Name = "LblHeaderName";
            LblHeaderName.Size = new Size(1047, 68);
            LblHeaderName.TabIndex = 22;
            LblHeaderName.Text = "Airline Ticket Booking System";
            LblHeaderName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1075, 774);
            Controls.Add(LstResult);
            Controls.Add(BtnExit);
            Controls.Add(BtnClear);
            Controls.Add(BtnCalculate);
            Controls.Add(groupBox3);
            Controls.Add(GrpRoomType);
            Controls.Add(groupBox1);
            Controls.Add(LblHeaderName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            GrpRoomType.ResumeLayout(false);
            GrpRoomType.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkTravelInsurance;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListBox LstResult;
        private System.Windows.Forms.GroupBox GrpRoomType;
        private System.Windows.Forms.RadioButton RdoBusinessClass;
        private System.Windows.Forms.RadioButton RdoNormalClass;
        private System.Windows.Forms.RadioButton RdoFirstclass;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblHeaderName;
    }
}

