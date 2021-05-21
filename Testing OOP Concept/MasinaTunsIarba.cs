using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class MasinaTunsIarba : IMasina
    {
        public bool Start()
        {
            Console.WriteLine("Masina de tund iarba pornita");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Masina de tund iarba oprita");
            return true;
        }
    }
}
