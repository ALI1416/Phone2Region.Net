namespace Z.Phone2Region.Net
{

    /// <summary>
    /// 区域
    /// <para>@createDate 2024/1/26 11:11:11</para>
    /// <para>@author ALI[ali-k@foxmail.com]</para>
    /// <para>@since 1.0.0</para>
    /// </summary>
    public class Region
    {

        /// <summary>
        /// 省份
        /// </summary>
        public string province { get; set; }
        /// <summary>
        /// 城市
        /// </summary>
        public string city { get; set; }
        /// <summary>
        /// 邮编
        /// </summary>
        public string zipCode { get; set; }
        /// <summary>
        /// 区号
        /// </summary>
        public string areaCode { get; set; }
        /// <summary>
        /// ISP
        /// </summary>
        public string isp { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        public Region() { }

        /// <summary>
        /// 构造区域
        /// </summary>
        /// <param name="region">区域字符串</param>
        public Region(string region)
        {
            // 省份|城市|邮编|区号|ISP
            string[] s = region.Split('|');
            if (s.Length == 5)
            {
                province = s[0];
                city = s[1];
                zipCode = s[2];
                areaCode = s[3];
                isp = s[4];
            }
        }

    }
}
