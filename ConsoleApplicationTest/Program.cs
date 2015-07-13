using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplicationTest
{
    class Program
    {
        static int value1;
        static int value2;

        static void Main(string[] args)
        {
            string textValue1 = Console.ReadLine();
            string textValue2 = Console.ReadLine();
            try
            {
                value1 = getIntValue(textValue1);
            }
            catch (Exception) { 
                Console.WriteLine("Falscheingabe beim ersten wert");
            }
            try {
            value2 = getIntValue(textValue2);
            } catch (Exception) {
                Console.WriteLine("Falscheingabe beim 2. Wert");
            }
            calculateResult(value1, value2);
            Console.ReadLine();
        }

        private static void calculateResult(int value1, int value2)
        {
            ServiceReferenceAddition.IServiceAddition client = new ServiceReferenceAddition.ServiceAdditionClient();

            try
            {
                int result = client.Addition(value1, value2);
                Console.WriteLine(result);
                
            }
            catch (Exception)
            {
                Console.WriteLine("Fehler bei der Berechnung!");
            }


        }

        private static int getIntValue(string value)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
            
    }
}
