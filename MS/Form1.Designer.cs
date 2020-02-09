namespace MS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBheight = new System.Windows.Forms.TextBox();
            this.tBwidth = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rBtnDoor = new System.Windows.Forms.RadioButton();
            this.rBtnInside = new System.Windows.Forms.RadioButton();
            this.rBtnInvoice = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rBtnBrown = new System.Windows.Forms.RadioButton();
            this.rBtnWhite = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tBcost = new System.Windows.Forms.TextBox();
            this.chkBImpost = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBheight);
            this.groupBox1.Controls.Add(this.tBwidth);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 66);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размеры сетки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Высота";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ширина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(118, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Х";
            // 
            // tBheight
            // 
            this.tBheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBheight.Location = new System.Drawing.Point(152, 34);
            this.tBheight.Name = "tBheight";
            this.tBheight.Size = new System.Drawing.Size(100, 29);
            this.tBheight.TabIndex = 1;
            this.tBheight.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBheight_KeyDown);
            // 
            // tBwidth
            // 
            this.tBwidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBwidth.Location = new System.Drawing.Point(6, 34);
            this.tBwidth.Name = "tBwidth";
            this.tBwidth.Size = new System.Drawing.Size(100, 29);
            this.tBwidth.TabIndex = 0;
            this.tBwidth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBwidth_KeyDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rBtnDoor);
            this.groupBox2.Controls.Add(this.rBtnInside);
            this.groupBox2.Controls.Add(this.rBtnInvoice);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(258, 57);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип сетки";
            // 
            // rBtnDoor
            // 
            this.rBtnDoor.AutoSize = true;
            this.rBtnDoor.Location = new System.Drawing.Point(211, 32);
            this.rBtnDoor.Name = "rBtnDoor";
            this.rBtnDoor.Size = new System.Drawing.Size(14, 13);
            this.rBtnDoor.TabIndex = 5;
            this.rBtnDoor.TabStop = true;
            this.rBtnDoor.UseVisualStyleBackColor = true;
            this.rBtnDoor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rBtnDoor_KeyDown);
            // 
            // rBtnInside
            // 
            this.rBtnInside.AutoSize = true;
            this.rBtnInside.Location = new System.Drawing.Point(126, 32);
            this.rBtnInside.Name = "rBtnInside";
            this.rBtnInside.Size = new System.Drawing.Size(14, 13);
            this.rBtnInside.TabIndex = 4;
            this.rBtnInside.TabStop = true;
            this.rBtnInside.UseVisualStyleBackColor = true;
            this.rBtnInside.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rBtnInside_KeyDown);
            // 
            // rBtnInvoice
            // 
            this.rBtnInvoice.AutoSize = true;
            this.rBtnInvoice.Location = new System.Drawing.Point(37, 32);
            this.rBtnInvoice.Name = "rBtnInvoice";
            this.rBtnInvoice.Size = new System.Drawing.Size(14, 13);
            this.rBtnInvoice.TabIndex = 3;
            this.rBtnInvoice.TabStop = true;
            this.rBtnInvoice.UseVisualStyleBackColor = true;
            this.rBtnInvoice.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rBtnInvoice_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(190, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Дверная";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Внутренняя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Накладная";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rBtnBrown);
            this.groupBox3.Controls.Add(this.rBtnWhite);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(12, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(258, 65);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвет";
            // 
            // rBtnBrown
            // 
            this.rBtnBrown.AutoSize = true;
            this.rBtnBrown.Location = new System.Drawing.Point(173, 32);
            this.rBtnBrown.Name = "rBtnBrown";
            this.rBtnBrown.Size = new System.Drawing.Size(14, 13);
            this.rBtnBrown.TabIndex = 3;
            this.rBtnBrown.TabStop = true;
            this.rBtnBrown.UseVisualStyleBackColor = true;
            this.rBtnBrown.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rBtnBrown_KeyDown);
            // 
            // rBtnWhite
            // 
            this.rBtnWhite.AutoSize = true;
            this.rBtnWhite.Location = new System.Drawing.Point(49, 32);
            this.rBtnWhite.Name = "rBtnWhite";
            this.rBtnWhite.Size = new System.Drawing.Size(14, 13);
            this.rBtnWhite.TabIndex = 2;
            this.rBtnWhite.TabStop = true;
            this.rBtnWhite.UseVisualStyleBackColor = true;
            this.rBtnWhite.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rBtnWhite_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Коричневый";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Белый";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(285, 223);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 29);
            this.btnCalc.TabIndex = 4;
            this.btnCalc.Text = "Расчет";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(333, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(47, 23);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(40, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "Стоимость";
            // 
            // tBcost
            // 
            this.tBcost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tBcost.Location = new System.Drawing.Point(154, 223);
            this.tBcost.Name = "tBcost";
            this.tBcost.Size = new System.Drawing.Size(116, 29);
            this.tBcost.TabIndex = 7;
            // 
            // chkBImpost
            // 
            this.chkBImpost.AutoSize = true;
            this.chkBImpost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chkBImpost.ForeColor = System.Drawing.Color.Red;
            this.chkBImpost.Location = new System.Drawing.Point(295, 112);
            this.chkBImpost.Name = "chkBImpost";
            this.chkBImpost.Size = new System.Drawing.Size(82, 20);
            this.chkBImpost.TabIndex = 8;
            this.chkBImpost.Text = "Импост";
            this.chkBImpost.UseVisualStyleBackColor = true;
            this.chkBImpost.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chkBImpost_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.chkBImpost);
            this.Controls.Add(this.tBcost);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Расчет стоимости москитной сетки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBheight;
        private System.Windows.Forms.TextBox tBwidth;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rBtnDoor;
        private System.Windows.Forms.RadioButton rBtnInside;
        private System.Windows.Forms.RadioButton rBtnInvoice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rBtnBrown;
        private System.Windows.Forms.RadioButton rBtnWhite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tBcost;
        private System.Windows.Forms.CheckBox chkBImpost;
    }
}

