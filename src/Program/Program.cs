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


            //Ejercicio4

            PictureProvider p3 = new PictureProvider();
            PictureProvider p4 = new PictureProvider();
            IPicture pic3 = p3.GetPicture("..\\Adds\\índice.jpg");
            IPicture pic4 = p4.GetPicture("..\\Adds\\Auto.jpg");

            IPipe fifthpipe3 = new PipeNull();

            IPipe fourthpipe3 = new PipeSerial(new FilterNegative(), fifthpipe3);

            IPipe thirdpipe3 = new PipeSerial(new FilterTwitter(), fifthpipe3);

            IPipe secondpipe3 = new PipeConditionalFork(new FilterConditional(), thirdpipe3 ,fourthpipe3);

            IPipe firstpipe3= new PipeSerial(new FilterGreyscale(),secondpipe3);

            firstpipe3.Send(pic3);
            p4.SavePicture(firstpipe.Send(pic4),"..\\Adds\\auto2.jpg");




            //Ejercicio5
            PictureProvider p5 = new PictureProvider();
            IPicture pic5 = p5.GetPicture("..\\Adds\\índice.jpg");
            IPipe secondpipe5 = new PipeNull();
            IPipe firstpipe5 = new PipeSerial(new FilterRandomConvolution(),secondpipe5);
            p5.SavePicture(firstpipe5.Send(pic5),"..\\Adds\\Ejercicio5.jpg");
            
        }
    }
}
