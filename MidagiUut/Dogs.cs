using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidagiUut
{
    class Dogs:Mammal
    {
        public Dogs()
        {
            Name = "Rex";
            Age = 2;
            Color = "Grey";
            Bark();
        }

        public string Name { get; set; }
        public string Color { get; set; }

        //Kui meetodi ees pole midagi, siis on see private. Et Main programmis kätte saada, tuleb teha publicuks.
        public void Bark()
        {
            Console.WriteLine("Woof");
        }

        public int CalculateDogYears()
        {
            int RealYears = Age * 7;
            return RealYears;
        }
    
    }
}
