using System;

namespace siniflar

{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            Erişim Belirleyiciler 
            1* Public: Her yerden erişilebilir.
            2* Private: Sadece tanımlandığı sınıf içerisinden erişilebilir.
            3* Internal: Sadece bulunduğu proje içerisinden erişilebilir.
            4* Protected: Sadece tanımlandığı sınıfta ya da o sınıfı miras alan sınıflardan erişilebilir.
            */

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 9541244;
            calisan1.Departman = "insan kaynakları";
            calisan1.CalisanBilgileri();

            Console.WriteLine(" ");
            
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 245454545;
            calisan2.Departman = "satın alma";
            calisan2.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }

    }

}
