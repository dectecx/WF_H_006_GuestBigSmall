using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Guest_Big_Small
{
    public partial class RankForm : Form
    {
        public RankForm()
        {
            InitializeComponent();

            // 刷新列表
            RefreshRecord();
        }

        public void RefreshRecord()
        {
            // 取得當前系統的排行榜紀錄
            List<RankRecord> records = SystemInfo.RankRecords;

            // 先逐筆加入暫存的List內
            List<ListViewItem> list = new List<ListViewItem>();
            for (int i = 0; i < records.Count; i++)
            {
                RankRecord item = records[i];   // 單筆紀錄
                int rank = i + 1;   // 排名
                ListViewItem listViewItem = new ListViewItem(rank.ToString());
                // 相隔一行設定個顏色
                if (i % 2 == 0)
                {
                    listViewItem.BackColor = SystemColors.Info;
                }
                listViewItem.ImageIndex = 0;
                listViewItem.SubItems.Add(item.RecordTime.ToString("MM/dd HH:mm"));
                listViewItem.SubItems.Add(item.Account);
                listViewItem.SubItems.Add(item.Money.ToString());
                list.Add(listViewItem);
            }
            // 再一次加入ListView內
            lvRankRecord.Items.AddRange(list.ToArray());
        }
    }
}
