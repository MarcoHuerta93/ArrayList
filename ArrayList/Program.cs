using System;
using System.Collections;

namespace ArrayListPart
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //declarar un ArrayList indeterminado

            ArrayList miArraList = new ArrayList();

            //declarar un ArrayList determinado
            ArrayList miArraList2 = new ArrayList(1000);


            //agregar elementos al arrayList
            miArraList.Add(25);
            miArraList.Add("Hola");
            miArraList.Add(13.37);
            miArraList.Add(13);
            miArraList.Add(128);
            miArraList.Add(25.3);

            //Eliminar elementos del arrayList por valor
            miArraList.Remove(13);

            //Eliminar elementos del arrayList por índice
            miArraList.Remove(0);

            //Contar elementos del arrayList
            Console.WriteLine(miArraList.Count);

            double suma = 0;
            foreach (object obj in miArraList)
            {
                if (obj is int)
                {
                    suma += Convert.ToDouble(obj);

                }
                else if(obj is double)
                {
                    suma += (double)obj;
                }
                else if (obj is string)
                {
                    Console.WriteLine(obj);
                }

            }
            Console.WriteLine(suma);
            Console.Read();
        }
    }
}
