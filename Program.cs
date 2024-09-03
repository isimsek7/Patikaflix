using Patikaflix;
List<Dizi> Diziler = new List<Dizi>();
bool count = true;
Console.WriteLine("Bir dizi ekleyiniz");
while(count)
{
    Console.Write("Dizi Adi= ");
    string ad = Console.ReadLine();
    Console.Write("Yapim Yili= ");
    string yapimYili = Console.ReadLine();
    Console.Write("Turu= ");
    string tur = Console.ReadLine();
    Console.Write("Yayin Tarihi= ");
    string yayinTarihi = Console.ReadLine();
    Console.Write("Yonetmen= ");
    string yonetmen = Console.ReadLine();
    Console.Write("Yayinlandigi Ilk Platform= ");
    string plat = Console.ReadLine();
    Dizi yeniDizi = new Dizi(ad, yapimYili, tur, yayinTarihi, yonetmen, plat);
    Diziler.Add(yeniDizi);
    bool count2 = true;
    while (count2)
    {
        try
        {
            Console.WriteLine("Baska bir dizi eklemek ister misiniz ? E/H =");
            string immo = Console.ReadLine().ToLower();
            if (immo == "h")
            {
                count2 = false;
                count = false;
                Console.WriteLine("Girdiginiz diziler kaydedildi.");
            }

            else if (immo == "e")
            {
                count2 = false;
            }
            else
            {
                Console.WriteLine("Invalid Character please try Again");

            }
        }
        catch(FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
var DiziFinal = Diziler.Where(dizi => dizi._tur.Contains("Komedi", StringComparison.OrdinalIgnoreCase))
    .Select(p => new KomediDiziler { komediDiziAdi = p._diziAdi, komediTur = p._tur, komediYonetmen = p._yonetmen })
    .OrderBy(p => p.komediDiziAdi)
    .ThenBy(p => p.komediYonetmen);
foreach (var e in DiziFinal) Console.WriteLine("{0}, {1}, {2}",e.komediDiziAdi,e.komediYonetmen,e.komediTur);