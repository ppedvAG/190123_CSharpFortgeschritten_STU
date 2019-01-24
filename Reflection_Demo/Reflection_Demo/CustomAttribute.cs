using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Demo
{
    [AttributeUsage(AttributeTargets.Property)]
    class CustomAttribute : Attribute
    {
        public string Text { get; set; }
    }
}
