using System;
using System.Runtime.Serialization;

namespace Z.Phone2Region.Net
{

    /// <summary>
    /// Phone2Region异常类
    /// <para>@createDate 2024/1/26 11:11:11</para>
    /// <para>@author ALI[ali-k@foxmail.com]</para>
    /// <para>@since 1.0.0</para>
    /// </summary>
    public class Phone2RegionException : Exception
    {

        /// <summary>
        /// Phone2Region异常
        /// </summary>
        public Phone2RegionException() : base() { }
        /// <summary>
        /// Phone2Region异常
        /// </summary>
        /// <param name="message">详细信息</param>
        public Phone2RegionException(string message) : base(message) { }
        /// <summary>
        /// Phone2Region异常
        /// </summary>
        /// <param name="message">详细信息</param>
        /// <param name="innerException">内部异常</param>
        public Phone2RegionException(string message, Exception innerException) : base(message, innerException) { }
        /// <summary>
        /// Phone2Region异常
        /// </summary>
        /// <param name="info">序列化信息</param>
        /// <param name="context">流上下文</param>
        protected Phone2RegionException(SerializationInfo info, StreamingContext context) : base(info, context) { }

    }
}
