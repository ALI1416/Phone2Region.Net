# Phone Number To Region For .Net 手机号码转区域.Net版

[![License](https://img.shields.io/github/license/ALI1416/Phone2Region.Net?label=License)](https://www.apache.org/licenses/LICENSE-2.0.txt)
[![.Net Support](https://img.shields.io/badge/.NET%20Standard-2.0+-green)](https://openjdk.org/)
[![NuGet Gallery](https://img.shields.io/nuget/v/Z.Phone2Region.Net?label=NuGet%20Gallery)](https://www.nuget.org/packages/Z.Phone2Region.Net)
[![Tag](https://img.shields.io/github/v/tag/ALI1416/Phone2Region.Net?label=Tag)](https://github.com/ALI1416/Phone2Region.Net/tags)
[![Repo Size](https://img.shields.io/github/repo-size/ALI1416/Phone2Region.Net?label=Repo%20Size&color=success)](https://github.com/ALI1416/Phone2Region.Net/archive/refs/heads/master.zip)

[![DotNet CI](https://github.com/ALI1416/Phone2Region.Net/actions/workflows/ci.yml/badge.svg)](https://github.com/ALI1416/Phone2Region.Net/actions/workflows/ci.yml)

## 简介

本项目迁移自[ALI1416/phone2region](https://github.com/ALI1416/phone2region)，构建后`Z.Phone2Region.Net.dll`文件仅`9kb`

## 数据文件

- 数据文件目录：[点击查看](https://github.com/ALI1416/phone2region/tree/master/data)

### 其他语言项目

- `Java` : [ALI1416/phone2region](https://github.com/ALI1416/phone2region)
- `JavaScript` : [ALI1416/phone2region-js](https://github.com/ALI1416/phone2region-js)

## 依赖导入

```sh
dotnet add package Z.Phone2Region.Net
```

## 使用示例

### 解析手机号码区域

```csharp
string url = "https://www.404z.cn/files/phone2region/v2.0.0/data/phone2region.zdb";
int phone = 1875471;
Phone2Region.initByUrl(url);
Region region = Phone2Region.parse(phone);
if (region == null)
{
    Console.WriteLine("未找到");
}
else
{
    Console.WriteLine(region.province + " " + region.city + " " + region.zipCode + " " + region.areaCode + " " + region.isp);
}
// 输出： 山东 济宁 272000 0537 移动
```

更多请见[测试](./Z.Phone2Region.Net.Test)

## 更新日志

[点击查看](./CHANGELOG.md)

## 参考

- [ALI1416/phone2region](https://github.com/ALI1416/phone2region)

## 关于

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://www.404z.cn/images/about.dark.svg">
  <img alt="About" src="https://www.404z.cn/images/about.light.svg">
</picture>
