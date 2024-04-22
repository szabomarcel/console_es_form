using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace console_dolgozo_vizsgaszeru
{
    internal class Program
    {
        List<Dolgozok> dolgozok = new List<Dolgozok>();
        static async Task Main(string[] args)
        {
            List<Dolgozok> dolgozok = new List<Dolgozok> {};
            await Dolgozokat();
            await Reszleg(dolgozok);
            await KiirDolgoszokRezlegei(dolgozok);
            Console.WriteLine("Program vége");
            Console.ReadKey();
        }

        private static async Task KiirDolgoszokRezlegei(List<Dolgozok> dolgozok)
        {
            var asztalosmuhelyDolgozoi = dolgozok.Where(d => d.Reszleg == "Asztalosműhely").Select(d => d.Nev);
            Console.WriteLine("Asztalosműhely dolgozói:");
            foreach (var nev in asztalosmuhelyDolgozoi)
            {
                Console.WriteLine(nev);
            }
        }

        private static async Task Reszleg(List<Dolgozok> dolgozok)
        {
            var reszlegek = dolgozok.GroupBy(d => d.Reszleg).Select(g => new { Reszleg = g.Key, DolgozokSzama = g.Count() });
            Console.WriteLine("Részlegek és dolgozók száma:");
            foreach (var reszleg in reszlegek)
            {
                Console.WriteLine($"{reszleg.Reszleg}: {reszleg.DolgozokSzama}");
            }
        }

        private static async Task Dolgozokat()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost/_dolgozok_vizsgaszeru_/backenddolgozok/index.php?dolgozok");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            string responseContent = await response.Content.ReadAsStringAsync();
            var dolgozok = JsonConvert.DeserializeObject<Dolgozok[]>(responseContent);
            Dolgozok maxKeresetu = dolgozok[0];
            foreach (var nev in dolgozok)
            {
                if (nev.Ber > maxKeresetu.Ber)
                {
                    maxKeresetu = nev;
                }
            }
            Console.WriteLine($"A legbagyobb nev: {maxKeresetu.Nev} ({maxKeresetu.Ber})");
            Console.WriteLine(await response.Content.ReadAsStringAsync());
        }
    }
}
