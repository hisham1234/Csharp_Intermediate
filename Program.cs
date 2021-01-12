using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Intermediate
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var p = Person.Parse("Hisham");
            
            p.Introduce("Mosh");
        }
    }
}
