using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessmod
{
    public class ModifierAccess
    {
         private void modifierprivate()
         {
             Console.WriteLine("Access Modifier PRIVATE");
         }

         public void modifierpublic()
         {
             Console.WriteLine("Access Modifier PUBLIC");
         }

         protected void modifierprotected()
         {
             Console.WriteLine("Access Modifier PROTECTED");
         }

         void modifiertidakada()
         {
             Console.WriteLine("Tidak Ada Modifier");
         }

         static void Main()
         {
             Console.WriteLine("Modifier dalam Satu Class\n\n");
             ModifierAccess test = new ModifierAccess();
             test.modifierprivate();
             test.modifierpublic();
             test.modifierprotected();
             test.modifiertidakada();
             Console.ReadLine();
         }
    }
    class access2 : ModifierAccess
    {
        static void Main()
        {
            Console.WriteLine("Access modifier pada kelas turunan\n");

            access2 test2 = new access2();
            test2.modifierprotected();
            test2.modifierpublic();
            

            Console.WriteLine("Access modifier Private dan Tanpa akses modifier tidak dapat ditampilkan");
            Console.WriteLine("Secara default, member tanpa Access Modifier akan menjadi Private");
            Console.ReadLine();
        }
    }
    class access3
    {
        static void Main()
        {
            Console.WriteLine("Access modifier pada kelas yang berbeda dan bukan turunan\n");

            ModifierAccess ma = new ModifierAccess();
            ma.modifierpublic();

            Console.WriteLine("/n Access modifier Private, Protected dan Tanpa akses modifier tidak dapat ditampilkan");
            Console.WriteLine("Karena access modifier protected hanya dapat diakses oleh kelas turunannya saja");
            Console.ReadLine();
        }
    }
}