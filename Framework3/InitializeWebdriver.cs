using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework3
{
    class InitializeWebdriver
    {
        public static InitializeWebdriver driver { get; set; }

        enum PropertyType
        {
            Id,
            Name,
            CssName,
            ClassName
        }
    }
}
