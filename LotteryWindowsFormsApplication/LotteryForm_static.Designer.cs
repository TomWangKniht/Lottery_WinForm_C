namespace LotteryWindowsFormsApplication
{
    partial class LotteryForm
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
            this.grpgroupBoxSet = new System.Windows.Forms.GroupBox();
            this.grpgroupBoxNumberGet = new System.Windows.Forms.GroupBox();
            this.CheckBoxSpecialNumber = new System.Windows.Forms.CheckBox();
            this.textBoxGetCount = new System.Windows.Forms.TextBox();
            this.ConstLabel4 = new System.Windows.Forms.Label();
            this.grpgroupBoxSource = new System.Windows.Forms.GroupBox();
            this.grpgroupBoxSourceValue = new System.Windows.Forms.GroupBox();
            this.textBoxEndNumber = new System.Windows.Forms.TextBox();
            this.Constabel3 = new System.Windows.Forms.Label();
            this.textBoxStartNumber = new System.Windows.Forms.TextBox();
            this.ConstLabel2 = new System.Windows.Forms.Label();
            this.ConstLabel1 = new System.Windows.Forms.Label();
            this.textBoxNumberCount = new System.Windows.Forms.TextBox();
            this.grpgroupBoxSourceType = new System.Windows.Forms.GroupBox();
            this.radioButtonCount = new System.Windows.Forms.RadioButton();
            this.radioButtonNumber = new System.Windows.Forms.RadioButton();
            this.buttonExe = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.ConstLabel5 = new System.Windows.Forms.Label();
            this.grpgroupBoxSet.SuspendLayout();
            this.grpgroupBoxNumberGet.SuspendLayout();
            this.grpgroupBoxSource.SuspendLayout();
            this.grpgroupBoxSourceValue.SuspendLayout();
            this.grpgroupBoxSourceType.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpgroupBoxSet
            // 
            this.grpgroupBoxSet.Controls.Add(this.grpgroupBoxNumberGet);
            this.grpgroupBoxSet.Controls.Add(this.grpgroupBoxSource);
            this.grpgroupBoxSet.Location = new System.Drawing.Point(12, 12);
            this.grpgroupBoxSet.Name = "grpgroupBoxSet";
            this.grpgroupBoxSet.Size = new System.Drawing.Size(563, 210);
            this.grpgroupBoxSet.TabIndex = 0;
            this.grpgroupBoxSet.TabStop = false;
            this.grpgroupBoxSet.Text = "設定區";
            // 
            // grpgroupBoxNumberGet
            // 
            this.grpgroupBoxNumberGet.Controls.Add(this.CheckBoxSpecialNumber);
            this.grpgroupBoxNumberGet.Controls.Add(this.textBoxGetCount);
            this.grpgroupBoxNumberGet.Controls.Add(this.ConstLabel4);
            this.grpgroupBoxNumberGet.Location = new System.Drawing.Point(346, 34);
            this.grpgroupBoxNumberGet.Name = "grpgroupBoxNumberGet";
            this.grpgroupBoxNumberGet.Size = new System.Drawing.Size(189, 161);
            this.grpgroupBoxNumberGet.TabIndex = 1;
            this.grpgroupBoxNumberGet.TabStop = false;
            this.grpgroupBoxNumberGet.Text = "取得號碼";
            // 
            // CheckBoxSpecialNumber
            // 
            this.CheckBoxSpecialNumber.AutoSize = true;
            this.CheckBoxSpecialNumber.Location = new System.Drawing.Point(17, 43);
            this.CheckBoxSpecialNumber.Name = "CheckBoxSpecialNumber";
            this.CheckBoxSpecialNumber.Size = new System.Drawing.Size(60, 16);
            this.CheckBoxSpecialNumber.TabIndex = 2;
            this.CheckBoxSpecialNumber.Text = "特別號";
            this.CheckBoxSpecialNumber.UseVisualStyleBackColor = true;
            // 
            // textBoxGetCount
            // 
            this.textBoxGetCount.Location = new System.Drawing.Point(74, 77);
            this.textBoxGetCount.Name = "textBoxGetCount";
            this.textBoxGetCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxGetCount.TabIndex = 1;
            this.textBoxGetCount.Text = "0";
            // 
            // ConstLabel4
            // 
            this.ConstLabel4.AutoSize = true;
            this.ConstLabel4.Location = new System.Drawing.Point(15, 80);
            this.ConstLabel4.Name = "ConstLabel4";
            this.ConstLabel4.Size = new System.Drawing.Size(29, 12);
            this.ConstLabel4.TabIndex = 0;
            this.ConstLabel4.Text = "個數";
            // 
            // grpgroupBoxSource
            // 
            this.grpgroupBoxSource.Controls.Add(this.grpgroupBoxSourceValue);
            this.grpgroupBoxSource.Controls.Add(this.grpgroupBoxSourceType);
            this.grpgroupBoxSource.Location = new System.Drawing.Point(16, 32);
            this.grpgroupBoxSource.Name = "grpgroupBoxSource";
            this.grpgroupBoxSource.Size = new System.Drawing.Size(314, 163);
            this.grpgroupBoxSource.TabIndex = 0;
            this.grpgroupBoxSource.TabStop = false;
            this.grpgroupBoxSource.Text = "來源號碼";
            // 
            // grpgroupBoxSourceValue
            // 
            this.grpgroupBoxSourceValue.Controls.Add(this.textBoxEndNumber);
            this.grpgroupBoxSourceValue.Controls.Add(this.Constabel3);
            this.grpgroupBoxSourceValue.Controls.Add(this.textBoxStartNumber);
            this.grpgroupBoxSourceValue.Controls.Add(this.ConstLabel2);
            this.grpgroupBoxSourceValue.Controls.Add(this.ConstLabel1);
            this.grpgroupBoxSourceValue.Controls.Add(this.textBoxNumberCount);
            this.grpgroupBoxSourceValue.Location = new System.Drawing.Point(115, 21);
            this.grpgroupBoxSourceValue.Name = "grpgroupBoxSourceValue";
            this.grpgroupBoxSourceValue.Size = new System.Drawing.Size(183, 113);
            this.grpgroupBoxSourceValue.TabIndex = 3;
            this.grpgroupBoxSourceValue.TabStop = false;
            this.grpgroupBoxSourceValue.Text = "數值";
            // 
            // textBoxEndNumber
            // 
            this.textBoxEndNumber.Location = new System.Drawing.Point(66, 86);
            this.textBoxEndNumber.Name = "textBoxEndNumber";
            this.textBoxEndNumber.ReadOnly = true;
            this.textBoxEndNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxEndNumber.TabIndex = 5;
            this.textBoxEndNumber.Text = "0";
            // 
            // Constabel3
            // 
            this.Constabel3.AutoSize = true;
            this.Constabel3.Location = new System.Drawing.Point(6, 89);
            this.Constabel3.Name = "Constabel3";
            this.Constabel3.Size = new System.Drawing.Size(53, 12);
            this.Constabel3.TabIndex = 4;
            this.Constabel3.Text = "結束號碼";
            // 
            // textBoxStartNumber
            // 
            this.textBoxStartNumber.Location = new System.Drawing.Point(66, 58);
            this.textBoxStartNumber.Name = "textBoxStartNumber";
            this.textBoxStartNumber.ReadOnly = true;
            this.textBoxStartNumber.Size = new System.Drawing.Size(100, 22);
            this.textBoxStartNumber.TabIndex = 3;
            this.textBoxStartNumber.Text = "0";
            // 
            // ConstLabel2
            // 
            this.ConstLabel2.AutoSize = true;
            this.ConstLabel2.Location = new System.Drawing.Point(6, 56);
            this.ConstLabel2.Name = "ConstLabel2";
            this.ConstLabel2.Size = new System.Drawing.Size(53, 12);
            this.ConstLabel2.TabIndex = 2;
            this.ConstLabel2.Text = "開始號碼";
            // 
            // ConstLabel1
            // 
            this.ConstLabel1.AutoSize = true;
            this.ConstLabel1.Location = new System.Drawing.Point(6, 25);
            this.ConstLabel1.Name = "ConstLabel1";
            this.ConstLabel1.Size = new System.Drawing.Size(29, 12);
            this.ConstLabel1.TabIndex = 1;
            this.ConstLabel1.Text = "個數";
            // 
            // textBoxNumberCount
            // 
            this.textBoxNumberCount.Location = new System.Drawing.Point(66, 21);
            this.textBoxNumberCount.Name = "textBoxNumberCount";
            this.textBoxNumberCount.Size = new System.Drawing.Size(100, 22);
            this.textBoxNumberCount.TabIndex = 0;
            this.textBoxNumberCount.Text = "0";
            // 
            // grpgroupBoxSourceType
            // 
            this.grpgroupBoxSourceType.Controls.Add(this.radioButtonCount);
            this.grpgroupBoxSourceType.Controls.Add(this.radioButtonNumber);
            this.grpgroupBoxSourceType.Location = new System.Drawing.Point(6, 21);
            this.grpgroupBoxSourceType.Name = "grpgroupBoxSourceType";
            this.grpgroupBoxSourceType.Size = new System.Drawing.Size(90, 126);
            this.grpgroupBoxSourceType.TabIndex = 2;
            this.grpgroupBoxSourceType.TabStop = false;
            this.grpgroupBoxSourceType.Text = "類型";
            // 
            // radioButtonCount
            // 
            this.radioButtonCount.AutoSize = true;
            this.radioButtonCount.Checked = true;
            this.radioButtonCount.Location = new System.Drawing.Point(6, 21);
            this.radioButtonCount.Name = "radioButtonCount";
            this.radioButtonCount.Size = new System.Drawing.Size(47, 16);
            this.radioButtonCount.TabIndex = 0;
            this.radioButtonCount.TabStop = true;
            this.radioButtonCount.Text = "個數";
            this.radioButtonCount.UseVisualStyleBackColor = true;
            this.radioButtonCount.CheckedChanged += new System.EventHandler(this.radioButtonCount_CheckedChanged);
            // 
            // radioButtonNumber
            // 
            this.radioButtonNumber.AutoSize = true;
            this.radioButtonNumber.Location = new System.Drawing.Point(6, 76);
            this.radioButtonNumber.Name = "radioButtonNumber";
            this.radioButtonNumber.Size = new System.Drawing.Size(71, 16);
            this.radioButtonNumber.TabIndex = 1;
            this.radioButtonNumber.Text = "號碼範圍";
            this.radioButtonNumber.UseVisualStyleBackColor = true;
            this.radioButtonNumber.CheckedChanged += new System.EventHandler(this.radioButtonNumber_CheckedChanged);
            // 
            // buttonExe
            // 
            this.buttonExe.Location = new System.Drawing.Point(251, 245);
            this.buttonExe.Name = "buttonExe";
            this.buttonExe.Size = new System.Drawing.Size(75, 23);
            this.buttonExe.TabIndex = 1;
            this.buttonExe.Text = "產生號碼";
            this.buttonExe.UseVisualStyleBackColor = true;
            this.buttonExe.Click += new System.EventHandler(this.buttonExe_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(28, 296);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(547, 77);
            this.textBoxResult.TabIndex = 3;
            this.textBoxResult.Text = "請於設定區完成設定，並點選產生號碼按鈕";
            // 
            // ConstLabel5
            // 
            this.ConstLabel5.AutoSize = true;
            this.ConstLabel5.Font = new System.Drawing.Font("PMingLiU", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ConstLabel5.Location = new System.Drawing.Point(247, 271);
            this.ConstLabel5.Name = "ConstLabel5";
            this.ConstLabel5.Size = new System.Drawing.Size(76, 22);
            this.ConstLabel5.TabIndex = 4;
            this.ConstLabel5.Text = "訊息區";
            // 
            // LotteryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 385);
            this.Controls.Add(this.ConstLabel5);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonExe);
            this.Controls.Add(this.grpgroupBoxSet);
            this.Name = "LotteryForm";
            this.Text = "樂透號碼產生器";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpgroupBoxSet.ResumeLayout(false);
            this.grpgroupBoxNumberGet.ResumeLayout(false);
            this.grpgroupBoxNumberGet.PerformLayout();
            this.grpgroupBoxSource.ResumeLayout(false);
            this.grpgroupBoxSourceValue.ResumeLayout(false);
            this.grpgroupBoxSourceValue.PerformLayout();
            this.grpgroupBoxSourceType.ResumeLayout(false);
            this.grpgroupBoxSourceType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpgroupBoxSet;
        private System.Windows.Forms.GroupBox grpgroupBoxSource;
        private System.Windows.Forms.RadioButton radioButtonNumber;
        private System.Windows.Forms.RadioButton radioButtonCount;
        private System.Windows.Forms.GroupBox grpgroupBoxSourceValue;
        private System.Windows.Forms.TextBox textBoxEndNumber;
        private System.Windows.Forms.Label Constabel3;
        private System.Windows.Forms.TextBox textBoxStartNumber;
        private System.Windows.Forms.Label ConstLabel2;
        private System.Windows.Forms.Label ConstLabel1;
        private System.Windows.Forms.TextBox textBoxNumberCount;
        private System.Windows.Forms.GroupBox grpgroupBoxSourceType;
        private System.Windows.Forms.GroupBox grpgroupBoxNumberGet;
        private System.Windows.Forms.CheckBox CheckBoxSpecialNumber;
        private System.Windows.Forms.TextBox textBoxGetCount;
        private System.Windows.Forms.Label ConstLabel4;
        private System.Windows.Forms.Button buttonExe;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label ConstLabel5;


    }
}

