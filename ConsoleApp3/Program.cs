﻿using System;
{
    public string ad {  get; set; }
    public string soyad { get; set; }
    public string şikayet { get; set; }
    public string telefon {  get; set; }
    public string adres {  get; set; }


}
{
    private List<hasta> hastalistesi = new List<hasta>();
    public void hastakayıt()
    {
        Console.WriteLine("Hasta Bilgilerini Giriniz");

        Console.Write("Adres: ");
        {
        {
        }
{

    {
        hastakayıtsistemi hastaKayitSistemi = new hastakayıtsistemi();
        while (true)
        {
            Console.WriteLine("1. Hasta Kayıtı Oluşur");
            Console.WriteLine("2. Tüm Hastaalrı Listele");
            Console.WriteLine("3. Çıkış");
            Console.Write("Seçiminizi yapın (1-3): ");
            string secim =Console.ReadLine();
            switch (secim)
            {
                case "1":
                    hastaKayitSistemi.hastakayıt();
                    break;
                case "2":
                    hastaKayitSistemi.Tumhastalistele();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Geçersiz seçim. Tekrar deneyin.");
                    break;
            }

        }
    }
}