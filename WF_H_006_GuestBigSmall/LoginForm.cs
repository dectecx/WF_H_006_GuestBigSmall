using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Guest_Big_Small
{
    public partial class LoginForm : Form
    {
        // 寫死的帳號密碼清單
        List<User> accounts = new List<User>
        {
            new User { Account = "admin", Password = "admin"},
            new User { Account = "test", Password = "test"},
            new User { Account = "abc123", Password = "123456"}
        };

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登入按鈕
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 找出有沒有符合的帳號密碼
            User user = accounts.Where(x => x.Account == txtAccount.Text &&
                                            x.Password == txtPassword.Text)
                                .FirstOrDefault();
            if (user != null)
            {
                // 設定當前登入者資訊
                SystemInfo.User = user;
                // 關閉畫面
                this.Close();
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤", "請重新輸入", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // 清空密碼
                txtPassword.Text = "";
                // 清除當前登入者資訊
                SystemInfo.User = null;
            }
        }
    }
}
