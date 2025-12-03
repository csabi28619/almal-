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
                LFC = adatok[7] == "yes"? true : false ;
                Freesync = adatok[8] == "yes" ? true : false;
                HDR = adatok[9] == "yes" ? true : false;
            }
        }
        static void Main()
        {
            //    List<int> napiCsapadek = new List<int>
            //{
            //    0,0,1,0,0,2,0,0,3,1,0,0,0,0,4,0,0,1,0,0,0,0,2,0,0,1,0,0,0,0,
            //    //1,0,0,2,0,3,0,0,0,1,0,0,0,5,0,0,0,0,0,0,0,0,1,2,0,0,0,0,4,0,
            //    0,0,0,0,0,3,0,0,1,0,0,0,0,0,0,2,0,0,3,0,0,5,0,0,0,0,0,0,0,0,
            //    0,0,0,1,4,0,0,0,0,0,0,7,0,0,0,0,0,0,1,0,0,0,3,0,0,0,0,0,0,0,
            //    0,0,0,1,0,0,0,2,0,0,0,0,0,0,0,5,0,0,0,1,0,0,0,0,0,0,2,0,0,0,
            //    0,0,0,0,0,6,0,0,0,0,3,0,0,0,0,0,10,0,0,0,0,0,12,0,0,0,0,0,8,0,
            //    0,0,0,0,5,0,0,0,3,0,0,0,0,0,0,14,0,0,0,0,0,0,0,0,18,0,0,0,0,0,
            //    0,2,0,0,0,0,0,0,22,0,0,0,0,3,0,0,0,0,0,0,12,0,0,0,0,0,0,0,7,0,
            //    0,0,0,0,0,0,25,0,0,0,0,4,0,0,0,0,0,16,0,0,0,0,0,9,0,0,0,0,0,0,
            //    3,0,0,0,0,5,0,0,0,0,0,0,15,0,0,0,0,0,8,0,0,0,0,2,0,0,0,0,0,0,
            //    0,0,0,4,0,0,0,0,1,0,0,0,0,0,6,0,0,0,0,0,0,0,10,0,0,0,0,0,0,2,
            //    0,0,0,0,0,0,0,0,0,0,0,8,0,0,0,0,3,0,0,0,0,0,1,0,0,0,0,0,0,0,
            //    0,0,0,0,0,2,0,0,0,0,0,0,4,0,0,0,1,0,0,0,0,0,0,5,0,0,0,0,0,0,
            //    0,0,0,0,0,0,0,2,0,0,0,1,0,0,0,0,0
            //};

            //    List<string> versenyzok = new List<string>
            //{
            //    "Nagy-Péter","Kovács-Anna","Tóth-Gábor","Szabó-Dóra","Varga-Balázs","Kiss-Eszter","Molnár-Tamás","Németh-Kata","Horváth-László","Balogh-Zsófia",
            //    "Papp-Máté","Farkas-Júlia","Lakatos-Dávid","Juhász-Lili","Takács-Roland","Mészáros-Vivien","Oláh-Kristóf","Simon-Laura","Rácz-Dániel","Fekete-Noémi",
            //    "Vass-Márton","Bodnár-Kinga","Fehér-Patrik","Török-Blanka","Gulyás-Bence","Balázs-Viktória","Antal-Kristina","Fodor-Gergely","Szalai-Emese","Kelemen-Robert",
            //    "Major-Liliána","Bognár-Attila","Pintér-Erika","Hegedűs-Kristóf","Sipos-Alexandra","Kocsis-Levente","Orosz-Eszter","Lengyel-Kristóf","Szűcs-Ágnes","Pál-Gábor",
            //    "Vincze-Lilla","Vörös-Dávid","Király-Laura","Tóth-Miklós","Jakab-Zita","Lukács-Márk","Kovács-Viktor","Varga-Rebeka","Kiss-Zoltán","Szabó-Nóra",
            //    "Horváth-Kristóf","Molnár-Dorina","Balogh-Levente","Papp-Emma","Nagy-Gergely","Németh-Vivien","Takács-Márk","Farkas-Luca","Juhász-Tamás","Vass-Klaudia",
            //    "Fehér-Gábor","Török-Anna","Gulyás-Dóra","Balázs-Máté","Antal-Kitti","Fodor-Balázs","Szalai-Noémi","Kelemen-Máté","Major-Petra","Bognár-Dániel",
            //    "Pintér-Laura","Hegedűs-Ádám","Sipos-Vivien","Kocsis-Norbert","Orosz-Kata","Lengyel-Bence","Szűcs-Lili","Pál-Márk","Vincze-Ádám","Vörös-Rebeka",
            //    "Király-Gergő","Tóth-Klaudia","Jakab-Márton","Lukács-Dóra","Kovács-Gábor","Varga-Lilla","Kiss-Dániel","Szabó-Petra","Horváth-Balázs","Molnár-Noémi",
            //    "Balogh-Zoltán","Papp-Jázmin","Nagy-László","Németh-Klaudia","Takács-Gergely","Farkas-Nóra","Juhász-Márk","Vass-Dorina","Fehér-Levente","Török-Gábor",
            //    "Gulyás-Laura","Balázs-Kristóf","Antal-Eszter","Fodor-Patrik","Szalai-Emma","Kelemen-Dániel","Major-Zsófia","Bognár-Kristóf","Pintér-Dóra","Hegedűs-Lili",
            //    "Sipos-Márton","Kocsis-Ágnes","Orosz-Vivien","Lengyel-Dorina","Szűcs-Gergő","Pál-Kinga","Vincze-Tamás","Vörös-Laura","Király-Zsombor","Tóth-Dorina",
            //    "Jakab-Gergely","Lukács-Kata","Kovács-Bence","Varga-Jázmin","Kiss-Márton","Szabó-Lilla","Horváth-Dávid","Molnár-Rebeka","Balogh-Kristina","Papp-Kristóf",
            //    "Nagy-Liliána","Németh-Márk","Takács-Dóra","Farkas-Zoltán","Juhász-Vivien","Vass-Miklós","Fehér-Dóra","Török-Máté","Gulyás-Zsófia","Balázs-Levente",
            //    "Antal-Luca","Fodor-Dániel","Szalai-Balázs","Kelemen-Klaudia","Major-Gábor","Bognár-Lili","Pintér-Gergő","Hegedűs-Laura","Sipos-Zoltán","Kocsis-Vivien",
            //    "Orosz-Dániel","Lengyel-Eszter","Szűcs-Tamás","Pál-Emma","Vincze-Márton","Vörös-Nóra","Király-Ádám","Tóth-Kinga","Jakab-Balázs","Lukács-Eszter"
            //};

            //    List<double> maxHofok = new List<double>
            //{
            //    29.1, 28.4, 27.8, 27.2, 26.5, 25.9, 26.0, 25.3, 24.8, 25.1,
            //    24.4, 23.7, 23.2, 22.8, 21.9, 22.3, 21.5, 20.8, 20.2, 19.7,
            //    20.1, 19.4, 18.8, 18.1, 17.6, 17.3, 16.9, 16.1, 15.8, 15.2
            //};

            //    List<String> diakok = new List<String>() {
            //    "Balogh Zsombor",
            //    "Sopronyi Zoltán",
            //    "Hőgye Dominik",
            //    "Kelemen Marcell",
            //    "Máté Patrik",
            //    "Körtvélyessi Benedek",
            //    "Szabó Zoltán",
            //    "Turóczi Dávid",
            //    "Nagy Balázs",
            //    "Csahóczi Máté Benedek",
            //    "Tasnádi Attila",
            //    "Tarsoly Levente Ákos",
            //    "Vas Bence",
            //    "Tóth Martin",
            //    "Macz Enikő",
            //    "Kiss Gergő",
            //    "Balogh Endre",
            //    "Mozsár Máté",
            //    "Félegyházi Gergő",
            //    "Pápai Sándor",
            //    "Orosz Levente",
            //    "Kovács Ákos",
            //    "Bodnár Petra",
            //    "Mercs Alex",
            //    "Sztrik Márton",
            //    "Gellén Csaba Kálmán",
            //    "Barta Ernő Péter",
            //    "Bányai Gábor",
            //    "Kis Ábel",
            //    "Kiss Gergely",
            //    "Hajdú Bettina",
            //    "Bereczki István",
            //    "Moldován Adrián"
            //};

            //    // 1) Hány olyan nap volt, amikor 20 fok feletti hőmérsékletet mértek?
            //    int nap20Felett = maxHofok.Count(h => h > 20);
            //    Console.WriteLine($"1) 20 fok feletti napok száma: {nap20Felett}");

            //    // 2) Hozzon létre egy új, hőfok szerint csökkenően rendezett listát!
            //    List<double> rendezettHofok = maxHofok.OrderByDescending(h => h).ToList();
            //    Console.WriteLine($"2) Csökkenően rendezett hőfok lista létrehozva ({rendezettHofok.Count} elemmel)");

            //    // 3) Hány olyan diák van, akiknek két keresztneve van?
            //    int ketKeresztnev = diakok.Count(d => d.Split(' ').Length == 3);
            //    Console.WriteLine($"3) Két keresztnevű diákok száma: {ketKeresztnev}");

            //    // 4) Írassa ki azoknak a diákoknak a neveit, akik nevének hossza meghaladja a 15 karaktert
            //    Console.WriteLine("4) 15 karakternél hosszabb nevek (hossz szerint növekvő):");
            //    var hosszuNevek = diakok.Where(d => d.Length > 15).OrderBy(d => d.Length);
            //    foreach (var nev in hosszuNevek)
            //    {
            //        Console.WriteLine($"   {nev} ({nev.Length} karakter)");
            //    }

            //    // 5) Hány olyan nap volt, amikor több mint 10mm eső esett?
            //    int tobb10mm = napiCsapadek.Count(cs => cs > 10);
            //    Console.WriteLine($"5) 10mm-nél több esős napok száma: {tobb10mm}");

            //    // 6) Rendezze csapadékérték szerint csökkenően a listát!
            //    var rendezettCsapadek = napiCsapadek.OrderByDescending(cs => cs).ToList();
            //    Console.WriteLine($"6) Csökkenően rendezett csapadék lista létrehozva ({rendezettCsapadek.Count} elem)");

            //    // 7) Készítsen egy új listát aligesett néven, amely a 3mm alatti csapadékértékeket tartalmazza
            //    List<int> aligesett = napiCsapadek.Where(cs => cs < 3).ToList();
            //    Console.WriteLine($"7) 3mm alatti csapadékértékek száma: {aligesett.Count}");

            //    // 8) Rendezze a versenyzőket nevük karakterszáma szerint növekvő sorrendben
            //    var rendezettVersenyzok = versenyzok.OrderBy(v => v.Length).ThenBy(v => v).ToList();
            //    Console.WriteLine($"8) Versenyzők rendezve (első): {rendezettVersenyzok[1]}");

            //    // 9) Hány olyan nap volt, amikor nem esett eső?
            //    int nincsEso = napiCsapadek.Count(cs => cs == 0);
            //    Console.WriteLine($"9) Esőmentes napok száma: {nincsEso}");

            //    // 10) Készítsen egy új listát sokeso néven, amely az 5mm feletti csapadékértékeket tartalmazza
            //    List<int> sokeso = napiCsapadek.Where(cs => cs > 5).ToList();
            //    Console.WriteLine($"10) 5mm feletti csapadékértékek száma: {sokeso.Count}");

            //    // 11) Listázza ki azoknak a versenyzőknek a nevét, akik keresztneve Dávid
            //    Console.WriteLine("11) Versenyzők, akiknek keresztneve Dávid:");
            //    var davidok = versenyzok.Where(v => v.Split('-')[1] == "Dávid");
            //    foreach (var nev in davidok)
            //    {
            //        Console.WriteLine($"   {nev}");
            //    }

            //    // 12) Mekkora volt a legnagyobb hőmérsékletkülönbség a mérések között?
            //    double maxKulonbseg = 0;
            //    for (int index = 0; index < maxHofok.Count - 1; index++)
            //    {
            //        double kulonbseg = Math.Abs(maxHofok[index] - maxHofok[index + 1]);
            //        if (kulonbseg > maxKulonbseg)
            //            maxKulonbseg = kulonbseg;
            //    }
            //    Console.WriteLine($"12) Legnagyobb hőmérsékletkülönbség egymást követő napok között: {maxKulonbseg:F1} fok");

            //    // 13) Mi volt az év során a második legmagasabb csapadékérték?
            //    int masodikLegnagyobb = napiCsapadek.OrderByDescending(cs => cs).Skip(1).First();
            //    Console.WriteLine($"13) Második legmagasabb csapadékérték: {masodikLegnagyobb} mm");

            //    // 14) Mennyi volt az év során az átlagos csapadékmennyiség?
            //    double atlag = napiCsapadek.Average();
            //    Console.WriteLine($"14) Átlagos csapadékmennyiség: {atlag:F2} mm");

            //    // 15) Van-e a versenyzők között „Szuper Béla" nevű induló?
            //    bool vanSzuperBela = versenyzok.Any(v => v == "Szuper-Béla");
            //    Console.WriteLine($"15) Van-e Szuper Béla a versenyzők között? {(vanSzuperBela ? "Igen" : "Nem")}");

            //    // 16) Az év melyik napján (sorszám) esett utoljára 30mm feletti csapadék?
            //    int utolso30Felett = napiCsapadek.LastOrDefault(cs => cs > 30);
            //    Console.WriteLine($"16) Utoljára {(utolso30Felett != 0 ? "a(z) " + utolso30Felett + ". napon" : "egyik napon sem")} esett 30mm feletti csapadék");

            //    // 17) Hány különböző vezetéknevű diák van a listában?
            //    int kulonbozoVezeteknevek = diakok.Select(d => d.Split(' ')[0]).Distinct().Count();
            //    Console.WriteLine($"17) Különböző vezetéknevek száma: {kulonbozoVezeteknevek}");

            //    // 18) Hogyan hívják a legelső olyan versenyzőt, akinek a nevében szerepel a „Vajk" szó?
            //    var vajkNev = versenyzok.FirstOrDefault(v => v.Contains("Vajk"));
            //    Console.WriteLine($"18) Első versenyző 'Vajk' névvel: {(vajkNev ?? "Nincs ilyen")}");

            //    // 19) Készítsen egy nevek listát, amelyben a diákoknak csak az első keresztnevük szerepel!
            //    List<string> nevek = diakok.Select(d => {
            //        var reszek = d.Split(' ');
            //        return reszek.Length >= 2 ? $"{reszek[0]} {reszek[1]}" : d;
            //    }).ToList();
            //    Console.WriteLine($"19) Első keresztnevek lista létrehozva ({nevek.Count} elem, első: {nevek[0]})");

            //    // 20) Készítsen egy angolul nevű listát fordított névrend szerint a Béla nevű versenyzőkről.
            //    List<string> angolul = versenyzok.Where(d => d.Contains("Béla")).Select(n => n.Split('-')[1] + " " + n.Split('-')[0]).ToList();

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
