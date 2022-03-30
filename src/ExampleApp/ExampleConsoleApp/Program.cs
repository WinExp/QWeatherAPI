namespace ExampleConsoleApp
{
    class Program
    {
        static void Main()
        {
            Console.Write("请输入 API 密钥：");
            string key = Console.ReadLine();
            Console.Write("请输入地点名称：");
            string location = Console.ReadLine();
            try
            {
                var locationInfo = QWeatherAPI.QWeather.GetGeoAsync(location, key).Result.Locations[0];
                var weatherInfo = QWeatherAPI.QWeather.GetRealTimeWeatherAsync(locationInfo.Lon, locationInfo.Lat, "af71f6c5c1e94ec4abf618febf35ca68").Result;
                Console.WriteLine(@$"{locationInfo.Name}的天气
当前温度 {weatherInfo.Now.Temp}°C
体感温度 {weatherInfo.Now.FeelsLike}°C
{weatherInfo.Now.Text}
{weatherInfo.Now.WindDir}");
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