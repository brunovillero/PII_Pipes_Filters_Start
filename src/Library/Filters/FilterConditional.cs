using System;
using CompAndDel;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FilterConditional :IFilter
    {
        public IPicture Filter(IPicture image)
        {
            PictureProvider p2 = new PictureProvider();
            CognitiveFace cog = new CognitiveFace("620e818a46524ceb92628cde08068242",false);
            FilterSave save = new FilterSave();
            save.Filter(image);
            cog.Recognize($"..\\Adds\\{FilterSave.Contador.ToString()}.jpg");
            if (cog.FaceFound)
            {
                
            }

            return image;          
        }
    }
}