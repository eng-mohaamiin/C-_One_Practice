namespace AssigmentsFiles
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
            btnCreateFile = new Button();
            btnWrite = new Button();
            btnAppend = new Button();
            btnRead = new Button();
            btnReadAll = new Button();
            btnClear = new Button();
            btnExit = new Button();
            result = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // btnCreateFile
            // 
            btnCreateFile.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateFile.Location = new Point(34, 39);
            btnCreateFile.Name = "btnCreateFile";
            btnCreateFile.Size = new Size(135, 38);
            btnCreateFile.TabIndex = 0;
            btnCreateFile.Text = "Create File";
            btnCreateFile.UseVisualStyleBackColor = true;
            btnCreateFile.Click += btnCreateFile_Click;
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWrite.Location = new Point(213, 39);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(135, 38);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click_1;
            // 
            // btnAppend
            // 
            btnAppend.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAppend.Location = new Point(391, 39);
            btnAppend.Name = "btnAppend";
            btnAppend.Size = new Size(135, 38);
            btnAppend.TabIndex = 2;
            btnAppend.Text = "Append Text";
            btnAppend.UseVisualStyleBackColor = true;
            btnAppend.Click += btnAppend_Click;
            // 
            // btnRead
            // 
            btnRead.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRead.Location = new Point(571, 39);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(135, 38);
            btnRead.TabIndex = 3;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnReadAll
            // 
            btnReadAll.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadAll.Location = new Point(34, 108);
            btnReadAll.Name = "btnReadAll";
            btnReadAll.Size = new Size(135, 38);
            btnReadAll.TabIndex = 4;
            btnReadAll.Text = "Read All lines";
            btnReadAll.UseVisualStyleBackColor = true;
            btnReadAll.Click += btnReadAll_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.Location = new Point(391, 108);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(135, 38);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.Location = new Point(571, 108);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(135, 38);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // result
            // 
            result.FormattingEnabled = true;
            result.Location = new Point(34, 212);
            result.Name = "result";
            result.Size = new Size(672, 364);
            result.TabIndex = 8;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(213, 108);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(135, 38);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 642);
            Controls.Add(btnDelete);
            Controls.Add(result);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnReadAll);
            Controls.Add(btnRead);
            Controls.Add(btnAppend);
            Controls.Add(btnWrite);
            Controls.Add(btnCreateFile);
            Name = "Form1";
            Text = "Files";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCreateFile;
        private Button btnWrite;
        private Button btnAppend;
        private Button btnRead;
        private Button btnReadAll;
        private Button btnClear;
        private Button btnExit;
        private ListBox result;
        private Button btnDelete;
    }
}
