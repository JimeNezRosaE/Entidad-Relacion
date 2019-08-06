using System;
using System.Collections.Generic;
using System.Text;

namespace Parroquia
{
    class Proyecto
    {


        //Rosa Elena Jimenez Gonzalez
        //Angela Patricia Carlos Siatama



        #region Atributos

        #endregion

        #region Propiedades

        #endregion

        public int Libro { get; set; }
        public int Folio { get; set; }

        public string Nombre_Per { get; set; }



        #region Contructores

        public Proyecto(int libro,int folio,string nombre_per)
        {

            Libro = libro;
            Folio = folio;
            Nombre_Per = nombre_per;

        }
        public Proyecto()
        {



        }


        #endregion


        #region Metodos

        public void IngresarDatos()
        {
            Console.WriteLine("Ingrese el libro: ");
            Libro = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el folio");
            Folio = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nombre de la persona: ");
            Nombre_Per = Console.ReadLine();
        }

        public void ImprimirDatos()
        {


            Console.WriteLine($"El libro es: {Libro}");
            Console.WriteLine($"El folio es: {Folio}");
            Console.WriteLine($"El nombre es: {Nombre_Per}");


        }

        public void ModificarDatos()
        {

            Console.WriteLine("Ingrese nuevo libro: s/n");
            string res = Console.ReadLine();
            if (res == "s")
            {
                Console.WriteLine("Digite nuevo libro: ");
                Libro = int.Parse(Console.ReadLine());
            }

            else;
        }


        #endregion

    }
}
