using System;

namespace Parroquia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rosa Elena Jimenez Gonzalez
            //Angela Patricia Carlos Siatama



            Proyecto proyec = new Proyecto();
            proyec.IngresarDatos();
            proyec.ImprimirDatos();
            proyec.ModificarDatos();

            Console.ReadLine();
        }
    }
}
