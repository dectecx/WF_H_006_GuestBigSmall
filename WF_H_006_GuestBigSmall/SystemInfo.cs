using System.Collections.Generic;

namespace Guest_Big_Small
{
    /// <summary>
    /// 系統資訊
    /// </summary>
    public static class SystemInfo
    {
        /// <summary>
        /// 排行榜紀錄
        /// </summary>
        public static List<RankRecord> RankRecords { get; set; }

        /// <summary>
        /// 當前的登入者
        /// </summary>
        public static User User { get; set; }
    }
}
