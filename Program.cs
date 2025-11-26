using System.Linq;

namespace linq_gyakorlás
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> tintapatronok = new List<string>()
            {
                "Canon BCI-6eBK Black / S800, 820, 900","Canon BCI-6eC Color / S800, 820, 900","HP 6615DE (15) Black tintapatron","HP 6578D (78) Color tintapatron","HP 51645A (45) Black tintapatron","HP 6657AE (57) Color tintapatron","HP 6656AE (56) Black tintapatron","HP 8727A (27) Black tintapatron","HP 8728A (28) Color tintapatron","Canon BCI-3eM Color  / BJC3000,6000, i550","Canon BCI-6eM Color / S800, 820, 900","Canon BCI-6eY Color / S800, 820, 900","HP 4836AE (11) Cyan tintapatron","HP 4837AE (11) Magenta tintapatron","HP 4838AE (11) Yellow tintapatron","HP 4844AE (10) Black tintapatron","Epson T0483 Magenta","Epson T0484 Yellow","Epson T0485 Light Cyan","Epson T0486 Light Magenta","Epson T0481 Black","HP 8765A (338) Black tintapatron","HP 8766A (343) Color tintapatron","Epson T0441 Black","HP 9363EE (344) Color tintapatron","HP 8767A (339) Black tintapatron","HP 9351AE (21) Black tintapatron","HP 9352AE (22) Color tintapatron","Canon PG40 Black","Canon PG50 Black","Canon CL51 Color","Canon CL41 Color","Canon CL52 Photo Color","Canon PGI 5 Black","Canon CLI 8 Black","Canon CLI 8 Cyan","Canon CLI 8 Magenta","Canon CLI 8 Yellow","HP 9361EE (342) Color tintapatron","HP 9362EE (336) Black tintapatron","HP 8719EE (363XL) Black tintapatron","HP 8721EE (363) Black tintapatron","HP 8771EE (363) Cyan tintapatron","HP 8772EE (363) Magenta tintapatron","HP 8773EE (363) Yellow tintapatron","HP 8774EE (363) Light Cyan tintapatron","HP 8775EE (363) Light Magenta tintapatron","HP 9391AE (88XL) Cyan tintapatron","HP 9392AE (88XL) Magenta tintapatron","HP 9393AE (88XL) Yellow tintapatron","HP 9396A (88XL) Black tintapatron","HP CB335E (350) Black tintapatron","Canon CLI 8 Photo Magenta","Canon CLI 8 Photo Cyan","HP CB337EE (351) Color tintapatron","Epson T0711 Black","Epson T0712 Cyan","Epson T0713 Magenta","Epson T0714 Yellow","Epson T0611 Black","Epson T0612 Cyan","Epson T0613 Magenta","Epson T0614 Yellow","HP 9364EE (337) Black tintapatron","Epson T0801 Black","Epson T0802 Cyan","Epson T0804 Yellow","Epson T0805 Light Cyan","Epson T0715 Multipack","Canon PG37 Black","Epson T0711H Twin Pack Black","Canon PGI 520 Black","Canon CLI 521 Black","HP 9351C (21XL) Black tintapatron","HP CB336E (350XL) Black tintapatron","HP 9352CE (22XL) Color tintapatron","HP CB318EE (364) Cyan tintapatron","HP CB319EE (364) Magenta tintapatron","HP CB320EE (364) Yellow tintapatron","HP CB324EE (364XL) Magenta tintapatron","HP CC640EE (300) Black tintapatron","HP CC641EE (300XL) Black tintapatron","HP CC643EE (300) Color tintapatron","HP CC644EE (300XL) Color tintapatron","HP CC656AE (901) Color tintapatron","HP CC653AE (901) Black tintapatron","Canon CL 511 Color","Canon CLI 521 Cyan","Canon CLI 521 Magenta","Canon CLI 521 Yellow","Canon PG 510 Black","Epson T0806 Light Magenta","HP CB322EE (364XL) Photo Black tintapatron","HP CB323EE (364XL) Cyan tintapatron","HP CB325EE (364XL) Yellow tintapatron","Canon PGI 35 Black","HP 4913A (82) Yellow tintapatron","HP CC654AE (901XL) Black tintapatron","HP 9387AE (88) Magenta tintapatron","Canon CL38 Color","HP 9385AE (88) Black tintapatron","HP 9386AE (88) Cyan tintapatron","Canon CL 513","HP CB338EE (351XL) Color tintapatron","Canon PG 512 Black","HP 4906AE (940XL) Black tintapatron","HP 4907AE (940XL) Cyan tintapatron","HP 4908AE (940XL) Magenta tintapatron","HP 4909AE (940XL) Yellow tintapatron","Canon BX-20","HP CD971AE (920) Black tintapatron","HP CB317EE (364) Photo Black tintapatron","HP CD975AE (920XL) Black tintapatron","HP CD972AE (920XL) Cyan tintapatron","HP CD973AE (920XL) Magenta tintapatron","HP CD974AE (920XL) Yellow tintapatron","Canon CLI-521 MultiPack C,M,Y","Canon CLI-521GY Grey","HP CB331EE (338) Duopack Black tintapatron","HP 9505EE (344) Duopack Color tintapatron","HP 9503AE (57) Duopack Color tintapatron","HP 9502AE (56) Duopack Black tintapatron","HP 9504EE (339) Duopack Black tintapatron","HP CB332EE (343) Duopack Color tintapatron","Canon PFI-102MBk Matt Black","Canon PFI-102M Magenta","Canon PFI-102Y Yellow","Canon PFI-102Bk Black","Canon PFI-102C Cyan","HP 4911A (82) Cyan tintapatron","Canon PGI-9 Yellow","Canon PGI-9 Matt Black","Canon CLI-36  Color","Epson T0452 Cyan","Epson T0453 Magenta","Epson T0893 Magenta","Epson T0894 Yellow","Epson T6039 Light Light Black","Epson T0795 Light Cyan","Epson T0487 Multipack (6-szinü)","Epson T0551 Black","Epson T0556 Multipack (4-szinü)","Epson T0540 Gloss Optimizer","Epson T6034 Yellow","Epson T0969 Light Light Black","Epson T0968 Matte Black","Epson T0961 Photo Black","Epson T0615 Multipack (4-színű)","Epson T0792 Cyan","Epson T0554 Yellow","Epson T0592 Cyan Ultra Chrome K3","Epson T0597 Light Black Ultra Chrome K3","Epson T0549 Blue","Epson T0891 Black","Epson T0892 Cyan","HP CH565A (82) Black tintapatron","HP 4912A (82) Magenta tintapatron","HP 6578A (78) Color tintapatron","HP CH563EE (301XL) Black tintapatron","HP CH564EE (301XL) Color tintapatron","HP CH562EE (301) Color tintapatron","Canon CLI 526 Black","Canon CLI-526 MultiPack C,M,Y","Canon CLI 526 Cyan","Canon CLI 526 Yellow","Canon PGI-525 Black","Epson T1281 Black","Epson T1282 Cyan","Epson T1283 Magenta","Epson T1284 Yellow","Epson T0793 Magenta","Epson T0794 Yellow","Epson T0796 Light Magenta","Epson T0454 Yellow","Epson T0591 Photo Black  Ultra Chrome K3","Epson T0593 Magenta  Ultra Chrome K3","Epson T0594 Yellow  Ultra Chrome K3","Epson T0595 Light Cyan Ultra Chrome K3","Epson T0596 Light Magenta Ultra Chrome K3","Epson T0598 Matte Black Ultra Chrome K3","Epson T0599 Light Light  Black Ultra Chrome K3","Epson T0541 Photo Black","Epson T0542 Cyan","Epson T0543 Magenta","Epson T0544 Yellow","Epson T0547 Red","Epson T0548 Matte Black","Epson T0962  Cyan","Epson T0963 Magenta","Epson T0967 Light Black","Epson T0965 Light Cyan","Epson T0966 Light Magenta","Epson T0964  Yellow","Epson T6031 Photo Black","Epson T6032 Cyan","Epson T6037  Light Black","Epson T6035 Light Cyan","Brother LC1100 Multipack (Black, Cyan, Magenta, Yellow)","Epson T1285 Multipack","Epson T1295 Multi Pack - (Black, Magenta, Yellow, Cyan)","Epson T1291 Black","Epson T1292 Cyan","Epson T1293 Magenta","Epson T1294 Yellow","HP CN684EE (364XL) Black tintapatron","Epson T0807 Multipack (6-színű)","Canon CL 541XL Color","Canon PG 540XL Black","Canon PG 540 Black","Canon CL 541 Color","Epson T1006 Multipack (3-szinü)","Epson T1003 Magenta","Epson T1004 Yellow","Epson T1591 Black","Epson T1590 Gloss optimizer","Epson T1592 Cyan","Epson T1598 Matte Black","Epson T1599 Orange","Epson T1593 Magenta","Epson T1594 Yellow","Epson T1597 Red","Epson  T1579 Light Black","Epson T0895 Multipack (4-szinü)","Epson T1302 Cyan","Epson T1304 Yellow","Epson T7014 Yellow","Epson T7031 Black","Epson T7032 Cyan","Epson T7033 Magenta","Epson T7034 Yellow","Epson T7021 Black","Epson T7022 Cyan","Epson T7023 Magenta","Epson T7024 Yellow","Epson T7012 Cyan","Epson T7013 Magenta","Epson T6174 Yellow","Epson T6173 Magenta","Epson T6171 Black","Brother LC1100BK Black","Brother LC1100HY Yellow","Brother LC985Y Yellow","Brother LC985M Magenta","Brother LC985C Cyan","Brother LC985BK Black","Brother LC980M Magenta","Brother LC970Y Yellow","Brother LC970BK Black","Brother LC1280XLY Yellow","Brother LC1280XLM Magenta","Brother LC1280XLC Cyan","Brother LC1280XLBK Black","Brother LC1220Y Yellow","Brother LC1220M Magenta","Brother LC1220C Cyan","Brother LC1220BK Black","Brother LC1100M Magenta","Brother LC1100HYBK Black","Epson T1303 Magenta","Epson T1306 Multi Pack","Epson T1571 Black","Epson T1572 Cyan","Epson T1573 Magenta","Epson T1574 Yellow","Epson T1575 Light Cyan","Epson T1577 Light Black","Epson T1578 Matte Black","Epson T008 Color (5-szinü)","Epson T0445 Multipack (4-szinü)","Epson T0342 Cyan","Epson T0343 Magenta","Epson T0442 Cyan","Epson T0443 Magenta","Epson T0444 Yellow","Epson T051 Black","Epson T0871 Black","Epson T0874 Yellow","Epson T0877 Red","Epson T0878 Matte Black","Epson T0879 Orange","Epson T1001 Black","Epson T6161 Black","Epson T6162 Cyan","Epson T6163 Magenta","Epson T6164 Yellow","Epson T7011 XXL Black","Epson T6172 Cyan","Epson T619 Maintenance Kit","Epson T6181 Black","Epson T1002 Cyan","Epson L800 Light Magenta","Epson L800 Light Cyan","Epson L800 Yellow","Epson L800 Magenta","Epson L800 Cyan","Epson L800 Black (T6731)","Epson T6641 L100/L200 Black","Epson T6642 L100/L200 Cyan","Epson T6643 L100/L200 Magenta","Epson T6644 L100/L200 Yellow","Brother LC1100Y Yellow","Brother LC980Y Yellow","Brother LC980BK Black","Brother LC980 Multipack (Black, Cyan, Magenta, Yellow)","Brother LC-900BK Black","HP CN048AE (951XL) Yellow tintapatron","HP CN049AE (950) Black tintapatron","Brother LC980C Cyan","Epson T1301 Black","Brother LC985 Kit (Black, Cyan, Magenta, Yellow)","Brother LC1280XL Kit (Black, Cyan, Magenta, Yellow)","Brother LC970C Cyan","Brother LC970M Magenta","Brother LC1240BK Black","Brother LC1240C Cyan","Brother LC1240M Magenta","Brother LC1240Y Yellow","Brother LC1000BK Black","Brother LC1000C Cyan","Brother LC1000M Magenta","Brother LC1000Y Yellow","Brother LC1100HYC Cyan","Brother LC1100HYM Magenta","Brother LC1100HY nagykapacitású kit (Cyan, Magenta, Yellow, Black)","HP CN054AE (933XL) Cyan tintapatron","HP CN055AE (933XL) Magenta tintapatron","HP CN056AE (933XL) Yellow tintapatron","Epson T0872 Cyan","Epson T0873 Magenta","HP CN057AE (932) Black tintapatron","Canon PGI-525 Black Duo","Epson T1576 Light Magenta","Epson T1801 Black","Epson T1802 Cyan","Epson T1803 Magenta","Epson T1804 Yellow","Epson T1811XL Black","Epson T1812XL Cyan","Epson T1813XL Magenta","Epson T1814XL Yellow","Epson 18XL Multipack (4-színű)","Canon PGI-9 Magenta","Canon PGI-9 Photo Black","Canon PGI-9 Photo Magenta","Canon CLI 551 XL Cyan","Canon CLI 551 XL Yellow","Canon PGI-550 Black","Canon CLI 551 XL Grey","Canon CLI 551 XL Black","HP CZ109AE (655) Black tintapatron","HP CZ110AE (655) Cyan tintapatron","HP CZ112AE (655) Yellow tintapatron","HP CZ111AE (655) Magenta tintapatron","Canon CLI 551 XL Magenta","Canon CLI 8 MultiPack C,M,Y","Canon PGI-550XL Black","Brother LC-123BK Black","Brother LC-123Y Yellow","Brother LC-123M Magenta","Brother LC-123C Cyan","Canon PGI-9 Photo Cyan","HP C2N92AE (920XL) Color 4-Multipack tintapatron","HP C2N93AE (940XL) Color 4-Multipack tintapatron","HP CZ102AE (650) Color  tintapatron","Epson 18 Multipack (4-színű)","Brother LC-127XLBK Black","Epson T0870 Gloss Optimizer","Epson T007 Singlepack Black","HP CZ131A (711) Magenta tintaparton","HP CZ130A (711) Cyan tintapatron","HP CZ129A (711) Black tintapatron ","Canon PGI-9 Cyan","Epson T6122 Cyan","Epson T6123 Magenta","Epson T6124 Yellow","Epson T6128 Matte Black","Brother LC-125XLC Cyan","Brother LC-125XLM Magenta","Brother LC-125XLY Yellow","Brother LC-900C Cyan","Brother LC-900M Magenta","Brother LC-900Y Yellow","HP CZ132A (711) Yellow  tintaparton","HP CZ133A (711) Black tintapatron","Brother LC1100C Cyan","Brother LC123VALBP CMYK Pack","Brother LC-127XLVALBP CMYK XL Pack","Epson 16 Black","Epson 16 Cyan","Epson 16 Magenta","Epson 16 Yellow","Epson T7741A Black","Canon CL 546 Color","Canon PG 545 Black","HP SD412EE (350) Black + (351) Color Combo-pack","Brother LC-129XLBK Black","HP CN626AE (971XL) Cyan tintapatron","HP CN627AE (971XL) Magenta tintapatron","HP CN628AE (971XL) Yellow tintapatron","Canon CL 546 Color XL","Epson T7441 Black","Canon PG 545 XL Black","HP CN625AE (970XL) Black tintapatron","Brother LC-525XL-C Cyan","Brother LC-525XL-M Magenta","Brother LC-525XL-Y Yellow","Brother LC-529XL-BK Black","Epson 16XL Black","Epson T7893 XXL Magenta","Epson T7892 XXL Cyan","Epson T7891 XXL Black","Epson T7894 XXL Yellow","Canon PG-545 / CL-546 Combipack","Samsung INK-M210 Black","Canon PGI 520 Twin Black","Epson SJIC22P Black","Epson SJIC22P Cyan","Epson SJIC22P Magenta","Epson SJIC22P Yellow","Canon PGI 5 Duo Black","Epson T1694 Photo Black","Epson T6942 Cyan","Brother LC227XLBK Black","HP C2P21AE (935) Magenta tintapatron","HP C2P25AE (935XL) Magenta tintapatron","HP C2P26AE (935XL) Yellow tintapatron","HP J3M83AE (364XL) Black + Color tintapatron + 10db fotópapír","Canon PGI-2500XL Magenta","Canon PGI-2500XL Cyan","Canon PGI-2500XL Black","Canon PGI-2500XL Multipack","Canon PGI-2500XL Yellow","Brother LC-121C Cyan","Brother LC-121M Magenta","Brother LC-121Y Yellow","Brother LC-121BK Black","Epson 16 Multipack","Brother LC-125XL Color Set (C/M/Y)","Canon PG-40 / CL-41 Multipack","Brother LC225XLC Cyan  XL","Brother LC225XLM Magenta XL","Brother LC225XLY Yellow XL","Canon PG-540/CL-541 Multipack","Brother LC-229XLBK Black","Brother LC-223BK Black","Brother LC-223C Cyan","Brother LC-223M Magenta","Brother LC-223Y Yellow","Canon CLI 571 Black","Canon CLI 571 Cyan","Canon CLI 571 Magenta","Canon CLI 571 Yellow","Canon CLI 571XL Black","Canon CLI 571XL Cyan","Canon CLI 571XL Magenta","Canon PGI 570 Black","Canon PGI 570XL Black","Epson T7554 XL Yellow"
            };

            List<int> szamsorA = new List<int> { 2, 4, 8, 16, 32, 64, 128, 256 };
            List<int> szamsorB = new List<int> { 3, 9, 27, 81, 243, 729 };

            List<char> jelek = new List<char> { '+', '-', '0', '0', '+', '-', '0', '0', '+', '+', '-', '0', '0', '+', '+', '+', '-', '-', '+', '-', '+', '+', '-', '0', '0', '+', '+', '-', '0', '-', '+' };

            //Innen kezdje a megoldásokat!

            //samsorA,B
            //1
            Console.WriteLine("1");
            if (szamsorA.Count(x => !(x % 2 == 0)) > szamsorB.Count(x => !(x % 2 == 0))) Console.WriteLine("szamsorA");
            else Console.WriteLine("szamsorB");
            Console.WriteLine();

            //2
            Console.WriteLine("2");
            Console.WriteLine(szamsorA.Average());
            Console.WriteLine();

            //3
            Console.WriteLine("3");
            Console.WriteLine(szamsorB.First(x => x > 9 && x < 100));
            Console.WriteLine();

            //4
            Console.WriteLine("4");
            List<int> ujSzamsor = szamsorA.Union(szamsorB).OrderBy(x => x).ToList();
            foreach (int i in ujSzamsor) Console.Write(i + " ");
            Console.WriteLine();
            Console.WriteLine();

            //tintapatronok
            //5
            Console.WriteLine("5");
            Console.WriteLine(tintapatronok.Count(x => x.Contains("Canon")));
            Console.WriteLine();

            //6
            Console.WriteLine("6");
            List<string> epszonMagenták = tintapatronok.Where(x => x.Contains("Epson") && x.Contains("Magenta")).ToList();
            for (int index = 0; index < 3; index++) Console.WriteLine(epszonMagenták[index]);
            Console.WriteLine();

            //7
            Console.WriteLine("7");
            Console.WriteLine(tintapatronok.Count);
            tintapatronok = tintapatronok.Where(x => !x.Contains("L800")).ToList();
            Console.WriteLine(tintapatronok.Count);
            Console.WriteLine();

            //8
            Console.WriteLine("8");
            var jelCsoport = jelek.GroupBy(jel => jel).Select(g => new { Jel = g.Key, Darab = g.Count() }).OrderByDescending(x => x.Darab).ToList();

            foreach (var item in jelCsoport)
            {
                Console.WriteLine($"   '{item.Jel}' jelek száma: {item.Darab}");
            }

            var legtobbJel = jelCsoport.First();
            Console.WriteLine($"   A '{legtobbJel.Jel}' jelből van a legtöbb ({legtobbJel.Darab} db)");
            Console.WriteLine();

            //9
            Console.WriteLine("9");
            int maxHossz = 1;
            int aktualisHossz = 1;

            for (int i = 1; i < jelek.Count; i++)
            {
                if (jelek[i] == jelek[i - 1])
                {
                    aktualisHossz++;
                    maxHossz = Math.Max(maxHossz, aktualisHossz);
                }
                else
                {
                    aktualisHossz = 1;
                }
            }
            Console.WriteLine($"   Leghosszabb sorozat: {maxHossz}");
            Console.WriteLine();

            //10
            Console.WriteLine("10");
            int pozicio = jelek.Select((jel, index) => new { jel, index }).Where(x => x.index < jelek.Count - 1 && x.jel == '+' && jelek[x.index + 1] == '+').Select(x => x.index).DefaultIfEmpty(-1).First();

            if (pozicio != -1)
                Console.WriteLine($"   A {pozicio}. indexen (0-tól indexelve), azaz a {pozicio + 1}. helyen");
            else
                Console.WriteLine("   Nincs ilyen elem");
        }
    }
}
