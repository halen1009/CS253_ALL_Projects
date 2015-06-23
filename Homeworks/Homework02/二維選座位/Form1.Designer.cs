namespace 二維選座位
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
            this.resetButton = new System.Windows.Forms.Button();
            this.chooseSeatButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnNoLabel = new System.Windows.Forms.Label();
            this.rowNoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.resetButton.Location = new System.Drawing.Point(188, 12);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(96, 33);
            this.resetButton.TabIndex = 0;
            this.resetButton.Text = "重設";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // chooseSeatButton
            // 
            this.chooseSeatButton.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chooseSeatButton.Location = new System.Drawing.Point(290, 12);
            this.chooseSeatButton.Name = "chooseSeatButton";
            this.chooseSeatButton.Size = new System.Drawing.Size(96, 33);
            this.chooseSeatButton.TabIndex = 1;
            this.chooseSeatButton.Text = "選位子";
            this.chooseSeatButton.UseVisualStyleBackColor = true;
            this.chooseSeatButton.Click += new System.EventHandler(this.chooseSeatButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "行數:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(100, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "列數:";
            // 
            // columnNoLabel
            // 
            this.columnNoLabel.AutoSize = true;
            this.columnNoLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.columnNoLabel.Location = new System.Drawing.Point(75, 25);
            this.columnNoLabel.Name = "columnNoLabel";
            this.columnNoLabel.Size = new System.Drawing.Size(19, 20);
            this.columnNoLabel.TabIndex = 4;
            this.columnNoLabel.Text = "9";
            // 
            // rowNoLabel
            // 
            this.rowNoLabel.AutoSize = true;
            this.rowNoLabel.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rowNoLabel.Location = new System.Drawing.Point(163, 25);
            this.rowNoLabel.Name = "rowNoLabel";
            this.rowNoLabel.Size = new System.Drawing.Size(19, 20);
            this.rowNoLabel.TabIndex = 5;
            this.rowNoLabel.Text = "3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 462);
            this.Controls.Add(this.rowNoLabel);
            this.Controls.Add(this.columnNoLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseSeatButton);
            this.Controls.Add(this.resetButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button chooseSeatButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label columnNoLabel;
        private System.Windows.Forms.Label rowNoLabel;

        //private System.Windows.Forms.PictureBox pictureBox1;
        //private System.Windows.Forms.PictureBox pictureBox2;
        //private System.Windows.Forms.PictureBox pictureBox3;
        //private System.Windows.Forms.PictureBox pictureBox4;
        //private System.Windows.Forms.PictureBox pictureBox5;
        //private System.Windows.Forms.PictureBox pictureBox6;
        //private System.Windows.Forms.PictureBox pictureBox7;
        //private System.Windows.Forms.PictureBox pictureBox8;
        //private System.Windows.Forms.PictureBox pictureBox9;
        //private System.Windows.Forms.PictureBox pictureBox10;
        //private System.Windows.Forms.PictureBox pictureBox11;
        //private System.Windows.Forms.PictureBox pictureBox12;
        //private System.Windows.Forms.PictureBox pictureBox13;
        //private System.Windows.Forms.PictureBox pictureBox14;
        //private System.Windows.Forms.PictureBox pictureBox15;
        //private System.Windows.Forms.PictureBox pictureBox16;
        //private System.Windows.Forms.PictureBox pictureBox17;
        //private System.Windows.Forms.PictureBox pictureBox18;
        //private System.Windows.Forms.PictureBox pictureBox19;
        //private System.Windows.Forms.PictureBox pictureBox20;
        //private System.Windows.Forms.PictureBox pictureBox21;
        //private System.Windows.Forms.PictureBox pictureBox22;
        //private System.Windows.Forms.PictureBox pictureBox23;
        //private System.Windows.Forms.PictureBox pictureBox24;
        //private System.Windows.Forms.PictureBox pictureBox25;
        //private System.Windows.Forms.PictureBox pictureBox26;
        //private System.Windows.Forms.PictureBox pictureBox27;
    }
}

