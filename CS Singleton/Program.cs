using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "";
            int edad = 0;
           
            //PODEMOS COMPROBAR QUE NO SE PUEDE INSTANCIAR DIRECTAMENTE YA QUE EL CONSTRUCTOR ESTA CON ACCESO PRIVADO
            //CSingleton single = new CSingleton();

            //CARGAMOS LOS VALORES POR PRIMERA VEZ
            Console.WriteLine("Ingrese nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad");
            edad = Convert.ToInt32(Console.ReadLine());

            //INVOCAMOS AL METODO ESTATICO DE ACCESO GLOBAL ObtenerInstancia E INICIALIZAMOS A LA VARIABLE uno CON UNA REFERECIA A LA UNICA INSTANCIA DE LA CLASE CSingleton (instancia).
            //POR OTRA PARTE LA VARIABLE uno TENDRA ACCESO A LOS METODOS Y PROPIEDADES DE LA CLASE CSingleton.
            CSingleton uno = CSingleton.ObtenerInstancia(edad, nombre);
            Console.WriteLine("Se invoca al metodo estatico por primera vez");
            Console.WriteLine(uno);

            //CARGAMOS LOS VALORES POR SEGUNDA VEZ
            Console.WriteLine("Ingrese nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese edad");
            edad = Convert.ToInt32(Console.ReadLine());

            //INVOCAMOS NUECAMENTE PASANDOLE OTROS VALORES. ACA DEBERIA TOMAR LOS VALORES DE LA 1ER INSTANCIA Y DEVOLVERLOS SALIENDO DEL IF.

            CSingleton dos = CSingleton.ObtenerInstancia(edad, nombre);
            Console.WriteLine("Se invoca al metodo estatico por segunda y se pasan nuevos valores. Como puede verificarse el resultado son los valores de la 1er instancia.");
            Console.WriteLine(dos);


            Console.ReadLine();




        }
    }
}
