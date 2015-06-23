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
            this.components = new System.ComponentModel.Container();
            this.elsaImagePictureBox = new System.Windows.Forms.PictureBox();
            this.forwardDistanceComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.messageRichTextBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.elsaImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // elsaImagePictureBox
            // 
            this.elsaImagePictureBox.Image = global::example02.Properties.Resources.images;
            this.elsaImagePictureBox.Location = new System.Drawing.Point(16, 15);
            this.elsaImagePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.elsaImagePictureBox.Name = "elsaImagePictureBox";
            this.elsaImagePictureBox.Size = new System.Drawing.Size(88, 222);
            this.elsaImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.elsaImagePictureBox.TabIndex = 0;
            this.elsaImagePictureBox.TabStop = false;
            // 
            // forwardDistanceComboBox
            // 
            this.forwardDistanceComboBox.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.forwardDistanceComboBox.FormattingEnabled = true;
            this.forwardDistanceComboBox.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200"});
            this.forwardDistanceComboBox.Location = new System.Drawing.Point(84, 309);
            this.forwardDistanceComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.forwardDistanceComboBox.Name = "forwardDistanceComboBox";
            this.forwardDistanceComboBox.Size = new System.Drawing.Size(59, 32);
            this.forwardDistanceComboBox.TabIndex = 1;
            this.forwardDistanceComboBox.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 14F);
            this.label1.Location = new System.Drawing.Point(13, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "前進";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(16, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "執行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // animationTimer
            // 
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // messageRichTextBox
            // 
            this.messageRichTextBox.Location = new System.Drawing.Point(152, 309);
            this.messageRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageRichTextBox.Name = "messageRichTextBox";
            this.messageRichTextBox.Size = new System.Drawing.Size(419, 99);
            this.messageRichTextBox.TabIndex = 4;
            this.messageRichTextBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 612);
            this.Controls.Add(this.messageRichTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.forwardDistanceComboBox);
            this.Controls.Add(this.elsaImagePictureBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.elsaImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox elsaImagePictureBox;
        private System.Windows.Forms.ComboBox forwardDistanceComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.RichTextBox messageRichTextBox;
    }
}

