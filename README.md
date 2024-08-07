# JsonDeserializer - C#

## Serileştirme (Serialization)
.NET üzerinde işlem yaptığımız bir nesnenin, bir sınıfın saklanmak istenilen ya da gönderilmek istenilen formata dönüştürülmesi işlemidir.

## Ters Serileştirme (Deserialization)
Serileştirme uygulanmış olan nesne veya datanın tekrar okunabilir hale getirilmesidir.

## Json Convert C# Sitesi
Json dönüşümleri için faydalı bir kaynak: [json2csharp.com](http://json2csharp.com/)

## Kullanılan Json Model
Aşağıda kullanılan JSON modelini görebilirsiniz:

```csharp
public static string GetJsonData() 
{
    var model = @"{ 
        'Date': '2019-08-01T00:00:00-07:00', 
        'TemperatureCelsius': 25, 
        'Summary': 'Hot', 
        'TemperatureRanges': { 
            'coldMinTemp': 20, 
            'hotMinTemp': 40 
        } 
    }";

    return model;
}
