using System.Collections.Generic;

namespace RustCalc.Helper
{
    static public class ImageUrlStore
    {
        static private Dictionary<string, string> _imageDictionary;

        static ImageUrlStore()
        {
            _imageDictionary.Add("Rocket", "http://vignette1.wikia.nocookie.net/play-rust/images/9/95/Rocket_icon.png/revision/latest?cb=20151106061039");
            _imageDictionary.Add("Satchel Charge", "http://vignette2.wikia.nocookie.net/play-rust/images/0/0b/Satchel_Charge_icon.png/revision/latest?cb=20160813023035");
            _imageDictionary.Add("Timed Mine", "http://vignette1.wikia.nocookie.net/play-rust/images/6/6c/Timed_Explosive_Charge_icon.png/revision/latest?cb=20151106061610");
            


        }

        public static string GetImageUri(string imageName)
        {
            string imageUri = "";
            _imageDictionary.TryGetValue(imageName, out imageUri);
            return imageUri;
        }
    }
}
