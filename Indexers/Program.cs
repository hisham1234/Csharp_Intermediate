using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{

    public class Bucket
    {
        private readonly Dictionary<string, int> bukt = new Dictionary<string, int>();
        
        public int this[string key]
        {

            get
            {
                return bukt[key];
            }

            set
            {
                bukt[key] = value;
            }

        } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bucket = new Bucket();
            bucket["orange"] = 2;

            Console.WriteLine(bucket["orange"]);
        }
    }
}
