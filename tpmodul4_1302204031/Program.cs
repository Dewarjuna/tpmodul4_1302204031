using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302204031
{
    public class Program
    {
        public static void Main()
        {
            HaloGeneric halo = new HaloGeneric();
            halo.SapaUser("Dewa");
            DataGeneric<string> data = new DataGeneric<string>("1302204031");
            data.PrintData();
        }
    }
}