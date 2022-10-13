using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace keywordthisdansuper
{
    public class user
    {
        private String nama;
        private String nim;

        public user(String nama, String nim)
        {
            this.nama = nama;
            this.setNim(nim);
        }

        public String getNim()
        {
            return this.nim;
        }
        public void setNim(String nim)
        {
            if (nim == "1" || nim == "2" || nim == "3" || nim == "4" || nim == "5")
            {
                this.nim = nim;
            }
            else
            {
                this.nim = "NIM Tidak Terdaftar";
            }
        }
    }
    class mhs
    {
        static void Main(string[] args)
        {
            user louis = new user("Louis", "3");
            user wang = new user("Wang", "9");
            Console.WriteLine(louis.getNim);
            Console.WriteLine(wang.getNim);
            Console.ReadLine();

        }
    }
}