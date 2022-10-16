using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_1214081
{
    public class Spell : Kesulitan
    {
        protected string SummonorSpell;

        public Spell(string Nama, string Kesulitan, string Spell) : base(Kesulitan)
        {
            this.nama = Nama;
            this.spell = Spell;

            Console.WriteLine("Ini dari class Spell\n");
        }

        public string spell
        {
            get 
            { 
                return SummonorSpell; 
            }
            set 
            {
                SummonorSpell = value; 
            }
        }
    }
}
