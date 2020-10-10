using System;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterSave :IFilter
    {
        private static int contador=0;

        public IPicture Filter(IPicture image)
        {
            contador +=1;
            PictureProvider p2 = new PictureProvider();
            p2.SavePicture(image, $"..\\Adds\\{contador.ToString()}.jpg");  
            return image;          
        }
    }
}