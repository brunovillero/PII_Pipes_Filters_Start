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
            IPicture pic1 = p1.GetPicture("..\\Adds\\índice.jpg");
            IPipe fifthpipe1= new PipeNull();
            IPipe fourthpipe1= new PipeSerial(new FilterSave(),fifthpipe1);
            IPipe thirdpipe1= new PipeSerial(new FilterNegative(), fourthpipe1);
            IPipe secondpipe1= new PipeSerial(new FilterSave(),thirdpipe1 );
            IPipe firstpipe1= new PipeSerial(new FilterGreyscale(),secondpipe1);
            firstpipe1.Send(pic1);

            //Ejercicio3

            PictureProvider p2 = new PictureProvider();
            IPicture pic2 = p2.GetPicture("..\\Adds\\índice.jpg");

            IPipe fifthpipe2 = new PipeNull();

            IPipe fourthpipe2 = new PipeSerial(new FilterTwitter(), fifthpipe2);

            IPipe thirdpipe2 = new PipeSerial(new FilterNegative(), fourthpipe2);

            IPipe secondpipe2 = new PipeSerial(new FilterTwitter(), thirdpipe2);

            IPipe firstpipe2= new PipeSerial(new FilterGreyscale(),secondpipe2);

            firstpipe2.Send(pic2);


            
        }
    }
}
