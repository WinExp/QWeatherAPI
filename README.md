# QWeather
## 简介
QWeatherAPI 是一个可以查询和风天气的 “实时天气” 和 “城市信息查询” 的API。

## 实例应用
请在 “src/ExampleApp” 目录下查看。

## 使用方法
1.在项目或在该项目的 Nuget 包管理器内引用该项目。

2.在您的 C# 代码的最顶端添加如下代码：

`using QWeatherAPI;`

### GetRealTimeWeatherAsync
#### 使用方法
`await QWeatherAPI.QWeather.GetRealTimeWeatherAsync(locationInfo.Lon, locationInfo.Lat, "af71f6c5c1e94ec4abf618febf35ca68");`

#### 参数
`GetRealTimeWeatherAsync(double lon, double lat, string key, string unit = "m", string lang = "zh")`

### GetGeoAsync
#### 使用方法
`await QWeatherAPI.QWeather.GetGeoAsync(location, key);`

#### 参数
1.`GetGeoAsync(string location, string key, string adm, string range = "world", int limit = 10, string lang = "zh")`

2.`GetGeoAsync(string location, string key, string range = "world", int limit = 10, string lang = "zh")`

### 更多方法等待更新...

### 你也可以向我提交 Issues 或者 Pull requests 来表达你的意见。

## MIT 开源协议
MIT License

Copyright (c) 2022 WinExp

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.