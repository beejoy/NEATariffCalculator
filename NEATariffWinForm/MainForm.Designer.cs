namespace NEATariffWinForm
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrevReading = new System.Windows.Forms.TextBox();
            this.txtCurrentReading = new System.Windows.Forms.TextBox();
            this.txtTariff = new System.Windows.Forms.TextBox();
            this.rad5A = new System.Windows.Forms.RadioButton();
            this.rad15A = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previous Reading:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Reading:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Energy Ampere:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Tariff:";
            // 
            // txtPrevReading
            // 
            this.txtPrevReading.Location = new System.Drawing.Point(185, 47);
            this.txtPrevReading.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrevReading.Name = "txtPrevReading";
            this.txtPrevReading.Size = new System.Drawing.Size(127, 29);
            this.txtPrevReading.TabIndex = 4;
            this.txtPrevReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrentReading
            // 
            this.txtCurrentReading.Location = new System.Drawing.Point(185, 84);
            this.txtCurrentReading.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentReading.Name = "txtCurrentReading";
            this.txtCurrentReading.Size = new System.Drawing.Size(127, 29);
            this.txtCurrentReading.TabIndex = 5;
            this.txtCurrentReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTariff
            // 
            this.txtTariff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTariff.Location = new System.Drawing.Point(185, 154);
            this.txtTariff.Margin = new System.Windows.Forms.Padding(4);
            this.txtTariff.Name = "txtTariff";
            this.txtTariff.ReadOnly = true;
            this.txtTariff.Size = new System.Drawing.Size(127, 29);
            this.txtTariff.TabIndex = 6;
            this.txtTariff.TabStop = false;
            this.txtTariff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rad5A
            // 
            this.rad5A.AutoSize = true;
            this.rad5A.Checked = true;
            this.rad5A.Location = new System.Drawing.Point(185, 121);
            this.rad5A.Margin = new System.Windows.Forms.Padding(4);
            this.rad5A.Name = "rad5A";
            this.rad5A.Size = new System.Drawing.Size(47, 25);
            this.rad5A.TabIndex = 7;
            this.rad5A.TabStop = true;
            this.rad5A.Text = "5A";
            this.rad5A.UseVisualStyleBackColor = true;
            // 
            // rad15A
            // 
            this.rad15A.AutoSize = true;
            this.rad15A.Location = new System.Drawing.Point(256, 121);
            this.rad15A.Margin = new System.Windows.Forms.Padding(4);
            this.rad15A.Name = "rad15A";
            this.rad15A.Size = new System.Drawing.Size(56, 25);
            this.rad15A.TabIndex = 8;
            this.rad15A.Text = "15A";
            this.rad15A.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(185, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(127, 44);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 296);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.rad15A);
            this.Controls.Add(this.rad5A);
            this.Controls.Add(this.txtTariff);
            this.Controls.Add(this.txtCurrentReading);
            this.Controls.Add(this.txtPrevReading);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Nepal Electricity Authoriy - Tariff Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrevReading;
        private System.Windows.Forms.TextBox txtCurrentReading;
        private System.Windows.Forms.TextBox txtTariff;
        private System.Windows.Forms.RadioButton rad5A;
        private System.Windows.Forms.RadioButton rad15A;
        private System.Windows.Forms.Button btnCalculate;
    }
}

