namespace Z.Phone2Region.Net.Test.Net8
{

    /// <summary>
    /// 程序入口
    /// </summary>
    public class Program
    {

        private static readonly string path = "D:/phone2region.zdb";
        private static readonly string url = "https://www.404z.cn/files/phone2region/v2.0.0/data/phone2region.zdb";
        private static readonly int phone = 1875471;

        /// <summary>
        /// 启动类
        /// </summary>
        /// <param name="args">参数</param>
        public static void Main(string[] args)
        {
            //TestByUrl();
            TestByFile();
        }

        /// <summary>
        /// 通过URL初始化
        /// </summary>
        public static void TestByUrl()
        {
            Phone2Region.initByUrl(url);
            Region region = Phone2Region.parse(phone);
            if (region == null)
            {
                Console.WriteLine("未找到");
            }
            else
            {
                Console.WriteLine(region.province + " " + region.city + " " + region.zipCode + " " + region.areaCode + " " + region.isp);
            }
        }

        /// <summary>
        /// 通过文件初始化
        /// </summary>
        public static void TestByFile()
        {
            Phone2Region.initByFile(path);
            Region region = Phone2Region.parse(phone);
            if (region == null)
            {
                Console.WriteLine("未找到");
            }
            else
            {
                Console.WriteLine(region.province + " " + region.city + " " + region.zipCode + " " + region.areaCode + " " + region.isp);
            }
        }

    }
}
