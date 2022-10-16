using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214081
{
    public class Champion
    {
        public string nama;
        public string title;
        public string role;
        public string position;

        public Champion()
        {
            Console.WriteLine("Ini dari class Champion\n");
        }
        public string Nama
        {
            get
            {
                return nama;
            }
            set
            {
                nama = value;
            }
        }
    }
    
}
