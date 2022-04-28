# QWeatherAPI
## 简介
QWeatherAPI 是一个可以查询和风天气 API 的开源项目。

## 实例应用
请在 **[src/ExampleApp](https://github.com/WinExp/QWeatherAPI/tree/master/src/ExampleApp "演示应用")** 目录下查看。

## 使用方法
1.在项目或在该项目的 Nuget 包管理器内引用该项目。

2.在您的 C# 代码中添加如下代码：

`using QWeatherAPI;`

### GetRealTimeWeatherAsync()
#### 使用方法
`await QWeatherAPI.RealTimeWeatherAPI.GetRealTimeWeatherAsync(arguments);`

#### 参数
1.`GetRealTimeWeatherAsync(double lon, double lat, string key, Units unit = Units.Metric, string lang = "zh")`

2.`GetRealTimeWeatherAsync(string id, string key, Units unit = Units.Metric, string lang = "zh")`

### GetGeoAsync()
#### 使用方法
`await QWeatherAPI.GeoAPI.GetGeoAsync(arguments);`

#### 参数
1.`GetGeoAsync(string location, string key, string adm, string range = "world", int limit = 10, string lang = "zh")`

2.`GetGeoAsync(string location, string key, string range = "world", int limit = 10, string lang = "zh")`

### GetHourlyForecastWeatherAsync()
#### 使用方法
`await QWeatherAPI.WeatherHourlyForecastAPI.GetHourlyForecastWeatherAsync(arguments)`

#### 参数
1.`GetHourlyForecastWeatherAsync(double lon, double lat, string key, Units unit = Units.Metric, string lang = "zh")`

2.`GetHourlyForecastWeatherAsync(string id, string key, Units unit = Units.Metric, string lang = "zh")`

### GetWeatherDailyForecastAsync()
#### 使用方法
`await QWeatherAPI.WeatherDailyForecastAPI.GetWeatherDailyForecastAsync(arguments)`

#### 参数
1.`GetWeatherDailyForecastAsync(string id, string key, string lang = "zh", Units unit = Units.Metric, DailyCount dailyCount = DailyCount._3Day)`

2.`GetWeatherDailyForecastAsync(double lon, double lat, string key, string lang = "zh", Units unit = Units.Metric, DailyCount dailyCount = DailyCount._3Day)`

### 更多方法等待更新...

### 你也可以向我提交 Issues 或者 Pull requests 来表达你的意见。

## 本库使用 MPL 2.0 开源协议进行许可。