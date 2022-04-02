using Newtonsoft.Json.Linq;

namespace QWeatherAPI.Result.WeatherHourlyForecast
{
    public class Hourly
    {
        #region 声明字段
        /// <summary>
        /// 更新时间
        /// </summary>
        public string FxTime;
        /// <summary>
        /// 温度
        /// </summary>
        public string Temp;
        /// <summary>
        /// 图标代码
        /// </summary>
        public string Icon;
        /// <summary>
        /// 天气情况文字介绍
        /// </summary>
        public string Text;
        /// <summary>
        /// 风向角度
        /// </summary>
        public string Wind360;
        /// <summary>
        /// 风向
        /// </summary>
        public string WindDir;
        /// <summary>
        /// 风力等级
        /// </summary>
        public string WindScale;
        /// <summary>
        /// 风速，公里/小时
        /// </summary>
        public string WindSpeed;
        /// <summary>
        /// 相对湿度，百分比数值
        /// </summary>
        public string Humidity;
        /// <summary>
        /// 逐小时预报降水概率，百分比数值（可能为空）
        /// </summary>
        public string Pop;
        /// <summary>
        /// 每小时降雨量（默认单位：毫米）
        /// </summary>
        public string Precip;
        /// <summary>
        /// 大气压强（默认单位：百帕）
        /// </summary>
        public string Pressure;
        /// <summary>
        /// 云量，百分比数值（可能为空）
        /// </summary>
        public string Cloud;
        /// <summary>
        /// 露点温度（可能为空）
        /// </summary>
        public string Dew;
        #endregion

        #region 构造方法
        public Hourly(JToken token)
        {
            this.FxTime = token.Value<string>("fxTime");
            this.Temp = token.Value<string>("temp");
            this.Icon = token.Value<string>("icon");
            this.Text = token.Value<string>("text");
            this.Wind360 = token.Value<string>("wind360");
            this.WindDir = token.Value<string>("windDir");
            this.WindScale = token.Value<string>("windScale");
            this.WindSpeed = token.Value<string>("windSpeed");
            this.Humidity = token.Value<string>("humidity");
            this.Pop = token.Value<string>("pop");
            this.Precip = token.Value<string>("precip");
            this.Pressure = token.Value<string>("pressure");
            this.Cloud = token.Value<string?>("cloud");
            this.Dew = token.Value<string?>("dew");
        }
        #endregion
    }
}
