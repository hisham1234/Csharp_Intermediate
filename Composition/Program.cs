using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{

    public class Logger
    {
        public void Log(string text)
        {
            Console.WriteLine(text);
        }
    }

    public class Installer
    {
        private Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            _logger.Log("Installed");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var inst = new Installer(new Logger());
            inst.Install();
        }
    }
}
