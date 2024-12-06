using System;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Text;

namespace Z.Phone2Region.Net
{

    /// <summary>
    /// 手机号码转区域
    /// <para>@createDate 2024/12/04 11:11:11</para>
    /// <para>@author ALI[ali-k@foxmail.com]</para>
    /// <para>@since 1.0.0</para>
    /// </summary>
    public class Phone2Region
    {

        /// <summary>
        /// 已初始化
        /// </summary>
        private static bool isInit = false;
        /// <summary>
        /// 数据
        /// </summary>
        private static BinaryReader buffer;
        /// <summary>
        /// 二级索引区指针
        /// </summary>
        private static int vector2AreaPtr;
        /// <summary>
        /// 索引区指针
        /// </summary>
        private static int vectorAreaPtr;

        /// <summary>
        /// 是否已经初始化
        /// </summary>
        /// <returns>是否已经初始化</returns>
        public static bool initialized()
        {
            return isInit;
        }

        /// <summary>
        /// 通过文件初始化实例
        /// </summary>
        /// <param name="path">文件路径</param>
        public static void initByFile(string path)
        {
            if (isInit)
            {
                throw new Phone2RegionException("已经初始化过了，不可重复初始化！");
            }
            //Console.WriteLine("手机号码转区域初始化：文件路径LOCAL_PATH " + path);
            try
            {
                init(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read));
            }
            catch (Exception e)
            {
                throw new Phone2RegionException("初始化文件异常！", e);
            }
        }

        /// <summary>
        /// 通过URL初始化实例
        /// <para>例如：<code>https://www.404z.cn/files/phone2region/v2.0.0/data/phone2region.zdb</code></para>
        /// </summary>
        /// <param name="url">URL</param>
        public static void initByUrl(string url)
        {
            if (isInit)
            {
                throw new Phone2RegionException("已经初始化过了，不可重复初始化！");
            }
            //Console.WriteLine("手机号码转区域初始化：URL路径URL_PATH " + url);
            try
            {
                init(HttpWebRequest.Create(url).GetResponse().GetResponseStream());
            }
            catch (Exception e)
            {
                throw new Phone2RegionException("初始化文件异常！", e);
            }
        }

        /// <summary>
        /// 初始化实例
        /// </summary>
        /// <param name="stream">压缩的zdb流</param>
        public static void init(Stream stream)
        {
            if (isInit)
            {
                throw new Phone2RegionException("已经初始化过了，不可重复初始化！");
            }
            if (stream == null)
            {
                throw new Phone2RegionException("数据文件为空！");
            }
            try
            {
                // 解压
                ZipArchiveEntry entry = new ZipArchive(stream).Entries[0];
                // 数据
                MemoryStream memoryStream = new MemoryStream();
                ((DeflateStream)entry.Open()).CopyTo(memoryStream);
                memoryStream.Position = 0;
                buffer = new BinaryReader(memoryStream);
                uint crc32OriginValue = buffer.ReadUInt32();
                byte[] bufferCrc32 = new byte[memoryStream.Length - 4];
                buffer.Read(bufferCrc32, 0, bufferCrc32.Length);
                if (crc32OriginValue != Crc32.crc32(bufferCrc32))
                {
                    throw new Phone2RegionException("数据文件校验错误！");
                }
                buffer.BaseStream.Position = 4;
                int version = buffer.ReadInt32();
                buffer.BaseStream.Position = 12;
                vector2AreaPtr = buffer.ReadInt32();
                vectorAreaPtr = buffer.ReadInt32();
                //Console.WriteLine("数据加载成功：版本号VERSION " + version + " ，校验码CRC32 " + crc32OriginValue.ToString("X8"));
                isInit = true;
            }
            catch (Exception e)
            {
                throw new Phone2RegionException("初始化异常！", e);
            }
        }

        /// <summary>
        /// 解析手机号码的区域
        /// </summary>
        /// <param name="phone">手机号码(前7-11位)</param>
        /// <returns>Region(找不到返回null)</returns>
        public static Region parse(string phone)
        {
            // 7-11位
            if (phone == null || phone.Length < 7 || phone.Length > 11)
            {
                throw new Phone2RegionException("手机号码 " + phone + " 不合法！");
            }
            int num;
            try
            {
                num = int.Parse(phone.Substring(0, 7));
            }
            catch (Exception e)
            {
                throw new Phone2RegionException("手机号码 " + phone + " 不合法！", e);
            }
            // 1300000-1999999
            if (num < 1300000 || num > 1999999)
            {
                throw new Phone2RegionException("手机号码 " + phone + " 不合法！");
            }
            return innerParse(num - 1300000);
        }

        /// <summary>
        /// 解析手机号码的区域
        /// </summary>
        /// <param name="phone">手机号码(11位)</param>
        /// <returns>Region(找不到返回null)</returns>
        public static Region parse(long phone)
        {
            // 1300000_0000-1999999_9999
            if (phone < 1300000_0000L || phone > 1999999_9999L)
            {
                throw new Phone2RegionException("手机号码 " + phone + " 不合法！");
            }
            return innerParse(((int)(phone / 10000)) - 1300000);
        }

        /// <summary>
        /// 解析手机号码的区域
        /// </summary>
        /// <param name="phone">手机号码(前7位)</param>
        /// <returns>Region(找不到返回null)</returns>
        public static Region parse(int phone)
        {
            // 1300000-1999999
            if (phone < 1300000 || phone > 1999999)
            {
                throw new Phone2RegionException("手机号码 " + phone + " 不合法！");
            }
            return innerParse(phone - 1300000);
        }

        /// <summary>
        /// 解析手机号码的区域(内部)
        /// </summary>
        /// <param name="phone">手机号码前7位-1300000</param>
        /// <returns>Region(找不到返回null)</returns>
        private static Region innerParse(int phone)
        {
            if (!isInit)
            {
                throw new Phone2RegionException("未初始化！");
            }

            // 二级索引区
            buffer.BaseStream.Position = vector2AreaPtr + ((phone >> 8) << 2);
            int left = buffer.ReadInt32();
            int right = buffer.ReadInt32();

            // 索引区
            if (left == right)
            {
                return null;
            }
            else
            {
                right -= 5;
                // 二分查找
                int num = 0;
                int phoneSegments = phone & 0xFF;
                // 索引区
                while (left <= right)
                {
                    int mid = align((left + right) / 2);
                    // 查找是否匹配到
                    buffer.BaseStream.Position = mid;
                    num = buffer.ReadByte() & 0xFF;
                    if (phoneSegments < num)
                    {
                        right = mid - 5;
                    }
                    else if (phoneSegments > num)
                    {
                        left = mid + 5;
                    }
                    else
                    {
                        break;
                    }
                }
                if (num != phoneSegments)
                {
                    return null;
                }
            }

            // 记录区
            buffer.BaseStream.Position = buffer.ReadInt32();
            byte[] recordValue = buffer.ReadBytes(buffer.ReadByte() & 0xFF);
            return new Region(Encoding.UTF8.GetString(recordValue));
        }

        /// <summary>
        /// 字节对齐
        /// </summary>
        /// <param name="pos">位置</param>
        /// <returns>对齐后的位置</returns>
        private static int align(int pos)
        {
            int remain = (pos - vectorAreaPtr) % 5;
            if (pos - vectorAreaPtr < 5)
            {
                return pos - remain;
            }
            else if (remain != 0)
            {
                return pos + 5 - remain;
            }
            else
            {
                return pos;
            }
        }

    }
}
