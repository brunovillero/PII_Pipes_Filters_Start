using System;
using CompAndDel;
using TwitterUCU;

namespace CompAndDel.Filters
{
    public class FilterTwitter: IFilter
    {
        private string consumerKey = "CkovShLMNVCY0STsZlcRUFu99";
        private string consumerKeySecret = "6rc35cHCyqFQSy4vIIjKiCYu31qqkBBkSS5BRlqeYCt5r7zO5B";
        private string accessTokenSecret = "gNytQjJgLvurJekVU0wmBBkrR1Th40sJmTO8JDhiyUkuy";
        private string accessToken = "1396065818-MeBf8ybIXA3FpmldORfBMdmrVJLVgijAXJv3B18";
        public IPicture Filter(IPicture image)
        {
            var twitter = new TwitterImage(consumerKey, consumerKeySecret, accessToken, accessTokenSecret);
            FilterSave save = new FilterSave();
            save.Filter(image);
            twitter.PublishToTwitter("Ejercicio 4", $"..\\Adds\\{FilterSave.Contador.ToString()}.jpg");
            return image;
        }
    }
}