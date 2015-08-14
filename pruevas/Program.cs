using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruevas
{
    class Program
    {
        static void Main(string[] args)
        {
             int numO = 10; // Convert.ToInt32(numero);

            int mod;

            List<int> listaH = new List<int>();
            while (numO > 0)
            {
                
                mod = numO % 16;
                if (mod == 10)
                {

                    string mod1 = Convert.ToString(mod);//=  "A");
                    mod1 = "A";
                }
                if (mod == 11)
                {
                    mod = 'B';
                }
                if (mod == 12)
                {
                    mod = 'C';
                }
                if (mod == 13){
                    mod = 'D';
                }
                if (mod == 14)
                {
                    mod = 'E';
                }
                if (mod == 15)
                {
                    mod = 'F';

                }
                
                numO = numO / 16;
                listaH.Add(mod);
            }
            listaH.Reverse();
            string hexa = string.Join("", listaH.ToArray());
           // return hexa;
            Console.WriteLine(hexa);

        //}
            
            Console.ReadKey();
            }
        
        
            
        /*     string bin;

             for (int i = 0; i >= lista.Count; i++)
             {
               
                 bin = Convert.ToString (lista[i]);
             }
             return Convert.ToInt32 (bin);*/
                
        

        }
    }

