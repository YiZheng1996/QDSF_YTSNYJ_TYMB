namespace MainUI.Model
{
    // 上传时互检、质检结果
    public class UploadResultsModel
    {
        /// <summary>
        /// 互检结果
        /// </summary>
        public string mutualResult { get; set; }

        /// <summary>
        /// 互检时间
        /// </summary>
        public string mutualTime { get; set; }

        /// <summary>
        /// 互检结果
        /// </summary>
        public string qualityResult { get; set; }

        /// <summary>
        /// 质检时间
        /// </summary>
        public string qualityTime { get; set; }
    }
}
