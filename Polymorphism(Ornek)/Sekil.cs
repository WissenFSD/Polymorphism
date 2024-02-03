using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Ornek_
{
    public abstract class Sekil
    {
        public abstract double Alan();
        public abstract double Cevre();



        //base sınıfın objectten kalıtım ile gelen ToString metodunu ezdik
        public override string ToString()
        {
            return base.ToString().Split('.')[1];
        }
    }
    public class Daire:Sekil
    {
        
        public int YariCap { get; set; }
      

        public override double Alan()
        {
            return Math.PI * (YariCap * YariCap);
        }
        public override double Cevre()
        {
            return 2 * Math.PI * YariCap;
        }

    }
    public class Ucgen : Sekil
    {
        public int Taban { get; set; }
        public int Yukseklik { get; set; }
        public int Kenar { get; set; }

        public override double Alan()
        {
            return (Taban * Yukseklik) / 2;
        }
        public override double Cevre()
        {
            return Kenar * 3;
        }
    }
    public class Dikdortgen:Sekil
    {
        public int KisaKenar { get; set; }
        public int UzunKenar { get; set; }

        public override double Alan()
        {
            return UzunKenar * KisaKenar;
        }
        public override double Cevre()
        {
            return (UzunKenar * 2) + (KisaKenar * 2);

        }
    }
         
}
