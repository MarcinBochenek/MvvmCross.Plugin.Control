using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmCross.Plugin.Control.Sample.Core
{
    public class Service : IService
    {
        public string GetValue()
        {
            return "Initialized";
        }
    }
}
