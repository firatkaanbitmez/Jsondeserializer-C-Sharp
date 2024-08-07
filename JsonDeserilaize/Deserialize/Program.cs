
/* JSON KÜTÜPHANESİNE İHTİYAÇ VAR Deserialize için
 */
using Newtonsoft.Json;

namespace Deserialize
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("FIRST METHOD ******");
            //json veriyi getirir
            var data = GetJsonData();

            //kullanacağım model weather
            //Json datamı modele uyarlamam gerekli

            var MyEntitites = Deserialize(data);

            // c# modelimi Jsona geri çevir
            ConvertJson(MyEntitites);




            Console.WriteLine('\n');





            Console.WriteLine("SECOND METHOD *********");

            // GetJsonData();
            // Deserialize(GetJsonData());   ALT ALTA YAZMAK YERİNE TEK BİR SATIRDA YAZABİLİRİZ
            ConvertJson(Deserialize(GetJsonData()));
            


        }

       
        public static void ConvertJson(Weather model)
        {
            WriteMessage("Json dataya geri çevirme başladı.");
            var jsonObject =JsonConvert.SerializeObject(model);
            WriteMessage(jsonObject);
        }

        //GetJson datayı içine atacağız
        public static Weather Deserialize(string model)
        {
            WriteMessage("C# modelimize uyarlıyoruz!");
            var convertData =JsonConvert.DeserializeObject<Weather>(model);   // ctrl + .add json library
            WriteMessage(convertData.GetType().ToString());
            WriteMessage(convertData.Summary);
            return convertData;

        }

        public static void WriteMessage(string message)
        {
            Console.WriteLine(message);
        }


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



    }

}
   