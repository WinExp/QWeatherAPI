namespace ExampleConsoleApp
{
    class Program
    {
        static void Main()
        {
            GetWeatherAsync().Wait();
        }

        private static async Task GetWeatherAsync()
        {
            Console.Write("请输入 API 密钥：");
            string key = Console.ReadLine();
            Console.Write("请输入地点名称：");
            string location = Console.ReadLine();
            try
            {
                var locationInfo = (await QWeatherAPI.GeoAPI.GetGeoAsync(location, key)).Locations[0];
                var realTimeWeatherInfo = await QWeatherAPI.RealTimeWeatherAPI.GetRealTimeWeatherAsync(locationInfo.Lon, locationInfo.Lat, key);
                var forecastWeatherInfo = await QWeatherAPI.WeatherDailyForecastAPI.GetWeatherDailyForecastAsync(locationInfo.Lon, locationInfo.Lat, key);
                Console.WriteLine(@$"{locationInfo.Name} 的天气
当前温度 {realTimeWeatherInfo.Now.Temp}°C
体感温度 {realTimeWeatherInfo.Now.FeelsLike}°C
{realTimeWeatherInfo.Now.Text}
{realTimeWeatherInfo.Now.WindDir}

明天 {forecastWeatherInfo.Daily[1].FxDate} 的天气
最高温 {forecastWeatherInfo.Daily[1].TempMax}
最低温 {forecastWeatherInfo.Daily[1].TempMin}
{forecastWeatherInfo.Daily[1].TextDay}
{forecastWeatherInfo.Daily[1].WindDirDay}
");
            }
            catch (ArgumentException ex)
            {
                switch (ex.Message)
                {
                    case "204":
                        Console.WriteLine("查询的地区没有你想要的数据。");
                        break;
                    case "401":
                        Console.WriteLine("API 密钥错误。");
                        break;
                    case "404":
                        Console.WriteLine("请输入正确的地点。");
                        break;
                    default:
                        Console.WriteLine(@$"错误码：{ex.Message}
请到 https://dev.qweather.com/docs/resource/status-code/ 查看错误码信息。");
                        break;
                }
            }
        }
    }
}