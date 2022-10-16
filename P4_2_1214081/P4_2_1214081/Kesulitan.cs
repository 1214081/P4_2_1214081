using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214081
{
    public class Kesulitan : Champion
    {
        private string kesulitanChamp;

        public Kesulitan(string Kesulitan)
        {
            this.kesulitan = Kesulitan;

            Console.WriteLine("Ini dari class Kesulitan\n");
        }

        public string kesulitan
        {
            get
            {
                return kesulitanChamp;
            }
            set
            {
                kesulitanChamp = value;
            }
        }
    }
}
