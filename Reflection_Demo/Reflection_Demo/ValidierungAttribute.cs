using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Demo
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field,AllowMultiple =true)]
    class ValidierungAttribute : Attribute
    {
        public int MaxLength { get; set; }
    }
}
