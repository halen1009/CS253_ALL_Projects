namespace WindowsFormsApplication4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.joeCashLabel = new System.Windows.Forms.Label();
            this.bobCashLabel = new System.Windows.Forms.Label();
            this.joeGiveCashButton = new System.Windows.Forms.Button();
            this.bobGiveCashButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Joe的現金：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bob的現金：";
            // 
            // joeCashLabel
            // 
            this.joeCashLabel.AutoSize = true;
            this.joeCashLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.joeCashLabel.Location = new System.Drawing.Point(138, 9);
            this.joeCashLabel.Name = "joeCashLabel";
            this.joeCashLabel.Size = new System.Drawing.Size(53, 20);
            this.joeCashLabel.TabIndex = 2;
            this.joeCashLabel.Text = "label3";
            // 
            // bobCashLabel
            // 
            this.bobCashLabel.AutoSize = true;
            this.bobCashLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.bobCashLabel.Location = new System.Drawing.Point(138, 38);
            this.bobCashLabel.Name = "bobCashLabel";
            this.bobCashLabel.Size = new System.Drawing.Size(53, 20);
            this.bobCashLabel.TabIndex = 3;
            this.bobCashLabel.Text = "label4";
            // 
            // joeGiveCashButton
            // 
            this.joeGiveCashButton.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.joeGiveCashButton.Location = new System.Drawing.Point(16, 156);
            this.joeGiveCashButton.Name = "joeGiveCashButton";
            this.joeGiveCashButton.Size = new System.Drawing.Size(109, 44);
            this.joeGiveCashButton.TabIndex = 4;
            this.joeGiveCashButton.Text = "Joe給Bob現金100元";
            this.joeGiveCashButton.UseVisualStyleBackColor = true;
            this.joeGiveCashButton.Click += new System.EventHandler(this.joeGiveCashButton_Click);
            // 
            // bobGiveCashButton
            // 
            this.bobGiveCashButton.Font = new System.Drawing.Font("新細明體", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.bobGiveCashButton.Location = new System.Drawing.Point(142, 156);
            this.bobGiveCashButton.Name = "bobGiveCashButton";
            this.bobGiveCashButton.Size = new System.Drawing.Size(109, 44);
            this.bobGiveCashButton.TabIndex = 5;
            this.bobGiveCashButton.Text = "Bob給Joe現金200元";
            this.bobGiveCashButton.UseVisualStyleBackColor = true;
            this.bobGiveCashButton.Click += new System.EventHandler(this.bobGiveCashButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.bobGiveCashButton);
            this.Controls.Add(this.joeGiveCashButton);
            this.Controls.Add(this.bobCashLabel);
            this.Controls.Add(this.joeCashLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label joeCashLabel;
        private System.Windows.Forms.Label bobCashLabel;
        private System.Windows.Forms.Button joeGiveCashButton;
        private System.Windows.Forms.Button bobGiveCashButton;
    }
}

