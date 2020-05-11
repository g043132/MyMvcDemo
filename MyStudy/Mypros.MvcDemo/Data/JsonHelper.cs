using System;

namespace Mypros.MvcDemo.Data
{
    /// <summary>
    /// JSON处理公共类
    /// </summary>
    public class JsonHelper
    {
        /// <summary>
        /// 将对象转换成JSON
        /// </summary>
        /// <param name="data"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        static public string SerializeJSON<T>(T data)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(data);
        }

        /// <summary>
        /// 将JSON转换成对象
        /// </summary>
        /// <param name="json"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        static public T DeserializeJSON<T>(string json)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
        }

        /// <summary>
        /// 时间转换
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
         public static long ConvertToTimeStamp(DateTime time)
         {
            DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            return (long) (time.AddHours(-8) - Jan1st1970).TotalMilliseconds;
         }
    }
}