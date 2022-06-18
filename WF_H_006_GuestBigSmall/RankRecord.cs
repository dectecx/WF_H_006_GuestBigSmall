using System;

namespace Guest_Big_Small
{
    /// <summary>
    /// 排行榜
    /// </summary>
    public class RankRecord
    {
        /// <summary>
        /// 時間
        /// </summary>
        public DateTime RecordTime { get; set; }

        /// <summary>
        /// 帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 離開遊戲時剩餘的籌碼
        /// </summary>
        public int Money { get; set; }
    }
}
