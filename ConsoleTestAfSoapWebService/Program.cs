using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestAfSoapWebService
{
    class Program
    {
        static void Main(string[] args)
        {
            //Først oprettet vi en "service referance" til WSDL filen på vores SOAP webservice. 
            //dereftrer laver vi en variable der peger på webservicen, så nu kan vi via. variablen
            //kalde alle de metoder og propperties der er i denne. 
            using (var client = new ServiceReference1.ServiceClient("BasicHttpBinding_IService"))
            {
                //getMyEmail metode fra vores webservice 
                Console.WriteLine(client.getMyEmail()); 

                //OBS! SOAP webservicen skal køre, eller kommer den med en fejl 
            }

            Console.ReadLine( );

        }
    }
}
