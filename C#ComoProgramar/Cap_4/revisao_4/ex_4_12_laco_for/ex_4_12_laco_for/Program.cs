using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_12_laco_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = 1;

            while (N <= 5)
            {
                Console.WriteLine("N = " + N );                
                N += 1;
            }

            // 4.13 x = 9 e y = 11
            int x,
                y;

            x = 9;
            y = 11;

            if (x < 10)
                if (y > 10)
                    Console.WriteLine( "********" );
                else
                    Console.WriteLine( "#######" );
                    Console.WriteLine( "$$$$$$$" );


            if (x < 10)
            {
                if (y > 10)
                    Console.WriteLine( "********" );
            }
            else
            {
                Console.WriteLine( "########" );
                Console.WriteLine(  "$$$$$$$" );
            }   

            
        }
    }
}
