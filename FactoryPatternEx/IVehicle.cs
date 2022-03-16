using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx
{
    public interface IVehicle
    {
     
        
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Wheels { get; set; }
        
        public void Drive();
                      
                
    }
}
