using PatronesDeDiseñoConsole.Models;
using System;
using System.Linq;

namespace PatronesDeDiseñoConsole
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var context = new PatronesDeDiseñoContext() )
            {
                var lst = context.Ejemplos.ToList();
                foreach (var item in lst)
                {
                    Console.WriteLine(item.Name.ToString());
                }
            }
        }
    }
}
