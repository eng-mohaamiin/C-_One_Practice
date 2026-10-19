namespace HotelRoomBookingSytem
{
    partial class FormBooking
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
            RoomHeader = new Panel();
            lblHeaderText = new Label();
            lblGuesInfo = new Label();
            lblGuesName = new Label();
            lblGuesAge = new Label();
            lblGuesNights = new Label();
            lblGuesNumber = new Label();
            inputGuestName = new TextBox();
            inputAge = new TextBox();
            inputNight = new TextBox();
            inputGuestNumber = new TextBox();
            radioBtnStandard = new RadioButton();
            radioBtnNormal = new RadioButton();
            radioBtnHight = new RadioButton();
            radioBtnBreakFast = new RadioButton();
            button1 = new Button();
            clearBtn = new Button();
            exitBtn = new Button();
            textResult = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            RoomHeader.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // RoomHeader
            // 
            RoomHeader.BackColor = Color.Navy;
            RoomHeader.Controls.Add(lblHeaderText);
            RoomHeader.Location = new Point(-3, 0);
            RoomHeader.Name = "RoomHeader";
            RoomHeader.Size = new Size(1192, 49);
            RoomHeader.TabIndex = 0;
            // 
            // lblHeaderText
            // 
            lblHeaderText.AutoSize = true;
            lblHeaderText.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeaderText.ForeColor = SystemColors.ButtonFace;
            lblHeaderText.Location = new Point(408, 3);
            lblHeaderText.Name = "lblHeaderText";
            lblHeaderText.Size = new Size(394, 38);
            lblHeaderText.TabIndex = 1;
            lblHeaderText.Text = "Hotel Room Booking System";
            // 
            // lblGuesInfo
            // 
            lblGuesInfo.AutoSize = true;
            lblGuesInfo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuesInfo.ForeColor = SystemColors.ActiveCaptionText;
            lblGuesInfo.Location = new Point(12, 89);
            lblGuesInfo.Name = "lblGuesInfo";
            lblGuesInfo.Size = new Size(185, 28);
            lblGuesInfo.TabIndex = 2;
            lblGuesInfo.Text = "Guest Information";
            // 
            // lblGuesName
            // 
            lblGuesName.AutoSize = true;
            lblGuesName.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuesName.ForeColor = SystemColors.ActiveCaptionText;
            lblGuesName.Location = new Point(91, 161);
            lblGuesName.Name = "lblGuesName";
            lblGuesName.Size = new Size(137, 28);
            lblGuesName.TabIndex = 3;
            lblGuesName.Text = "Gues Name : ";
            // 
            // lblGuesAge
            // 
            lblGuesAge.AutoSize = true;
            lblGuesAge.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuesAge.ForeColor = SystemColors.ActiveCaptionText;
            lblGuesAge.Location = new Point(91, 208);
            lblGuesAge.Name = "lblGuesAge";
            lblGuesAge.Size = new Size(135, 28);
            lblGuesAge.TabIndex = 4;
            lblGuesAge.Text = "Guesst Age : ";
            // 
            // lblGuesNights
            // 
            lblGuesNights.AutoSize = true;
            lblGuesNights.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuesNights.ForeColor = SystemColors.ActiveCaptionText;
            lblGuesNights.Location = new Point(53, 249);
            lblGuesNights.Name = "lblGuesNights";
            lblGuesNights.Size = new Size(175, 28);
            lblGuesNights.TabIndex = 5;
            lblGuesNights.Text = "Guest Of Nights :";
            lblGuesNights.Click += lblGuesNights_Click;
            // 
            // lblGuesNumber
            // 
            lblGuesNumber.AutoSize = true;
            lblGuesNumber.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGuesNumber.ForeColor = SystemColors.ActiveCaptionText;
            lblGuesNumber.Location = new Point(30, 300);
            lblGuesNumber.Name = "lblGuesNumber";
            lblGuesNumber.Size = new Size(186, 28);
            lblGuesNumber.TabIndex = 6;
            lblGuesNumber.Text = "Number of Guest :";
            // 
            // inputGuestName
            // 
            inputGuestName.Location = new Point(227, 161);
            inputGuestName.Multiline = true;
            inputGuestName.Name = "inputGuestName";
            inputGuestName.Size = new Size(312, 28);
            inputGuestName.TabIndex = 7;
            // 
            // inputAge
            // 
            inputAge.Location = new Point(227, 208);
            inputAge.Multiline = true;
            inputAge.Name = "inputAge";
            inputAge.Size = new Size(312, 28);
            inputAge.TabIndex = 8;
            // 
            // inputNight
            // 
            inputNight.Location = new Point(227, 253);
            inputNight.Multiline = true;
            inputNight.Name = "inputNight";
            inputNight.Size = new Size(312, 28);
            inputNight.TabIndex = 9;
            // 
            // inputGuestNumber
            // 
            inputGuestNumber.Location = new Point(227, 304);
            inputGuestNumber.Multiline = true;
            inputGuestNumber.Name = "inputGuestNumber";
            inputGuestNumber.Size = new Size(312, 28);
            inputGuestNumber.TabIndex = 10;
            // 
            // radioBtnStandard
            // 
            radioBtnStandard.AutoSize = true;
            radioBtnStandard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnStandard.Location = new Point(56, 33);
            radioBtnStandard.Name = "radioBtnStandard";
            radioBtnStandard.Size = new Size(113, 32);
            radioBtnStandard.TabIndex = 12;
            radioBtnStandard.TabStop = true;
            radioBtnStandard.Text = "Standard";
            radioBtnStandard.UseVisualStyleBackColor = true;
            // 
            // radioBtnNormal
            // 
            radioBtnNormal.AutoSize = true;
            radioBtnNormal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnNormal.Location = new Point(216, 33);
            radioBtnNormal.Name = "radioBtnNormal";
            radioBtnNormal.Size = new Size(100, 32);
            radioBtnNormal.TabIndex = 13;
            radioBtnNormal.TabStop = true;
            radioBtnNormal.Text = "Normal";
            radioBtnNormal.UseVisualStyleBackColor = true;
            // 
            // radioBtnHight
            // 
            radioBtnHight.AutoSize = true;
            radioBtnHight.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnHight.Location = new Point(368, 33);
            radioBtnHight.Name = "radioBtnHight";
            radioBtnHight.Size = new Size(84, 32);
            radioBtnHight.TabIndex = 14;
            radioBtnHight.TabStop = true;
            radioBtnHight.Text = "Hight";
            radioBtnHight.UseVisualStyleBackColor = true;
            // 
            // radioBtnBreakFast
            // 
            radioBtnBreakFast.AutoSize = true;
            radioBtnBreakFast.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnBreakFast.Location = new Point(23, 36);
            radioBtnBreakFast.Name = "radioBtnBreakFast";
            radioBtnBreakFast.Size = new Size(309, 32);
            radioBtnBreakFast.TabIndex = 17;
            radioBtnBreakFast.TabStop = true;
            radioBtnBreakFast.Text = "BreakFast(10 Per Guest nights)";
            radioBtnBreakFast.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(155, 634);
            button1.Name = "button1";
            button1.Size = new Size(171, 48);
            button1.TabIndex = 18;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clearBtn
            // 
            clearBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clearBtn.Location = new Point(368, 634);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(171, 48);
            clearBtn.TabIndex = 19;
            clearBtn.Text = "Clear";
            clearBtn.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            exitBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.Location = new Point(580, 634);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(171, 48);
            exitBtn.TabIndex = 20;
            exitBtn.Text = "Exit";
            exitBtn.UseVisualStyleBackColor = true;
            // 
            // textResult
            // 
            textResult.Location = new Point(713, 66);
            textResult.Multiline = true;
            textResult.Name = "textResult";
            textResult.Size = new Size(458, 499);
            textResult.TabIndex = 22;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioBtnHight);
            groupBox1.Controls.Add(radioBtnNormal);
            groupBox1.Controls.Add(radioBtnStandard);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(11, 392);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(560, 92);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Room  Type";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioBtnBreakFast);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(30, 516);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(358, 74);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Addition Option";
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1183, 707);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(textResult);
            Controls.Add(exitBtn);
            Controls.Add(clearBtn);
            Controls.Add(button1);
            Controls.Add(inputGuestNumber);
            Controls.Add(inputNight);
            Controls.Add(inputAge);
            Controls.Add(inputGuestName);
            Controls.Add(lblGuesNumber);
            Controls.Add(lblGuesNights);
            Controls.Add(lblGuesAge);
            Controls.Add(lblGuesName);
            Controls.Add(lblGuesInfo);
            Controls.Add(RoomHeader);
            Name = "FormBooking";
            Text = "Booking";
            RoomHeader.ResumeLayout(false);
            RoomHeader.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel RoomHeader;
        private Label lblHeaderText;
        private Label lblGuesInfo;
        private Label lblGuesName;
        private Label lblGuesAge;
        private Label lblGuesNights;
        private Label lblGuesNumber;
        private TextBox inputGuestName;
        private TextBox inputAge;
        private TextBox inputNight;
        private TextBox inputGuestNumber;
        private RadioButton radioBtnStandard;
        private RadioButton radioBtnNormal;
        private RadioButton radioBtnHight;
        private RadioButton radioBtnBreakFast;
        private Button button1;
        private Button clearBtn;
        private Button exitBtn;
        private Panel resultpanel;
        private TextBox textResult;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}
