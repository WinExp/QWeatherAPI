using QWeatherAPI.Tools.Net.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWeatherAPI
{
    public static class QWeather
    {
        #region 获取天气方法
        public static async Task<Result.RealTimeWeather.WeatherResult> GetRealTimeWeatherAsync(double lon, double lat, string key, string unit = "m", string lang = "zh")
        {
            string jsonData = await WebRequests.GetRequestAsync($"https://devapi.qweather.com/v7/weather/now?location={lon},{lat}&lang={lang}&unit={unit}&key={key}");
            var weather = new Result.RealTimeWeather.WeatherResult(jsonData);
            return weather;
        }
        #endregion

        #region 工具方法
        public static async Task<Result.GeoAPI.CityLookup.GeoResult> GetGeoAsync(string location, string key, string adm, string range = "world", int limit = 10, string lang = "zh")
        {
            string jsonData = await WebRequests.GetRequestAsync($"https://geoapi.qweather.com/v2/city/lookup?location={location}&number={limit}&adm={adm}&range={range}&lang={lang}&key={key}");
            return new Result.GeoAPI.CityLookup.GeoResult(jsonData);
        }

        public static async Task<Result.GeoAPI.CityLookup.GeoResult> GetGeoAsync(string location, string key, string range = "world", int limit = 10, string lang = "zh")
        {
            string jsonData = await WebRequests.GetRequestAsync($"https://geoapi.qweather.com/v2/city/lookup?location={location}&number={limit}&range={range}&lang={lang}&key={key}");
            return new Result.GeoAPI.CityLookup.GeoResult(jsonData);
        }
        #endregion
    }
}
