using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Prop_
{
    public abstract class Personel
    {

        //Prop'larda abstract olabilirler.

        // Abstract olan propları inherit edilen sınıflarda ezmek gerekmektedir.
        public abstract int Maas { get; set; }
    }
    public class Analist : Personel
    {
        public override int Maas { get => 300; set => throw new NotImplementedException(); }
    }
    public class Yazilimci : Personel
    {
        public override int Maas
        {

            get { return 500; }
            set { Maas = value; }
            
        }

    }
}
