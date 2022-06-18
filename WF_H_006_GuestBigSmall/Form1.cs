using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_H_006_GuestBigSmall;

namespace Guest_Big_Small
{
    public partial class Form1 : Form
    {
        string[] d = new string[54];  //紙牌路徑
        static int[] a = new int[52]; //紙牌編碼

        int point, flower, bigsmall;
        //判斷大還還是小牌
        //bigsmall: 0-大小通吃, 1:小, 2:大
        //猜顏色和大小
        public enum guessCard { red, black, big, samll };
        bool red;      //是否為紅色牌
        bool gameover; //判斷是否還有籌碼，沒籌碼則遊戲結束     
        string topText = "A為大牌，2~7小牌，9以上大牌，8大小通吃";

        public Form1()
        {
            InitializeComponent();

            // 初始化，預設登出狀態+寫死幾個排行紀錄
            SystemInfo.RankRecords = new List<RankRecord>
            {
                new RankRecord { RecordTime = DateTime.Now.AddDays(-3), Account = "豪哩嗨", Money = 630 },
                new RankRecord { RecordTime = DateTime.Now.AddDays(-7), Account = "張東山", Money = 450 },
                new RankRecord { RecordTime = DateTime.Now.AddDays(-2), Account = "郝勳咖", Money = 70 },
            };
            SystemInfo.User = null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameover = false;
            EnableButton(false);
            infolabel.Text = string.Empty;

            //撲克牌圖案建置
            string picPath = "./pukeImage";
            for (int i = 0; i <= 52; i++)
                d[i] = picPath + "/" + i.ToString() + ".jpg";
        }

        //按下發牌
        private void btnDeal_Click(object sender, EventArgs e)
        {
            int i, rnum, temp;

            EnableButton(true);
            pictureBox1.Image = Image.FromFile(d[52]);//蓋牌

            //隨機出一張牌
            Random ran = new Random();
            for (i = 0; i < 52; i++)
            {
                a[i] = i;
            }

            for (i = 0; i < 52; i++)
            {
                rnum = ran.Next(51);
                temp = a[i];
                a[i] = a[rnum];
                a[rnum] = temp;
            }

            if (gameover)
            {
                lbtoptext.Text = topText;
                btnDeal.Text = "發牌";
                tbmoney.Text = "10";
                lbmoney.Text = "100";
                gameover = false;
            }
        }

        enum state { red = 1, black = 2, big = 4, small = 8, both = 16 }

        //下注完成開牌
        public void opencard(guessCard guess)
        {
            bool bingo = false;
            int playerguess = (int)guess;
            int playermoney;

            if (!Int32.TryParse(lbmoney.Text, out playermoney))
            {
                playermoney = 0;
            }

            int betMoney;
            if (!Int32.TryParse(tbmoney.Text, out betMoney))
            {
                betMoney = 0;
                MessageBox.Show("下注金額請輸入整數數字");
                return;
            }

            if (betMoney > 0 && betMoney <= playermoney)  //押注金額>0並且<=剩下籌碼
            {
                EnableButton(false); //隱藏按鈕

                pictureBox1.Image = Image.FromFile(d[a[0]]);
                int cardRate = -1;
                red = true;
                infolabel.Text = "";

                flower = (byte)a[0] % 4;       //花色
                point = a[0] / 4;              //點數

                //四種花色依序是-Club，Diamond，Heart，Spade
                //判斷紅色還是黑色               
                if (flower == 3 || flower == 0) //黑色牌
                {
                    red = false;
                    infolabel.Text = "黑色,";
                    if (playerguess == 1)
                        bingo = true;
                }
                else
                {
                    infolabel.Text = "紅色,";
                    if (playerguess == 0)
                        bingo = true;
                }

                //判斷大小牌
                if (point == 7)
                {
                    bigsmall = 0;
                    infolabel.Text += "大小通吃";
                    if (playerguess > 1)
                        bingo = true;
                }
                else if (point < 7 && point != 0)
                {
                    bigsmall = 1;
                    infolabel.Text += "小";
                    if (playerguess == 3)
                        bingo = true;
                }
                else
                {
                    bigsmall = 2;
                    infolabel.Text += "大";
                    if (playerguess == 2)
                        bingo = true;
                }

                lbwinlose.Text = bingo ? "你贏了" : "你輸了";
                if (bingo)
                {
                    cardRate = 1;
                }

                playermoney += betMoney * cardRate;
                lbmoney.Text = playermoney.ToString();

                //籌碼輸光
                if (playermoney <= 0)
                {
                    btnDeal.Text = "重新開始";
                    lbtoptext.Text = "你破產了，請按重新開始";
                    gameover = true;
                }
            }
            else
            {
                MessageBox.Show("請輸入大於0並且小於等於剩餘籌碼的金額。");
            }
        }

        private void btnbig_Click(object sender, EventArgs e)
        {
            opencard(guessCard.big);
        }

        private void btnsmall_Click(object sender, EventArgs e)
        {
            opencard(guessCard.samll);
        }

        private void btnblack_Click(object sender, EventArgs e)
        {
            opencard(guessCard.black);
        }

        private void btnred_Click(object sender, EventArgs e)
        {
            opencard(guessCard.red);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 先判斷是否是登入狀態,如果是就登出,反之就執行登入流程
            if (SystemInfo.User != null)
            {
                // 清除當前登入者資訊
                SystemInfo.User = null;
                btnLogin.Text = "登入";
                return;
            }
            else
            {
                // 打開登入表單
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();

                // 關閉表單後繼續判斷
                // 若登入者有值,表示登入成功
                if (SystemInfo.User != null)
                {
                    btnLogin.Text = "登出" + SystemInfo.User.Account;
                }
                else
                {
                    // 清除當前登入者資訊
                    SystemInfo.User = null;
                    btnLogin.Text = "登入";
                }
            }
        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            // 打開登入表單
            RankForm rankForm = new RankForm();
            rankForm.ShowDialog();
        }

        private void EnableButton(bool isEnable)
        {
            btnbig.Enabled = isEnable;
            btnsmall.Enabled = isEnable;
            btnred.Enabled = isEnable;
            btnblack.Enabled = isEnable;
            btnDeal.Enabled = !isEnable;
        }

        //按下結束遊戲
        private void btnend_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("你確定要結束遊戲嗎?", "結束遊戲", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}