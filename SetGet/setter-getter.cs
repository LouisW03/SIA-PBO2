using System;
using System.Collections.Generic;   
using System.Linq;  
using System.Text;  
using System.Threading.Tasks;   

namespace setget
{
    class mhs
    {
        static void Main(string[] args)
        {
            mahasiswa louis = new mahasiswa("Louis Wang", "Kampus Ketintang");
            mahasiswa wang = new mahasiswa("Wang Louis", "Kampus Wiyung");
            Console.WriteLine("Mahasiswa Louis Wang");
            Console.WriteLine(louis.Kampus);
            Console.WriteLine("\nMahasiswa Wang Louis");
            Console.WriteLine(wang.Kampus);
            Console.ReadLine();
        }
    }

    class mahasiswa
    {
        private string nama;
        private string kampus;

        public mahasiswa(string namamhs, string kampusmhs)
        {
            nama = namamhs;
            Kampus = kampusmhs;
        }

        public string Kampus
        {
            get { return kampus; }
            set 
            {
                if (value == "Kampus Ketintang" || value == "Kampus Lidah Wetan" || value == "Bukan Mahasiswa UNESA")
                {
                    kampus = value;
                }
                else { kampus = "Bukan Mahasiswa UNESA"; }
            }
        }
    }

   

}