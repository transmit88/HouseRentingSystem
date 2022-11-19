using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseRentingSystem.Core.Exceptions
{
    public class HouseRentingExeption : ApplicationException
    {
        public HouseRentingExeption()
        {

        }

        public HouseRentingExeption( string errorMessage)
            : base(errorMessage)
        {

        }

    }
}
