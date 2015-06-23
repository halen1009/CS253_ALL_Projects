namespace example03
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
            this.joyGiveCashButton = new System.Windows.Forms.Button();
            this.bobGiveCashButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.joyCashLabel = new System.Windows.Forms.Label();
            this.bobCashLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // joyGiveCashButton
            // 
            this.joyGiveCashButton.Location = new System.Drawing.Point(39, 153);
            this.joyGiveCashButton.Name = "joyGiveCashButton";
            this.joyGiveCashButton.Size = new System.Drawing.Size(75, 70);
            this.joyGiveCashButton.TabIndex = 0;
            this.joyGiveCashButton.Text = "Joy借出100給Bob";
            this.joyGiveCashButton.UseVisualStyleBackColor = true;
            this.joyGiveCashButton.Click += new System.EventHandler(this.joyGiveCashButton_Click);
            // 
            // bobGiveCashButton
            // 
            this.bobGiveCashButton.Location = new System.Drawing.Point(164, 153);
            this.bobGiveCashButton.Name = "bobGiveCashButton";
            this.bobGiveCashButton.Size = new System.Drawing.Size(75, 70);
            this.bobGiveCashButton.TabIndex = 1;
            this.bobGiveCashButton.Text = "Bob借出200給Joy";
            this.bobGiveCashButton.UseVisualStyleBackColor = true;
            this.bobGiveCashButton.Click += new System.EventHandler(this.bobGiveCashButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(36, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Joy的現金有：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(36, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bob的現金有：";
            // 
            // joyCashLabel
            // 
            this.joyCashLabel.AutoSize = true;
            this.joyCashLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.joyCashLabel.Location = new System.Drawing.Point(177, 29);
            this.joyCashLabel.Name = "joyCashLabel";
            this.joyCashLabel.Size = new System.Drawing.Size(53, 20);
            this.joyCashLabel.TabIndex = 4;
            this.joyCashLabel.Text = "label3";
            // 
            // bobCashLabel
            // 
            this.bobCashLabel.AutoSize = true;
            this.bobCashLabel.Font = new System.Drawing.Font("新細明體", 12F);
            this.bobCashLabel.Location = new System.Drawing.Point(180, 48);
            this.bobCashLabel.Name = "bobCashLabel";
            this.bobCashLabel.Size = new System.Drawing.Size(53, 20);
            this.bobCashLabel.TabIndex = 5;
            this.bobCashLabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.bobCashLabel);
            this.Controls.Add(this.joyCashLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bobGiveCashButton);
            this.Controls.Add(this.joyGiveCashButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button joyGiveCashButton;
        private System.Windows.Forms.Button bobGiveCashButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label joyCashLabel;
        private System.Windows.Forms.Label bobCashLabel;
    }
}

