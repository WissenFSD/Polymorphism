namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Çok biçimlilik demektir.

            // Aynı zamanda OOP'in 3 temel kuralından bir tanesidir.



            // Bir alt sınıf üst sınıfın tüm üyelerini miras yolu ile alabilir.
            // Ancak üst sınıftan alınan miraslarların davranışlarının değiştirilmesi gerekebilir.


            // Polymorphism bu davranışların, değiştirilmesi(ezilmesi) yada ezilmemesi konusunda yapılacak çalışmaların bütününe denir.



            // Abstact olan class'ların nesne örneği alınmaz....

            // Aynı zamanda içerisinde en az 1 adet abstract üye olan(metot,prop,field etc.) sınıf, kesinlikle abstract olmak zorundadır.
            //MainClass main = new MainClass();


            DrivedClass drived = new DrivedClass();
            drived.Topla(10, 20);
        }
    }
}