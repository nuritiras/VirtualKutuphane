using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKutuphane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap= new Kitap();
            kitap.Oku();

            Dergi dergi = new Dergi();
            dergi.Oku();

            Ansiklopedi ansiklopedi =   new Ansiklopedi();
            ansiklopedi.Oku();
        }
    }
}
