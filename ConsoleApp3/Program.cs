using System;class hasta
{
    public string ad {  get; set; }
    public string soyad { get; set; }
    public string şikayet { get; set; }
    public string telefon {  get; set; }
    public string adres {  get; set; }


}class hastakayıtsistemi
{
    private List<hasta> hastalistesi = new List<hasta>();
    public void hastakayıt()
    {
        Console.WriteLine("Hasta Bilgilerini Giriniz");        Console.Write("Ad: ");        string ad=Console.ReadLine();        Console.Write("SoyAd: ");        string soyad = Console.ReadLine();        Console.Write("Şikayet: ");        string şikayet = Console.ReadLine();        Console.Write("Telefon: ");        string telefon = Console.ReadLine();

        Console.Write("Adres: ");        string adres = Console.ReadLine();        hasta yenihasta = new hasta()
        {            ad = ad,            soyad = soyad,            şikayet = şikayet,            telefon = telefon,            adres = adres,        };        hastalistesi.Add(yenihasta);        Console.WriteLine("Hasta Kaydı Başarıyla Oluşturulumuştur");    }    public void Tumhastalistele()     {        Console.WriteLine("Tüm Hastalar");        foreach(var hasta in hastalistesi)
        {            Console.WriteLine($"Ad: {hasta.ad},SoyAd: {hasta.soyad},Şikayet: {hasta.şikayet},Telefon: {hasta.telefon},Adres: {hasta.adres}");
        }    }}class program
{    static void Main()

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