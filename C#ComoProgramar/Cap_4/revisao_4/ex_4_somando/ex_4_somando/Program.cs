using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_somando
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4.3 - somando 1 à variável inteira x 
            int x;

            x = 5;
                        
            Console.WriteLine(x = x + 1);    // imprime a soma         
            Console.WriteLine(x += 1);       // imprime a soma     
            Console.WriteLine(x++);          // imprime e depois incrementa (pós-incrementa)
            Console.WriteLine(++x);          // incrementa e depois imprime (pré-incrementa)
                       
        }
    }
}
