using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace firstprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nummer = 20;

            bool isfemale = false;
            string gender = "parmis";

            if (nummer > 20)
            {

                Console.WriteLine("Talet är stort");



            }
            else if (nummer < 20)
            {
                Console.WriteLine("Oj lågt tal");
            }


            Console.WriteLine("Vad heter du?");
            string namn = Console.ReadLine();
            Console.WriteLine("hej" + namn);


            for (int i = 0; i <= nummer; i++)
            {

                Console.WriteLine(i);
            }


            Console.WriteLine("vadheter du");
            string name = Console.ReadLine();



            if (name == gender)
            {
                isfemale = true;

                Console.WriteLine(isfemale);
            } 
            else

            {
                isfemale = false;
                Console.WriteLine(isfemale);
            }
        }
    }
}
