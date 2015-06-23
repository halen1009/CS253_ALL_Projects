namespace example02
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
            this.sayHelloButton = new System.Windows.Forms.Button();
            this.inputNameTextBox = new System.Windows.Forms.TextBox();
            this.messageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sayHelloButton
            // 
            this.sayHelloButton.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sayHelloButton.Location = new System.Drawing.Point(277, 35);
            this.sayHelloButton.Name = "sayHelloButton";
            this.sayHelloButton.Size = new System.Drawing.Size(154, 66);
            this.sayHelloButton.TabIndex = 0;
            this.sayHelloButton.Text = "打招呼";
            this.sayHelloButton.UseVisualStyleBackColor = true;
            this.sayHelloButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputNameTextBox
            // 
            this.inputNameTextBox.Font = new System.Drawing.Font("新細明體", 16F);
            this.inputNameTextBox.Location = new System.Drawing.Point(33, 35);
            this.inputNameTextBox.Name = "inputNameTextBox";
            this.inputNameTextBox.Size = new System.Drawing.Size(208, 39);
            this.inputNameTextBox.TabIndex = 2;
            this.inputNameTextBox.Text = "請輸入您的名字";
            this.inputNameTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.inputNameTextBox_MouseClick);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("新細明體", 16F);
            this.messageLabel.Location = new System.Drawing.Point(33, 109);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(74, 27);
            this.messageLabel.TabIndex = 3;
            this.messageLabel.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 158);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.inputNameTextBox);
            this.Controls.Add(this.sayHelloButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sayHelloButton;
        private System.Windows.Forms.TextBox inputNameTextBox;
        private System.Windows.Forms.Label messageLabel;
    }
}

