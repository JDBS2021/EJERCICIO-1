using System;

namespace EJERCICIO1
{
    class Program
    {
        static void Main(string[] args)
        {
            String NombreAlumno;
            Double Nota1 = 0, Nota2 = 0, Nota3 = 0, PromedioNotas = 0;

            Console.Write("digite el nombre del alumno:  ");
            NombreAlumno = (Console.ReadLine());
            Console.Write("digite la primera nota por favor:  ");
            Nota1 = System.Double.Parse(Console.ReadLine());
            Console.Write("digite la segunda nota por favor:  ");
            Nota2 = System.Double.Parse(Console.ReadLine());
            Console.Write("digite la tercera nota por favor:  ");
            Nota3 = System.Double.Parse(Console.ReadLine());

            PromedioNotas = (Nota1 + Nota2 + Nota3) / 3;

            Console.WriteLine("EL NOMBRE DEL ALUMNO ES: "+NombreAlumno);
            Console.WriteLine("EL PROMEDIO DEL ALUMNO ES: "+PromedioNotas);

            if (PromedioNotas >= 30)
            {
                Console.Write("EL ESTUDIANTE APROBO ");
            }
            else 
            {
                Console.Write("EL ESTUDIANTE REPROBO ");
            }
            Console.ReadKey();
        }
    }
}


        




    