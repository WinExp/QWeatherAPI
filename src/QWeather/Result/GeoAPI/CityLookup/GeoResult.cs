using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWeatherAPI.Result.GeoAPI.CityLookup
{
    public class GeoResult
    {
        #region 声明字段
        /// <summary>
        /// API 状态码
        /// </summary>
        public string Code;
        /// <summary>
        /// 位置搜索结果
        /// </summary>
        public List<Location> Locations = new List<Location>();
        #endregion

        #region 构造方法
        /// <summary>
        /// 构造地理位置 API 返回结果
        /// </summary>
        /// <param name="jsonString"></param>
        /// <exception cref="ArgumentException"></exception>
        public GeoResult(string jsonString)
        {
            JObject jsonData = JObject.Parse(jsonString);
            this.Code = jsonData.Value<string>("code");
            if (this.Code != "200") { throw new ArgumentException(this.Code); }
            foreach (JToken location in jsonData.SelectToken("location"))
            {
                this.Locations.Add(new Location(location));
            }
        }
        #endregion
    }
}
