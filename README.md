# Jsondeserializer-c#

Serilization (Serileştirme) : .NET üzerinde üzerinde işlem yaptığımız bir nesnenin, bir sınıfın saklanmak istenilen ya da gönderilmek istenilen formata dönüştürülmesi işlemidir. 

Deserilization (ters serileştirme) : ise serilizasyon uygulanmaış olan nesne, datanın tekrar okunabilir hale getirilmesidir.

Json Convert c# sitesi :  http://json2csharp.com/

Kullanılan Json Model Aşağıdadır. ***

public static string GetJsonData()
        {
            var model = @"{
            'Date': '2019 - 08 - 01T00: 00:00 - 07:00',
            'TemperatureCelsius': 25,
            'Summary': 'Hot',
            'TemperatureRanges': {
                          'coldMinTemp': 20,
              'hotMinTemp': 40
            }
           }";

            return model;
        }
