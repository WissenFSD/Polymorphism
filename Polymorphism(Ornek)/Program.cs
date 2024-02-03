namespace Polymorphism_Ornek_
{
    internal class Program
    {


        // Poli : Çok biçimlilik demektir.

        // Ana class'ta olan abstract alan ve çevre metotları, çok biçimliliğe uygun olarak tasarlandı.


        // Alan ve çevre metotları ucgen,diktortgen ve daire sınıfları için katılıldı

        // tek bir noktada tasarlanan bu metotlar istenilen kadar sınıf için ezilerek kullanılabilir.


        // Polymorphism ile aynı metotların farklı sınıflar için farklı değerler döndürmesi Polymorphism demektir.
        // 
        static void Main(string[] args)
        {
            Dikdortgen dortgen = new Dikdortgen();
            dortgen.KisaKenar = 3;
            dortgen.UzunKenar = 10;


            double dortgenAlan = dortgen.Alan();
            double dortgenCevre = dortgen.Cevre();
            //Console.WriteLine("Diktortgen Alan : {0}", dortgenAlan);
            //Console.WriteLine("Diktortgen ÇEvre : {0}", dortgenCevre);


            AlanveCevre(dortgen);


            Ucgen ucgen = new Ucgen();
            ucgen.Kenar = 5;
            ucgen.Taban = 8;
            ucgen.Yukseklik = 2;

            double ucgenCevre = ucgen.Cevre();
            double ucgenAlan = ucgen.Alan();

            //Console.WriteLine("Üçgen Alan : {0}", ucgenAlan);
            //Console.WriteLine("Üçgen Çevre : {0}", ucgenCevre);

            AlanveCevre(ucgen);

            Daire daire = new Daire();
            daire.YariCap = 4;


            double daireAlan = ucgen.Alan();
            double daireCevre = ucgen.Cevre();

            //Console.WriteLine("Daire Alan : {0}", daireAlan);
            //Console.WriteLine("Daire Çevre : {0}", daireCevre);
            AlanveCevre(daire);




            


            // Yazdırma olayı tüm sınıflar için tekrar edeceğine, genel bir metot yazıp, tüm Sekilden türeyen neslerin bu metot içerisine girebilmesini sağlayabiliriz.
        }
        public static void AlanveCevre(Sekil sekil)
        {
            //if(Sekil is Ucgen)
            //{

            //}
            //else if(Sekil is Daire)
            //{

            //}
            //else if(Sekil is Dikdortgen)
            //{

            //}
            Console.WriteLine(sekil);


            
            Console.WriteLine("Alan : {0}", sekil.Alan());
            Console.WriteLine("Çevre : {0}", sekil.Cevre());
        }
    }
}