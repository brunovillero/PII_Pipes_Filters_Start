using System;
using CompAndDel.Filters;
using CompAndDel.Pipes;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture("C:/Users/matia/c#/pipes-filter/PII_Pipes_Filters_Start/src/Adds/índice.jpg");
            IFilter filter1 = new FilterGreyscale();
            IPipe firstpipe = new PipeSerial(filter1, secondpipe);
            IFilter filter2 = new FilterNegative();
            IPipe secondpipe = new PipeSerial(filter2, );
            IPipe thirdpipe = new PipeNull();
        }
    }
}
