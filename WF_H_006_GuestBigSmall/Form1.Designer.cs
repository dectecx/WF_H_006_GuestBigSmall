namespace Guest_Big_Small
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.infolabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDeal = new System.Windows.Forms.Button();
            this.btnbig = new System.Windows.Forms.Button();
            this.btnsmall = new System.Windows.Forms.Button();
            this.btnblack = new System.Windows.Forms.Button();
            this.btnred = new System.Windows.Forms.Button();
            this.btnend = new System.Windows.Forms.Button();
            this.lbtoptext = new System.Windows.Forms.Label();
            this.lbmoney = new System.Windows.Forms.Label();
            this.lbwinlose = new System.Windows.Forms.Label();
            this.tbmoney = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.infolabel.Location = new System.Drawing.Point(458, 356);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(0, 35);
            this.infolabel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(84, 70);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 246);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeal.Location = new System.Drawing.Point(57, 472);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(123, 69);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "發牌";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnbig
            // 
            this.btnbig.Enabled = false;
            this.btnbig.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbig.Location = new System.Drawing.Point(57, 322);
            this.btnbig.Name = "btnbig";
            this.btnbig.Size = new System.Drawing.Size(123, 69);
            this.btnbig.TabIndex = 3;
            this.btnbig.Text = "大";
            this.btnbig.UseVisualStyleBackColor = true;
            this.btnbig.Click += new System.EventHandler(this.btnbig_Click);
            // 
            // btnsmall
            // 
            this.btnsmall.Enabled = false;
            this.btnsmall.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsmall.Location = new System.Drawing.Point(186, 322);
            this.btnsmall.Name = "btnsmall";
            this.btnsmall.Size = new System.Drawing.Size(123, 69);
            this.btnsmall.TabIndex = 4;
            this.btnsmall.Text = "小";
            this.btnsmall.UseVisualStyleBackColor = true;
            this.btnsmall.Click += new System.EventHandler(this.btnsmall_Click);
            // 
            // btnblack
            // 
            this.btnblack.Enabled = false;
            this.btnblack.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnblack.Location = new System.Drawing.Point(57, 397);
            this.btnblack.Name = "btnblack";
            this.btnblack.Size = new System.Drawing.Size(123, 69);
            this.btnblack.TabIndex = 5;
            this.btnblack.Text = "黑";
            this.btnblack.UseVisualStyleBackColor = true;
            this.btnblack.Click += new System.EventHandler(this.btnblack_Click);
            // 
            // btnred
            // 
            this.btnred.Enabled = false;
            this.btnred.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnred.Location = new System.Drawing.Point(186, 397);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(123, 69);
            this.btnred.TabIndex = 6;
            this.btnred.Text = "紅";
            this.btnred.UseVisualStyleBackColor = true;
            this.btnred.Click += new System.EventHandler(this.btnred_Click);
            // 
            // btnend
            // 
            this.btnend.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnend.Location = new System.Drawing.Point(186, 472);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(123, 69);
            this.btnend.TabIndex = 7;
            this.btnend.Text = "結束遊戲";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // lbtoptext
            // 
            this.lbtoptext.AutoSize = true;
            this.lbtoptext.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbtoptext.Location = new System.Drawing.Point(52, 9);
            this.lbtoptext.Name = "lbtoptext";
            this.lbtoptext.Size = new System.Drawing.Size(466, 29);
            this.lbtoptext.TabIndex = 8;
            this.lbtoptext.Text = "A為大牌，2~7小牌，9以上大牌，8大小通吃";
            // 
            // lbmoney
            // 
            this.lbmoney.AutoSize = true;
            this.lbmoney.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbmoney.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbmoney.Location = new System.Drawing.Point(484, 155);
            this.lbmoney.Name = "lbmoney";
            this.lbmoney.Size = new System.Drawing.Size(48, 25);
            this.lbmoney.TabIndex = 9;
            this.lbmoney.Text = "100";
            // 
            // lbwinlose
            // 
            this.lbwinlose.AutoSize = true;
            this.lbwinlose.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbwinlose.Location = new System.Drawing.Point(458, 391);
            this.lbwinlose.Name = "lbwinlose";
            this.lbwinlose.Size = new System.Drawing.Size(0, 35);
            this.lbwinlose.TabIndex = 10;
            // 
            // tbmoney
            // 
            this.tbmoney.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbmoney.Location = new System.Drawing.Point(463, 282);
            this.tbmoney.Name = "tbmoney";
            this.tbmoney.Size = new System.Drawing.Size(100, 34);
            this.tbmoney.TabIndex = 11;
            this.tbmoney.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(446, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 35);
            this.label1.TabIndex = 12;
            this.label1.Text = "你的籌碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(446, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 35);
            this.label2.TabIndex = 13;
            this.label2.Text = "押注金額";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 546);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbmoney);
            this.Controls.Add(this.lbwinlose);
            this.Controls.Add(this.lbmoney);
            this.Controls.Add(this.lbtoptext);
            this.Controls.Add(this.btnend);
            this.Controls.Add(this.btnred);
            this.Controls.Add(this.btnblack);
            this.Controls.Add(this.btnsmall);
            this.Controls.Add(this.btnbig);
            this.Controls.Add(this.btnDeal);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.infolabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label infolabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDeal;
        private System.Windows.Forms.Button btnbig;
        private System.Windows.Forms.Button btnsmall;
        private System.Windows.Forms.Button btnblack;
        private System.Windows.Forms.Button btnred;
        private System.Windows.Forms.Button btnend;
        private System.Windows.Forms.Label lbtoptext;
        private System.Windows.Forms.Label lbmoney;
        private System.Windows.Forms.Label lbwinlose;
        private System.Windows.Forms.TextBox tbmoney;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

