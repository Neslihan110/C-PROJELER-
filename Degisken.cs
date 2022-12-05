using System;

namespace degişken
{
    class Program
    {
        static void Main(string[] args)
        {
            // Değişken Tanımlama
            string deger = null;
            //string System = Degisken; //Program içerisinde kullanılan isimler degişken olarak kullanılmaz.
            // rakamla degısken adına baslanmaz
            // degısken tanımlanırken bosluk kullanılamaz
            // _ kullanılabılır ama + -  gıbı operoterler degısken tanımlarken kullanılamaz.
            Console.WriteLine(deger);

            
            //Veri Tipleri
            byte b = 4; 
            sbyte a = 3; 
            short s = 3; 
            ushort u = 2;

            //int long tanımlama şekilleri.
            Int16 i16 = 5;
            int i = 1; 
            Int32 i32 = 4; 
            Int64 i64 = 2; 
            uint ui = 7;
            long l = 7; 
            ulong r = 7;

            //float double tanımlama şekilleri.
            float f = 5; 
            double d = 5.4;

            //char bool tanımlama şekilleri.
            char c = 'a'; 
            bool bl = false;


            // saat ve tarihlerde kullanılan veri tipleri.
            DateTime dt = DateTime.Now; 
            Console.WriteLine(dt);

            // objeck sınıfının kulanım tipleri.
            object o1 = "x";
            object o2 = 'y';
            object o3 = 4.5;
            object o4 = 6;
            

            //String Tanımlama Şekilleri
            string str = string.Empty;
            str = "araba";
            

            //Integer Tanımlama Şekilleri
            int int1 = 4;
            int int2 = 6;
            int in3 = int1 * int2;

            //Bool
            bool b1 = 10 > 2;

            //Değişken Dönüşümleri
            string str20 = "10";
            int int20 = 20;
            string str3 = str20 + int20.ToString();
            Console.WriteLine(str3);

            int int3 = int20 + Convert.ToInt32(str20);//Bu sefer string int e çevrilerek toplamları yazdırılır.
            //Covert.To() metodu ile string birçok veri tipine çevrilebilir ama int e çevirmek için daha çok int.Parse() kullanılır.
            Console.WriteLine(int3);

            int int4 = int20 + int.Parse(str20);//String int e çevrilir ve 40 döndürülür.
            // Parse kullanılırsa stringten çevrilmek zorundadır.
            Console.WriteLine(int4);

            string datetime1 = DateTime.Now.ToString("dd.MM.yyyyy");//şu anki zaman string veritipinde gün.ay.yıl olarak gelir. 
            Console.WriteLine(datetime1);
            string hour = DateTime.Now.ToString("HH.mm");//Saati string olara saat ve dakika olarak getirilir.
            Console.WriteLine(hour);
        }
    }
}