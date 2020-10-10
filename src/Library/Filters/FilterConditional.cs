using System;
using CompAndDel;
using CognitiveCoreUCU;

namespace CompAndDel.Filters
{
    public class FilterConditional
    {
        public Boolean Filter(IPicture image)
        {
            PictureProvider p2 = new PictureProvider();
            CognitiveFace cog = new CognitiveFace("620e818a46524ceb92628cde08068242",false);
            FilterSave save = new FilterSave();
            save.Filter(image);
            cog.Recognize($"..\\Adds\\{FilterSave.Contador.ToString()}.jpg");
            return cog.FaceFound;         
        }
    }
}