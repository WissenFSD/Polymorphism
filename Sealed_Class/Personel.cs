using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Class
{


    // Bir class sealed olarak işaretlenirse, hiç bir class o class'ı kalıtım olarak alamaz.
    internal sealed class Personel
    {
        public void Calis() { }
    }



    // TeknikDestek isimli sınıf personel sınıfını kalıtım olarak almaya çalıştığında hata alır çünkü personel sınıfı sealed  olarak işaretlenmiştir.
    public class TeknikDestek:Personel
    {



    }
}
