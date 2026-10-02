namespace RestauranApplication
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
            this.Food1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_FoodOne = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.txt_priceOne = new System.Windows.Forms.TextBox();
            this.txt_Foodtwo = new System.Windows.Forms.TextBox();
            this.txt_priceTwo = new System.Windows.Forms.TextBox();
            this.txt_Amount_Tips = new System.Windows.Forms.TextBox();
            this.clearBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.salesTax = new System.Windows.Forms.TextBox();
            this.lbl_TipAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_TotalAmount = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl_NetAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Food1
            // 
            this.Food1.AutoSize = true;
            this.Food1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Food1.Location = new System.Drawing.Point(29, 36);
            this.Food1.Name = "Food1";
            this.Food1.Size = new System.Drawing.Size(181, 32);
            this.Food1.TabIndex = 0;
            this.Food1.Text = "Enter Food1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 1;
            // 
            // txt_FoodOne
            // 
            this.txt_FoodOne.Location = new System.Drawing.Point(290, 36);
            this.txt_FoodOne.Multiline = true;
            this.txt_FoodOne.Name = "txt_FoodOne";
            this.txt_FoodOne.Size = new System.Drawing.Size(679, 38);
            this.txt_FoodOne.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price Food 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Food 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price Food 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Enter amount tips";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(83, 422);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(243, 52);
            this.BtnCalculate.TabIndex = 11;
            this.BtnCalculate.Text = "Calculate Amount";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // txt_priceOne
            // 
            this.txt_priceOne.Location = new System.Drawing.Point(290, 101);
            this.txt_priceOne.Multiline = true;
            this.txt_priceOne.Name = "txt_priceOne";
            this.txt_priceOne.Size = new System.Drawing.Size(679, 38);
            this.txt_priceOne.TabIndex = 18;
            // 
            // txt_Foodtwo
            // 
            this.txt_Foodtwo.Location = new System.Drawing.Point(290, 181);
            this.txt_Foodtwo.Multiline = true;
            this.txt_Foodtwo.Name = "txt_Foodtwo";
            this.txt_Foodtwo.Size = new System.Drawing.Size(679, 38);
            this.txt_Foodtwo.TabIndex = 19;
            // 
            // txt_priceTwo
            // 
            this.txt_priceTwo.Location = new System.Drawing.Point(290, 265);
            this.txt_priceTwo.Multiline = true;
            this.txt_priceTwo.Name = "txt_priceTwo";
            this.txt_priceTwo.Size = new System.Drawing.Size(679, 38);
            this.txt_priceTwo.TabIndex = 20;
            this.txt_priceTwo.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txt_Amount_Tips
            // 
            this.txt_Amount_Tips.Location = new System.Drawing.Point(290, 341);
            this.txt_Amount_Tips.Multiline = true;
            this.txt_Amount_Tips.Name = "txt_Amount_Tips";
            this.txt_Amount_Tips.Size = new System.Drawing.Size(679, 38);
            this.txt_Amount_Tips.TabIndex = 21;
            // 
            // clearBtn
            // 
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(404, 422);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(165, 52);
            this.clearBtn.TabIndex = 22;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(608, 422);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(234, 52);
            this.closeBtn.TabIndex = 23;
            this.closeBtn.Text = "closebtn";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(189, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Salex Text is";
            // 
            // salesTax
            // 
            this.salesTax.Location = new System.Drawing.Point(290, 562);
            this.salesTax.Multiline = true;
            this.salesTax.Name = "salesTax";
            this.salesTax.Size = new System.Drawing.Size(679, 38);
            this.salesTax.TabIndex = 25;
            // 
            // lbl_TipAmount
            // 
            this.lbl_TipAmount.Location = new System.Drawing.Point(290, 651);
            this.lbl_TipAmount.Multiline = true;
            this.lbl_TipAmount.Name = "lbl_TipAmount";
            this.lbl_TipAmount.Size = new System.Drawing.Size(679, 38);
            this.lbl_TipAmount.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 641);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 32);
            this.label7.TabIndex = 26;
            this.label7.Text = "Tipss Amount";
            // 
            // lbl_TotalAmount
            // 
            this.lbl_TotalAmount.Location = new System.Drawing.Point(290, 727);
            this.lbl_TotalAmount.Multiline = true;
            this.lbl_TotalAmount.Name = "lbl_TotalAmount";
            this.lbl_TotalAmount.Size = new System.Drawing.Size(679, 38);
            this.lbl_TotalAmount.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 733);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 32);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 828);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(243, 32);
            this.label9.TabIndex = 31;
            this.label9.Text = "Total net amount";
            // 
            // lbl_NetAmount
            // 
            this.lbl_NetAmount.Location = new System.Drawing.Point(290, 822);
            this.lbl_NetAmount.Multiline = true;
            this.lbl_NetAmount.Name = "lbl_NetAmount";
            this.lbl_NetAmount.Size = new System.Drawing.Size(679, 38);
            this.lbl_NetAmount.TabIndex = 30;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 936);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbl_NetAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_TotalAmount);
            this.Controls.Add(this.lbl_TipAmount);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.salesTax);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.txt_Amount_Tips);
            this.Controls.Add(this.txt_priceTwo);
            this.Controls.Add(this.txt_Foodtwo);
            this.Controls.Add(this.txt_priceOne);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_FoodOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Food1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Food1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_FoodOne;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox txt_priceOne;
        private System.Windows.Forms.TextBox txt_Foodtwo;
        private System.Windows.Forms.TextBox txt_priceTwo;
        private System.Windows.Forms.TextBox txt_Amount_Tips;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox salesTax;
        private System.Windows.Forms.TextBox lbl_TipAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lbl_TotalAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lbl_NetAmount;
    }
}

