using System;

namespace Association3
{
    class Program
    {
        static void Main(string[] args)
        {

            Logger logger = new Logger();
            Installer ins = new Installer(logger);


            ins.install();


        }
    }
}
