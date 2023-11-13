namespace Oop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Sevval";
            musteri1.Soyadi = "Deniz";
            musteri1.TcNo = "12345";

                //Kodlama.ip

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";

            //gerçek Müşteri - Tüzel Müşteri
            //SOLİD

            Musteri musteri3 = new GercekMusteri();
            Musteri msuteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            MusteriManager.Ekle(musteri2); 


        }
    }
}