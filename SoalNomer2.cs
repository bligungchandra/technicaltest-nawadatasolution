using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testnawadata
{
    public class SoalNomer2
    {
        public void jawabanNomer2()
        {
            Console.WriteLine("-------Berikut Ini Merupakan Logika Saya Untuk Soal Nomor 2----------");
            Console.WriteLine("Masukkan Kata Yang Anda Inginkan:");
            string inpt = Console.ReadLine();

           
            List<char> listHurufVokal = new List<char>();
            List<char> listHurufCons = new List<char>();
            //StringBuilder sb = new StringBuilder();

            var inputToChar = (inpt.ToString().ToLower()).ToCharArray();
            for (var i = 0; i < inputToChar.Length; i++)
            {
                var lowerCase = inpt[i];
                char[] vokal = { 'a','i','u','e','o'};

                if (vokal.Contains(lowerCase))
                {
                   
                    listHurufVokal.Add(lowerCase);
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(lowerCase.ToString()))
                    {
                        
                        listHurufCons.Add(lowerCase);
                    }
                }
            }
            listHurufVokal.Sort();
            listHurufCons.Sort();
            Console.WriteLine("Huruf Vokal :");
            StringBuilder hurufVokal = new StringBuilder(string.Join("", listHurufVokal.ToArray()));
            Console.Write(hurufVokal.ToString().ToLower());
            Console.WriteLine(" ");
            Console.WriteLine("Huruf Konsonan :");
            StringBuilder hurufKonsonan = new StringBuilder(string.Join("", listHurufCons.ToArray()));
            Console.Write(hurufKonsonan.ToString().ToLower());

            Console.ReadLine();

        }
    }
}
