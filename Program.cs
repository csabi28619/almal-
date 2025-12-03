namespace házi
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class Program
    {
        class Megjelenito
        {
            public string Manufacturer;
            public string Model;
            public string Size;
            public string LCDType;
            public string Resolution;
            public string Range;
            public string Interface;
            public bool LFC;
            public bool Freesync;
            public bool HDR;

            public Megjelenito(string sor)
            {
                string[] adatok = sor.Split(";");
                Manufacturer = adatok[0];
                Model = adatok[1];
                Size = adatok[2];
                LCDType = adatok[3];
                Resolution = adatok[4];
                Range = adatok[5];
                Interface = adatok[6];
                LFC = adatok[7] == "true"? true : false ;
                Freesync = adatok[8] == "true" ? true : false;
                HDR = adatok[9] == "true" ? true : false;
            }
        }
        static void Main()
        {

            List<Megjelenito> monitorok = new List<Megjelenito>();

            // Fájl beolvasása
            string[] sorok = File.ReadAllLines("monitorok.csv");
            for (int i = 1; i < sorok.Length; i++) // Az első sor fejléc, kihagyjuk
            {
                monitorok.Add(new Megjelenito(sorok[i]));
            }

            // 1) Számolja meg hány olyan monitor van, amelyiknek DisplayPort az interfésze?
            int displayPortCount = monitorok.Count(m => m.Interface.Contains("DisplayPort"));
            Console.WriteLine($"1) DisplayPort interfészes monitorok száma: {displayPortCount}");

            // 2) Számolja meg hány olyan monitor van, amelyiknek legalább 2000 pixeles az oszlopszáma (felbontás)?
            int nagy2000 = monitorok.Count(m => int.Parse(m.Resolution.Split("x")[0]) >= 2000);
            Console.WriteLine($"\n2) Legalább 2000 pixeles oszlopszámú monitorok: {nagy2000}");

            // 3) Listázza képernyőre azokat a monitorokat, amelyek HDR képesek és legalább 27" képátlóval rendelkeznek!
            var hdrNagyMonitorok = monitorok.Where(m => m.HDR == true && int.Parse(m.Size.TrimEnd()) >= 27 );
            Console.WriteLine("\n3) HDR képes és legalább 27\" monitorok:");
            foreach (var monitor in hdrNagyMonitorok)
            {
                Console.WriteLine($"   {monitor.Manufacturer} {monitor.Model} - {monitor.Size}\"");
            }

            // 4) Márkák szerint azok névsorrendjében írassa képernyőre, hogy hány termék van a listában!
            var markaStat = monitorok.GroupBy(m => m.Manufacturer)
                                     .OrderBy(g => g.Key)
                                     .Select(g => new { Marka = g.Key, Darab = g.Count() });
            Console.WriteLine("\n4) Márkák szerinti statisztika:");
            foreach (var item in markaStat)
            {
                Console.WriteLine($"   {item.Marka}: {item.Darab} db");
            }

            // 5) IPS vagy TN paneles (LCD type) monitorból van több?
            int ipsCount = monitorok.Count(m => m.LCDType == "IPS");
            int tnCount = monitorok.Count(m => m.LCDType == "TN");
            Console.WriteLine($"\n5) IPS: {ipsCount} db, TN: {tnCount} db");
            Console.WriteLine($"   {(ipsCount > tnCount ? "IPS" : "TN")} panelből van több.");

            // 6) Listázza ki a HP és a Lenovo termékeinek kivételével gyártónként, hogy hány 27"-os monitor van a kínálatban.
            var huszonhet = monitorok.Where(m => m.Manufacturer != "HP" && m.Manufacturer != "Lenovo" && m.Size.Contains("27"))
                                     .GroupBy(m => m.Manufacturer)
                                     .Select(g => new { Gyarto = g.Key, Darab = g.Count() });
            Console.WriteLine("\n6) 27\"-os monitorok gyártónként (HP és Lenovo nélkül):");
            foreach (var item in huszonhet)
            {
                Console.WriteLine($"   {item.Gyarto}: {item.Darab} db");
            }

            // 7) Rendezze felbontás szerint csökkenően, azon belül model neve szerint növekvően az IPS paneles monitorokat!
            var rendezettIPS = monitorok.Where(m => m.LCDType == "IPS")
                                        .OrderByDescending(m => int.Parse(m.Resolution.Split("x")[0]))
                                        .ThenByDescending(m => int.Parse(m.Resolution.Split("x")[1]))
                                        .ThenBy(m => m.Model);
            Console.WriteLine("\n7) IPS paneles monitorok rendezve:");
            foreach (var monitor in rendezettIPS)
            {
                Console.WriteLine($"   {monitor.Resolution} - {monitor.Manufacturer} {monitor.Model}");
            }

            Console.ReadLine();

        }

    }
}
