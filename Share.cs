using System.Text;

namespace AUO.SmartCaring.Model.Core
{
    public static class Share
    {
        public static string GetConnectionString()
        {
            //TODO: 需改為讀取appsettings.json
            //return "Server=10.86.10.201;database=smartcaring;uid=scadmin;pwd=sc@aitba2;SslMode=None;Charset=utf8;";
            return "Server=10.250.12.4;database=schr;uid=scadmin;pwd=sc@aitba2;SslMode=None;Charset=utf8;";
        }

        public static string GetStringWithWhiteSpace(this string orgStr, int whiteSpaceCount)
        {
            var whiteSpaceStr = "";
            for (int i = 0; i < whiteSpaceCount; i++)
            {
                whiteSpaceStr += " ";
            }
            return $"{whiteSpaceStr}{orgStr}";
        }

        public static string GetInterfaceName(this string orgStr)
        {
            return $"I{orgStr.Substring(0, 1).ToUpper()}{orgStr.Substring(1)}";
        }

        public static string GetClassOrPropertyName(this string orgStr)
        {
            var orgStrArr = orgStr.Split("_");
            var resultStr = new StringBuilder();
            foreach (var item in orgStrArr)
            {
                //System.Console.WriteLine("Original String: " + item);
                if (!string.IsNullOrEmpty(item))
                {
                    var lowerSubStr = item.Length > 1 ? item.Substring(1) : "";
                    resultStr.Append($"{item.Substring(0, 1).ToUpper()}{lowerSubStr}");
                }
            }
            return resultStr.ToString();
        }
    }
}