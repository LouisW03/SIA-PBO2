using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{
    public class datadiri
    {
        public string name;
        public string nim;

        public datadiri(string name, string nim)
        {
            this.name = name;
            this.nim = nim;
        }
    }

    class construct
    {
        static void Main()
        {
            datadiri mahasiswa = new datadiri("Louis", "21051214021");
            Console.WriteLine("Nama Mahasiswa : " +mahasiswa.name);
            Console.WriteLine("NIM Mahasiswa  : " + mahasiswa.nim);
            Console.ReadKey();
        }
    }

    class destructor
    {
        public destructor(string name)
        {
            Console.WriteLine("Constructor dijalankan");
        }
        ~destructor()
        {
            Console.WriteLine("Destructor dijalankan");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            destructor dest = new destructor("Destruct");

            Console.ReadKey();
        }
    }
}