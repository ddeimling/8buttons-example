using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightButtonsExample.Service
{
    public class DiodeService : IDiodeService
    {
        public void Switch(int diodeNr)
        {
            Debug.WriteLine($"Diode {diodeNr} switched!");
        }
    }
}
