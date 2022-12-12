using System;

namespace EncapsulationveProperty

{
  class Program
  {
   
    static void Main(string[] args)
    {
      Ogrenci ogrenci = new Ogrenci();
      ogrenci.Isim = "murat";
      ogrenci.Soyisim = "canpolat";
      ogrenci.Ogr_no = 54;
      ogrenci.Sinif = 4;
      ogrenci.OgrenciBilgileriniGetir();
      ogrenci.SinifAtlat();
      ogrenci.OgrenciBilgileriniGetir();

      Ogrenci ogrenci1 = new Ogrenci("Neslihan", "cavdar", 41, 4);
      ogrenci1.OgrenciBilgileriniGetir();
      ogrenci1.SinifDusur();
    }
  }

  class Ogrenci
  {
    private string isim;
    private string soyisim;
    private int ogr_no;
    private int sinif;

    public string Isim
    {
      get => isim;
      set => isim = value;
    }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Ogr_no { get => ogr_no; set => ogr_no = value; }
    public int Sinif
    {
      get => sinif;
      set
      {
        if (value < 1)
        {
          Console.WriteLine("Sınıf en az 1 olabilir!");
          sinif = 1;
        }
        else
          sinif = value;
      }
    }

    public Ogrenci(string isim, string soyisim, int ogr_no, int sinif)
    {
      Isim = isim;
      Soyisim = soyisim;
      Ogr_no = ogr_no;
      Sinif = sinif;
    }

    public Ogrenci() { }

    public void OgrenciBilgileriniGetir()
    {
      Console.WriteLine("*** Öğrenci Bilgileri: ***");
      Console.WriteLine("Öğrenci adı      : " + this.Isim);
      Console.WriteLine("Öğrenci soyadı   : " + this.Soyisim);
      Console.WriteLine("Öğrenci no       : " + this.Ogr_no);
      Console.WriteLine("Öğrencinin Sınıfı: " + this.Sinif);
    }

    public void SinifAtlat()
    {
      this.Sinif = this.Sinif + 1;
    }

    public void SinifDusur()
    {
      this.Sinif = this.Sinif - 1;
    }

  }

}