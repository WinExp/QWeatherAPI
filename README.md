# QWeather
## 简介
QWeatherAPI 是一个可以查询和风天气的 “实时天气” 和 “城市信息查询” 的API。

## 使用方法
1.在项目或在该项目的 Nuget 包管理器内引用该项目。

2.在您的 C# 代码的最顶端添加如下代码：

`using QWeatherAPI;`

### API 方法
#### GetRealTimeWeatherAsync
##### 使用方法
`await QWeatherAPI.QWeather.GetRealTimeWeatherAsync(locationInfo.Lon, locationInfo.Lat, "af71f6c5c1e94ec4abf618febf35ca68");`

##### 参数
`GetRealTimeWeatherAsync(double lon, double lat, string key, string unit = "m", string lang = "zh")`

#### GetGeoAsync
##### 使用方法
`await QWeatherAPI.QWeather.GetGeoAsync(location, key);`

##### 参数
1.`GetGeoAsync(string location, string key, string adm, string range = "world", int limit = 10, string lang = "zh")`

2.`GetGeoAsync(string location, string key, string range = "world", int limit = 10, string lang = "zh")`

#### 更多方法等待更新...

#### 你也可以向我提交 Issues 或者 Pull requests 来表达你的意见。