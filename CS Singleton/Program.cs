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
    //PODEMOS COMPROBAR QUE NO SE PUEDE INSTANCIAR DIRECTAMENTE YA QUE EL CONSTRUCTOR ESTA CON ACCESO PRIVADO
            //CSingleton single = new CSingleton();
            
    //OBTENEMOS EL OBJETO INSTANCIADO CON EL METODO ESTATICO PUBLICO ObtenerInstancia.
            CSingleton uno = CSingleton.ObtenerInstancia();

    //ASIGNAMOS VALORES A LOS ATRIBUTOS DEL OBJETO CREADO
    
            uno.PonerDatos("ANA", 27);
            uno.AlgunProceso();
            Console.WriteLine(uno);
            Console.WriteLine("---");

            //BUSCAMOS INSTANCIAR NUEVAMENTE

            CSingleton dos = CSingleton.ObtenerInstancia();

            //PODEMOS VERIFICAR QUE EL OBJETO 1 ES IGUAL QUE EL OBJETO 2, YA QUE AMBOS TENDRAN VALORES DE LA 1ER INSTANCIA.
            Console.WriteLine(dos);


            Console.ReadLine();




        }
    }
}
