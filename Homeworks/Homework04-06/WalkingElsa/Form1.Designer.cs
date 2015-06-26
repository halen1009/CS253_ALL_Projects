namespace WalkingElsa
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
            this.startButton = new System.Windows.Forms.Button();
            this.forwardDistanceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.moveModeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startButton.Location = new System.Drawing.Point(251, 248);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(77, 28);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "開始";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // forwardDistanceComboBox
            // 
            this.forwardDistanceComboBox.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.forwardDistanceComboBox.FormattingEnabled = true;
            this.forwardDistanceComboBox.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200",
            "250",
            "300",
            "350",
            "400"});
            this.forwardDistanceComboBox.Location = new System.Drawing.Point(81, 248);
            this.forwardDistanceComboBox.Name = "forwardDistanceComboBox";
            this.forwardDistanceComboBox.Size = new System.Drawing.Size(121, 28);
            this.forwardDistanceComboBox.TabIndex = 1;
            this.forwardDistanceComboBox.Text = "100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "距離: ";
            // 
            // moveModeComboBox
            // 
            this.moveModeComboBox.Font = new System.Drawing.Font("新細明體", 12F);
            this.moveModeComboBox.FormattingEnabled = true;
            this.moveModeComboBox.Location = new System.Drawing.Point(81, 283);
            this.moveModeComboBox.Name = "moveModeComboBox";
            this.moveModeComboBox.Size = new System.Drawing.Size(121, 28);
            this.moveModeComboBox.TabIndex = 3;
            this.moveModeComboBox.Text = "直走";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 364);
            this.Controls.Add(this.moveModeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forwardDistanceComboBox);
            this.Controls.Add(this.startButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        public System.Windows.Forms.ComboBox forwardDistanceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox moveModeComboBox;

    }
}

