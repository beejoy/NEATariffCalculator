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
            this.cboAmpere = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsumedUnits = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Previous Reading:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Reading:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ampere Demand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 245);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Tariff:";
            // 
            // txtPrevReading
            // 
            this.txtPrevReading.Location = new System.Drawing.Point(176, 135);
            this.txtPrevReading.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrevReading.Name = "txtPrevReading";
            this.txtPrevReading.Size = new System.Drawing.Size(127, 29);
            this.txtPrevReading.TabIndex = 1;
            this.txtPrevReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCurrentReading
            // 
            this.txtCurrentReading.Location = new System.Drawing.Point(176, 98);
            this.txtCurrentReading.Margin = new System.Windows.Forms.Padding(4);
            this.txtCurrentReading.Name = "txtCurrentReading";
            this.txtCurrentReading.Size = new System.Drawing.Size(127, 29);
            this.txtCurrentReading.TabIndex = 0;
            this.txtCurrentReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTariff
            // 
            this.txtTariff.BackColor = System.Drawing.Color.White;
            this.txtTariff.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtTariff.Location = new System.Drawing.Point(176, 242);
            this.txtTariff.Margin = new System.Windows.Forms.Padding(4);
            this.txtTariff.Name = "txtTariff";
            this.txtTariff.ReadOnly = true;
            this.txtTariff.Size = new System.Drawing.Size(127, 29);
            this.txtTariff.TabIndex = 6;
            this.txtTariff.TabStop = false;
            this.txtTariff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboAmpere
            // 
            this.cboAmpere.BackColor = System.Drawing.Color.White;
            this.cboAmpere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAmpere.FormattingEnabled = true;
            this.cboAmpere.Items.AddRange(new object[] {
            "5A",
            "15A",
            "30A",
            "60A"});
            this.cboAmpere.Location = new System.Drawing.Point(176, 206);
            this.cboAmpere.Name = "cboAmpere";
            this.cboAmpere.Size = new System.Drawing.Size(127, 29);
            this.cboAmpere.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(44, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(244, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Single-phase, Low-voltage (230V)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(90, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tariff Calculator";
            // 
            // txtConsumedUnits
            // 
            this.txtConsumedUnits.BackColor = System.Drawing.Color.White;
            this.txtConsumedUnits.Location = new System.Drawing.Point(176, 171);
            this.txtConsumedUnits.Name = "txtConsumedUnits";
            this.txtConsumedUnits.ReadOnly = true;
            this.txtConsumedUnits.Size = new System.Drawing.Size(127, 29);
            this.txtConsumedUnits.TabIndex = 11;
            this.txtConsumedUnits.TabStop = false;
            this.txtConsumedUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 174);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Consumed Units:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(33, 300);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(270, 43);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 367);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtConsumedUnits);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboAmpere);
            this.Controls.Add(this.txtTariff);
            this.Controls.Add(this.txtCurrentReading);
            this.Controls.Add(this.txtPrevReading);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nepal Electricity Authoriy";
            this.Load += new System.EventHandler(this.MainForm_Load);
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
        private System.Windows.Forms.ComboBox cboAmpere;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsumedUnits;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalculate;
    }
}

