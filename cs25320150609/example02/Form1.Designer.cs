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
            this.sceneButton1 = new System.Windows.Forms.Button();
            this.sceneButton2 = new System.Windows.Forms.Button();
            this.messageLabel = new System.Windows.Forms.Label();
            this.scenePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sceneButton1
            // 
            this.sceneButton1.Font = new System.Drawing.Font("新細明體", 12F);
            this.sceneButton1.Location = new System.Drawing.Point(249, 424);
            this.sceneButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sceneButton1.Name = "sceneButton1";
            this.sceneButton1.Size = new System.Drawing.Size(57, 29);
            this.sceneButton1.TabIndex = 0;
            this.sceneButton1.Text = "1";
            this.sceneButton1.UseVisualStyleBackColor = true;
            this.sceneButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sceneButton2
            // 
            this.sceneButton2.Font = new System.Drawing.Font("新細明體", 12F);
            this.sceneButton2.Location = new System.Drawing.Point(315, 424);
            this.sceneButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sceneButton2.Name = "sceneButton2";
            this.sceneButton2.Size = new System.Drawing.Size(59, 29);
            this.sceneButton2.TabIndex = 1;
            this.sceneButton2.Text = "2";
            this.sceneButton2.UseVisualStyleBackColor = true;
            this.sceneButton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.messageLabel.Location = new System.Drawing.Point(16, 426);
            this.messageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(180, 27);
            this.messageLabel.TabIndex = 2;
            this.messageLabel.Text = "請選擇1或2：";
            // 
            // scenePictureBox
            // 
            this.scenePictureBox.Image = global::example02.Properties.Resources.scene0;
            this.scenePictureBox.Location = new System.Drawing.Point(16, 15);
            this.scenePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scenePictureBox.Name = "scenePictureBox";
            this.scenePictureBox.Size = new System.Drawing.Size(357, 374);
            this.scenePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scenePictureBox.TabIndex = 3;
            this.scenePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 472);
            this.Controls.Add(this.scenePictureBox);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.sceneButton2);
            this.Controls.Add(this.sceneButton1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.scenePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sceneButton1;
        private System.Windows.Forms.Button sceneButton2;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.PictureBox scenePictureBox;
    }
}

