using System;
using System.Collections.Generic;
using System.Text;

namespace Association3
{


       //hai yup
    class Installer
    {
        private Logger _logger;
        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void install()
        {
            _logger.Log("That's great");
        }

        //yup
    }
}
