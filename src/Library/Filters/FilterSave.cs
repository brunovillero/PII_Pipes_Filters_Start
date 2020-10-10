using System;
using CompAndDel;

namespace CompAndDel.Filters
{
    public class FilterSave :IFilter
    {
        public IPicture Filter(IPicture image)
        {
            PictureProvider p2 = new PictureProvider();
            p2.SavePicture(image, $"..\\..\\Adds\\{DateTime.Now.Hour.ToString().Replace(" ","-")}.jpg");  
            return image;          
        }
    }
}