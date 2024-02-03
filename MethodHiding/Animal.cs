using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Animal
    {
        public void Live()
        {


        }
    }

    public   class Cat:Animal
    {

        // Method Hiding olayı : Üst sınıfta olan bir metodun, alt sınıfa kalıtım mimarisi ile geçmesine sağmen, alt sınıfta bu metodun tekrar yazılması işlemine denmektedir.
        // bu durumda derleyici  uyarı verecektir.

        // Türeyen sınıfta bu uyarının çözülmesi için, method imzasına new keyword'ü koymanız gerekmektedir
        // new keyword'ü ile artık yeni bir metot olacaktır
        
        public new void Live()
        {
               

        }
         
    }
}
