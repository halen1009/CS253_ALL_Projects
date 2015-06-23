namespace WindowsFormsApplication1
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
            this.inputButton1 = new System.Windows.Forms.Button();
            this.inputButton2 = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.scenePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputButton1
            // 
            this.inputButton1.Font = new System.Drawing.Font("新細明體", 12F);
            this.inputButton1.Location = new System.Drawing.Point(248, 331);
            this.inputButton1.Name = "inputButton1";
            this.inputButton1.Size = new System.Drawing.Size(44, 32);
            this.inputButton1.TabIndex = 0;
            this.inputButton1.Text = "1";
            this.inputButton1.UseVisualStyleBackColor = true;
            this.inputButton1.Click += new System.EventHandler(this.inputButton1_Click);
            // 
            // inputButton2
            // 
            this.inputButton2.Font = new System.Drawing.Font("新細明體", 12F);
            this.inputButton2.Location = new System.Drawing.Point(298, 331);
            this.inputButton2.Name = "inputButton2";
            this.inputButton2.Size = new System.Drawing.Size(43, 32);
            this.inputButton2.TabIndex = 1;
            this.inputButton2.Text = "2";
            this.inputButton2.UseVisualStyleBackColor = true;
            this.inputButton2.Click += new System.EventHandler(this.inputButton2_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("新細明體", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.messageLabel.Location = new System.Drawing.Point(12, 335);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(134, 24);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "請選擇1或2";
            // 
            // scenePictureBox
            // 
            this.scenePictureBox.Image = global::WindowsFormsApplication1.Properties.Resources.scene0;
            this.scenePictureBox.Location = new System.Drawing.Point(13, 13);
            this.scenePictureBox.Name = "scenePictureBox";
            this.scenePictureBox.Size = new System.Drawing.Size(328, 308);
            this.scenePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scenePictureBox.TabIndex = 3;
            this.scenePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 371);
            this.Controls.Add(this.scenePictureBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.inputButton2);
            this.Controls.Add(this.inputButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputButton1;
        private System.Windows.Forms.Button inputButton2;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.PictureBox scenePictureBox;
    }
}

