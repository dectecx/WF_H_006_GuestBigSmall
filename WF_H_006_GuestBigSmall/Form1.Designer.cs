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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnRank = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnOver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.infolabel.Location = new System.Drawing.Point(344, 285);
            this.infolabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(0, 28);
            this.infolabel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 56);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 197);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeal
            // 
            this.btnDeal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDeal.Location = new System.Drawing.Point(43, 378);
            this.btnDeal.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(92, 55);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "發牌";
            this.btnDeal.UseVisualStyleBackColor = true;
            this.btnDeal.Click += new System.EventHandler(this.btnDeal_Click);
            // 
            // btnbig
            // 
            this.btnbig.Enabled = false;
            this.btnbig.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnbig.Location = new System.Drawing.Point(43, 258);
            this.btnbig.Margin = new System.Windows.Forms.Padding(2);
            this.btnbig.Name = "btnbig";
            this.btnbig.Size = new System.Drawing.Size(92, 55);
            this.btnbig.TabIndex = 3;
            this.btnbig.Text = "大";
            this.btnbig.UseVisualStyleBackColor = true;
            this.btnbig.Click += new System.EventHandler(this.btnbig_Click);
            // 
            // btnsmall
            // 
            this.btnsmall.Enabled = false;
            this.btnsmall.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnsmall.Location = new System.Drawing.Point(140, 258);
            this.btnsmall.Margin = new System.Windows.Forms.Padding(2);
            this.btnsmall.Name = "btnsmall";
            this.btnsmall.Size = new System.Drawing.Size(92, 55);
            this.btnsmall.TabIndex = 4;
            this.btnsmall.Text = "小";
            this.btnsmall.UseVisualStyleBackColor = true;
            this.btnsmall.Click += new System.EventHandler(this.btnsmall_Click);
            // 
            // btnblack
            // 
            this.btnblack.Enabled = false;
            this.btnblack.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnblack.Location = new System.Drawing.Point(43, 318);
            this.btnblack.Margin = new System.Windows.Forms.Padding(2);
            this.btnblack.Name = "btnblack";
            this.btnblack.Size = new System.Drawing.Size(92, 55);
            this.btnblack.TabIndex = 5;
            this.btnblack.Text = "黑";
            this.btnblack.UseVisualStyleBackColor = true;
            this.btnblack.Click += new System.EventHandler(this.btnblack_Click);
            // 
            // btnred
            // 
            this.btnred.Enabled = false;
            this.btnred.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnred.Location = new System.Drawing.Point(140, 318);
            this.btnred.Margin = new System.Windows.Forms.Padding(2);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(92, 55);
            this.btnred.TabIndex = 6;
            this.btnred.Text = "紅";
            this.btnred.UseVisualStyleBackColor = true;
            this.btnred.Click += new System.EventHandler(this.btnred_Click);
            // 
            // btnend
            // 
            this.btnend.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnend.Location = new System.Drawing.Point(140, 378);
            this.btnend.Margin = new System.Windows.Forms.Padding(2);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(92, 55);
            this.btnend.TabIndex = 7;
            this.btnend.Text = "結束遊戲";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // lbtoptext
            // 
            this.lbtoptext.AutoSize = true;
            this.lbtoptext.Font = new System.Drawing.Font("微軟正黑體", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbtoptext.Location = new System.Drawing.Point(39, 7);
            this.lbtoptext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbtoptext.Name = "lbtoptext";
            this.lbtoptext.Size = new System.Drawing.Size(385, 24);
            this.lbtoptext.TabIndex = 8;
            this.lbtoptext.Text = "A為大牌，2~7小牌，9以上大牌，8大小通吃";
            // 
            // lbmoney
            // 
            this.lbmoney.AutoSize = true;
            this.lbmoney.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbmoney.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbmoney.Location = new System.Drawing.Point(363, 124);
            this.lbmoney.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbmoney.Name = "lbmoney";
            this.lbmoney.Size = new System.Drawing.Size(36, 20);
            this.lbmoney.TabIndex = 9;
            this.lbmoney.Text = "100";
            // 
            // lbwinlose
            // 
            this.lbwinlose.AutoSize = true;
            this.lbwinlose.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbwinlose.Location = new System.Drawing.Point(344, 313);
            this.lbwinlose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbwinlose.Name = "lbwinlose";
            this.lbwinlose.Size = new System.Drawing.Size(0, 28);
            this.lbwinlose.TabIndex = 10;
            // 
            // tbmoney
            // 
            this.tbmoney.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tbmoney.Location = new System.Drawing.Point(347, 226);
            this.tbmoney.Margin = new System.Windows.Forms.Padding(2);
            this.tbmoney.Name = "tbmoney";
            this.tbmoney.Size = new System.Drawing.Size(76, 29);
            this.tbmoney.TabIndex = 11;
            this.tbmoney.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(334, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 28);
            this.label1.TabIndex = 12;
            this.label1.Text = "你的籌碼";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(334, 170);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 13;
            this.label2.Text = "押注金額";
            // 
            // btnRank
            // 
            this.btnRank.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRank.Location = new System.Drawing.Point(140, 437);
            this.btnRank.Margin = new System.Windows.Forms.Padding(2);
            this.btnRank.Name = "btnRank";
            this.btnRank.Size = new System.Drawing.Size(92, 55);
            this.btnRank.TabIndex = 15;
            this.btnRank.Text = "排行榜";
            this.btnRank.UseVisualStyleBackColor = true;
            this.btnRank.Click += new System.EventHandler(this.btnRank_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnLogin.Location = new System.Drawing.Point(43, 437);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(92, 55);
            this.btnLogin.TabIndex = 14;
            this.btnLogin.Text = "登入";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnOver
            // 
            this.btnOver.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnOver.Location = new System.Drawing.Point(436, 437);
            this.btnOver.Margin = new System.Windows.Forms.Padding(2);
            this.btnOver.Name = "btnOver";
            this.btnOver.Size = new System.Drawing.Size(92, 55);
            this.btnOver.TabIndex = 16;
            this.btnOver.Text = "見好就收";
            this.btnOver.UseVisualStyleBackColor = true;
            this.btnOver.Visible = false;
            this.btnOver.Click += new System.EventHandler(this.btnOver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 515);
            this.Controls.Add(this.btnOver);
            this.Controls.Add(this.btnRank);
            this.Controls.Add(this.btnLogin);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "押大小或是牌色";
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
        private System.Windows.Forms.Button btnRank;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnOver;
    }
}

