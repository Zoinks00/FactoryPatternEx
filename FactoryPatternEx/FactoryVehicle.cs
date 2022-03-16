using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx
{
    public  class FactoryVehicle
    {
        public  static IVehicle GetVehicle(int wheelCount)
        {
             switch (wheelCount)
            {
                
                case 4:
                    return new Car("Firebird", "Trans AM", 1962, 4);
                    
                case 16:
                    return new BigRig("Peterbilt", "379", 1992, 16);
                default:
                    return new Car("Firebird", "Trans AM", 1962, 4);
                    
            }


        }
    }
}
