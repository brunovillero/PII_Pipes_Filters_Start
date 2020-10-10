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
            IPicture pic = p.GetPicture("..\\Adds\\índice.jpg");
            IPipe thirdpipe = new PipeNull();
            IPipe secondpipe = new PipeSerial(new FilterNegative(),thirdpipe );
            IPipe firstpipe = new PipeSerial(new FilterGreyscale(),secondpipe);
            p.SavePicture(firstpipe.Send(pic),"..\\Adds\\Ejercicio1.jpg");
            
        }
    }
}
