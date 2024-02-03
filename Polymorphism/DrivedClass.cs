using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class DrivedClass : MainClass
    {
        public override void Topla(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        public override void Bol(int a, int b)
        {
            Console.WriteLine(a+b);
        }

    }
    public abstract class MainClass
    {

        // Abstract bir metot'un gövdesi olmaz.(Ve bu metot abstract üyeyinin Sınıfını kalıtım yolu ile alan tüm sınıflarda ezilmek zorundadır.)
        public abstract void Topla(int a, int b);


        // Virtual olan metodun gövdesi olur. Üyesi olduğu sınıfı kalıtım yolu ile alan sınıfta ezilmesi şart değildir.
        // Ezmek istenilirse ezilebilir.
        public virtual void Bol(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        // bir personel sınıfı yazıp/
        // içerisine abstract ve virtual üyeler koyup bir örnek yapınız.
    }
}
