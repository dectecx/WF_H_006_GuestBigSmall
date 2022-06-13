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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // infolabel
            // 
            this.infolabel.AutoSize = true;
            this.infolabel.Location = new System.Drawing.Point(56, 29);
            this.infolabel.Name = "infolabel";
            this.infolabel.Size = new System.Drawing.Size(57, 15);
            this.infolabel.TabIndex = 0;
            this.infolabel.Text = "infolabel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(119, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnDeal
            // 
            this.btnDeal.Location = new System.Drawing.Point(277, 366);
            this.btnDeal.Name = "btnDeal";
            this.btnDeal.Size = new System.Drawing.Size(75, 23);
            this.btnDeal.TabIndex = 2;
            this.btnDeal.Text = "btnDeal";
            this.btnDeal.UseVisualStyleBackColor = true;
            // 
            // btnbig
            // 
            this.btnbig.Location = new System.Drawing.Point(373, 366);
            this.btnbig.Name = "btnbig";
            this.btnbig.Size = new System.Drawing.Size(75, 23);
            this.btnbig.TabIndex = 3;
            this.btnbig.Text = "btnbig";
            this.btnbig.UseVisualStyleBackColor = true;
            this.btnbig.Click += new System.EventHandler(this.btnbig_Click);
            // 
            // btnsmall
            // 
            this.btnsmall.Location = new System.Drawing.Point(474, 366);
            this.btnsmall.Name = "btnsmall";
            this.btnsmall.Size = new System.Drawing.Size(75, 23);
            this.btnsmall.TabIndex = 4;
            this.btnsmall.Text = "btnsmall";
            this.btnsmall.UseVisualStyleBackColor = true;
            this.btnsmall.Click += new System.EventHandler(this.btnsmall_Click);
            // 
            // btnblack
            // 
            this.btnblack.Location = new System.Drawing.Point(571, 366);
            this.btnblack.Name = "btnblack";
            this.btnblack.Size = new System.Drawing.Size(75, 23);
            this.btnblack.TabIndex = 5;
            this.btnblack.Text = "btnblack";
            this.btnblack.UseVisualStyleBackColor = true;
            this.btnblack.Click += new System.EventHandler(this.btnblack_Click);
            // 
            // btnred
            // 
            this.btnred.Location = new System.Drawing.Point(652, 366);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(75, 23);
            this.btnred.TabIndex = 6;
            this.btnred.Text = "btnred";
            this.btnred.UseVisualStyleBackColor = true;
            this.btnred.Click += new System.EventHandler(this.btnred_Click);
            // 
            // btnend
            // 
            this.btnend.Location = new System.Drawing.Point(571, 415);
            this.btnend.Name = "btnend";
            this.btnend.Size = new System.Drawing.Size(75, 23);
            this.btnend.TabIndex = 7;
            this.btnend.Text = "btnend";
            this.btnend.UseVisualStyleBackColor = true;
            this.btnend.Click += new System.EventHandler(this.btnend_Click);
            // 
            // lbtoptext
            // 
            this.lbtoptext.AutoSize = true;
            this.lbtoptext.Location = new System.Drawing.Point(323, 29);
            this.lbtoptext.Name = "lbtoptext";
            this.lbtoptext.Size = new System.Drawing.Size(57, 15);
            this.lbtoptext.TabIndex = 8;
            this.lbtoptext.Text = "lbtoptext";
            // 
            // lbmoney
            // 
            this.lbmoney.AutoSize = true;
            this.lbmoney.Location = new System.Drawing.Point(506, 28);
            this.lbmoney.Name = "lbmoney";
            this.lbmoney.Size = new System.Drawing.Size(56, 15);
            this.lbmoney.TabIndex = 9;
            this.lbmoney.Text = "lbmoney";
            // 
            // lbwinlose
            // 
            this.lbwinlose.AutoSize = true;
            this.lbwinlose.Location = new System.Drawing.Point(505, 70);
            this.lbwinlose.Name = "lbwinlose";
            this.lbwinlose.Size = new System.Drawing.Size(61, 15);
            this.lbwinlose.TabIndex = 10;
            this.lbwinlose.Text = "lbwinlose";
            // 
            // tbmoney
            // 
            this.tbmoney.Location = new System.Drawing.Point(466, 163);
            this.tbmoney.Name = "tbmoney";
            this.tbmoney.Size = new System.Drawing.Size(100, 25);
            this.tbmoney.TabIndex = 11;
            this.tbmoney.Text = "tbmoney";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

