using System.Reflection.Emit;
using System.Text;
namespace linqgyakorlás2025._11._20
{
    internal class Program
    {
        public class NobelDij
        {
            public string evszam;
            public string tipus;
            public string keresztnev;
            public string vezeteknev;
            public NobelDij(string sor)
            {
                this.evszam = sor.Split(";")[0];
                this.tipus = sor.Split(";")[1];
                this.keresztnev = sor.Split(";")[2];
                this.vezeteknev = sor.Split(";")[3];
            }
        }
        static void Main(string[] args)
        {
            List<NobelDij> dijazottak = new List<NobelDij>();
            StreamReader sr = new StreamReader("nobel.csv", Encoding.UTF32);
            
            while (!sr.EndOfStream)
            {
                dijazottak.Add(new NobelDij(sr.ReadLine()));
            }
            sr.Close();

            //3
            Console.WriteLine("3.fel: " + dijazottak.Where(x => x.keresztnev == "Arthur B." && x.vezeteknev == "McDonald"));
        }
    }
}
