namespace Guest_Big_Small
{
    partial class RankForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvRankRecord = new System.Windows.Forms.ListView();
            this.colHTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHAccount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHMoney = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHRank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvRankRecord
            // 
            this.lvRankRecord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHRank,
            this.colHTime,
            this.colHAccount,
            this.colHMoney});
            this.lvRankRecord.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lvRankRecord.HideSelection = false;
            this.lvRankRecord.Location = new System.Drawing.Point(12, 12);
            this.lvRankRecord.Name = "lvRankRecord";
            this.lvRankRecord.Size = new System.Drawing.Size(320, 426);
            this.lvRankRecord.TabIndex = 2;
            this.lvRankRecord.UseCompatibleStateImageBehavior = false;
            this.lvRankRecord.View = System.Windows.Forms.View.Details;
            // 
            // colHTime
            // 
            this.colHTime.Text = "時間";
            this.colHTime.Width = 100;
            // 
            // colHAccount
            // 
            this.colHAccount.Text = "帳號";
            this.colHAccount.Width = 80;
            // 
            // colHMoney
            // 
            this.colHMoney.Text = "籌碼";
            this.colHMoney.Width = 80;
            // 
            // colHRank
            // 
            this.colHRank.Text = "No";
            this.colHRank.Width = 45;
            // 
            // RankForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 450);
            this.Controls.Add(this.lvRankRecord);
            this.Name = "RankForm";
            this.Text = "排行榜";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvRankRecord;
        private System.Windows.Forms.ColumnHeader colHTime;
        private System.Windows.Forms.ColumnHeader colHAccount;
        private System.Windows.Forms.ColumnHeader colHMoney;
        private System.Windows.Forms.ColumnHeader colHRank;
    }
}