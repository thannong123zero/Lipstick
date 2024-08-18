using Newtonsoft.Json;

namespace Lipstick.Services
{    // language code
    public enum ELanguage
    {
        VN,
        EN
    }
    public static class Globle
    {
        private const string webContentFilePath = @".\LocalData\WebContent.json";
        public static string GetLanguageCode(HttpRequest request)
        {
            string? languageCookie = request.Cookies[".AspNetCore.Culture"];
            if (!string.IsNullOrEmpty(languageCookie) && languageCookie.Contains("en-US"))
            {
                return ELanguage.EN.ToString();
            }
            else
            {
                return ELanguage.VN.ToString();
            }
        }
        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province>();
            string filePath = @".\LocalData\Provinces.json";
            using StreamReader reader = new(filePath);
            var json = reader.ReadToEnd();
            provinces = JsonConvert.DeserializeObject<List<Province>>(json);
            return provinces;
        }
        public static List<WebContent> GetWebContents()
        {
            List<WebContent> webContents = new List<WebContent>();
            var json = GetLocalData();
            webContents = JsonConvert.DeserializeObject<List<WebContent>>(json);
            return webContents;
        }
        public static string GetLocalData()
        {
            using StreamReader reader = new(webContentFilePath);
            string json = reader.ReadToEnd();
            return json;
        }
    }
    public class WebContent
    {
        public string ContentID { get; set; }
        public string EN { get; set; }
        public string VN { get; set; }
        //public string KR { get; set; }
    }
    public class Province
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<District> Districts { get; set; }
        public Province()
        {
            Districts = new List<District>();
        }
    }
    public class District 
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
