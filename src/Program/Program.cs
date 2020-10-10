using System;
using CompAndDel.Filters;
using CompAndDel.Pipes;

namespace CompAndDel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio1

            PictureProvider p = new PictureProvider();
            IPicture pic = p.GetPicture("..\\Adds\\índice.jpg");
            IPipe thirdpipe = new PipeNull();
            IPipe secondpipe = new PipeSerial(new FilterNegative(),thirdpipe );
            IPipe firstpipe = new PipeSerial(new FilterGreyscale(),secondpipe);
            p.SavePicture(firstpipe.Send(pic),"..\\Adds\\Ejercicio1.jpg");
            
            //Ejercicio2
            
            PictureProvider p1 = new PictureProvider();
            IPicture pic1 = p.GetPicture("..\\Adds\\índice.jpg");
            IPipe fifthpipe1= new PipeNull();
            IPipe fourthpipe1= new PipeSerial(new FilterSave(),fifthpipe1);
            IPipe thirdpipe1= new PipeSerial(new FilterNegative(), fourthpipe1);
            IPipe secondpipe1= new PipeSerial(new FilterSave(),thirdpipe1 );
            IPipe firstpipe1= new PipeSerial(new FilterGreyscale(),secondpipe1);
            firstpipe1.Send(pic1);
            
        }
    }
}
