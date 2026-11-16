namespace Employee
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
            txtID = new TextBox();
            txtName = new TextBox();
            txtDepartment = new TextBox();
            lblDepartment = new Label();
            radioBtnPresent = new RadioButton();
            radioBtnAbsent = new RadioButton();
            btnSave = new Button();
            btnRead = new Button();
            btnRemove = new Button();
            btnCount = new Button();
            btnClear = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 27);
            label1.Name = "label1";
            label1.Size = new Size(119, 25);
            label1.TabIndex = 0;
            label1.Text = "Employee ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblName.Location = new Point(22, 86);
            lblName.Name = "lblName";
            lblName.Size = new Size(150, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Employee Name";
            lblName.Click += lblName_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(241, 28);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(260, 34);
            txtID.TabIndex = 2;
            txtID.TextChanged += textBox1_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(241, 86);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(260, 34);
            txtName.TabIndex = 3;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(241, 156);
            txtDepartment.Multiline = true;
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(260, 34);
            txtDepartment.TabIndex = 5;
            // 
            // lblDepartment
            // 
            lblDepartment.AutoSize = true;
            lblDepartment.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDepartment.Location = new Point(22, 156);
            lblDepartment.Name = "lblDepartment";
            lblDepartment.Size = new Size(123, 25);
            lblDepartment.TabIndex = 4;
            lblDepartment.Text = "Departments";
            // 
            // radioBtnPresent
            // 
            radioBtnPresent.AutoSize = true;
            radioBtnPresent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnPresent.Location = new Point(219, 36);
            radioBtnPresent.Name = "radioBtnPresent";
            radioBtnPresent.Size = new Size(104, 32);
            radioBtnPresent.TabIndex = 6;
            radioBtnPresent.TabStop = true;
            radioBtnPresent.Text = "Present";
            radioBtnPresent.UseVisualStyleBackColor = true;
            // 
            // radioBtnAbsent
            // 
            radioBtnAbsent.AutoSize = true;
            radioBtnAbsent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            radioBtnAbsent.Location = new Point(374, 36);
            radioBtnAbsent.Name = "radioBtnAbsent";
            radioBtnAbsent.Size = new Size(99, 32);
            radioBtnAbsent.TabIndex = 7;
            radioBtnAbsent.TabStop = true;
            radioBtnAbsent.Text = "Absent";
            radioBtnAbsent.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(13, 369);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(201, 44);
            btnSave.TabIndex = 9;
            btnSave.Text = "Attendence Record";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(253, 369);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(201, 44);
            btnRead.TabIndex = 10;
            btnRead.Text = "View From File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnRemove
            // 
            btnRemove.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(480, 369);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(201, 44);
            btnRemove.TabIndex = 11;
            btnRemove.Text = "Remove Selected";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click_1;
            // 
            // btnCount
            // 
            btnCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCount.Location = new Point(718, 369);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(111, 44);
            btnCount.TabIndex = 12;
            btnCount.Text = "Count";
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click_1;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(863, 369);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 44);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(1004, 369);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(111, 44);
            btnExit.TabIndex = 14;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioBtnPresent);
            groupBox1.Controls.Add(radioBtnAbsent);
            groupBox1.Location = new Point(22, 196);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(479, 125);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Attendence";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(645, 25);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(491, 284);
            listBox1.TabIndex = 16;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 434);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnCount);
            Controls.Add(btnRemove);
            Controls.Add(btnRead);
            Controls.Add(btnSave);
            Controls.Add(txtDepartment);
            Controls.Add(lblDepartment);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(lblName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblName;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtDepartment;
        private Label lblDepartment;
        private RadioButton radioBtnPresent;
        private RadioButton radioBtnAbsent;
        private Button btnSave;
        private Button btnRead;
        private Button btnRemove;
        private Button btnCount;
        private Button btnClear;
        private Button btnExit;
        private GroupBox groupBox1;
        private ListBox listBox1;
    }
}
