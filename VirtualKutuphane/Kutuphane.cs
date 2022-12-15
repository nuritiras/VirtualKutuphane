using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualKutuphane
{
    public class Kutuphane
    {

        public virtual void Oku()
        {
            Console.WriteLine("Okuma işlemini başarıyla gerçekleştirdiniz.");
        }
    }

    public class Kitap:Kutuphane
    {
        public override void Oku()
        {
            Console.WriteLine("Kitap okuma işlemini başarıyla gerçekleştirdiniz.");
        }
    }

    public class Dergi:Kutuphane
    {
        public override void Oku()
        {
            Console.WriteLine("Dergi okuma işlemini başarıyla gerçekleştirdiniz.");
        }
    }

    public class Ansiklopedi:Kutuphane
    {
        public override void Oku()
        {
            Console.WriteLine("Ansiklopedi okuma işlemini başarıyla gerçekleştirdiniz.");
        }
    }


}
