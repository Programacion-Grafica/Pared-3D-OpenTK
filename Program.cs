using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_01
{
    internal class Program
    {
        static void Main(string[] args)
        {   using(Game game = new Game(900, 700))
            {   
                
                game.Run();
            }
        }
    }
}
