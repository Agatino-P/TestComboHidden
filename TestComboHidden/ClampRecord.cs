using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestComboHidden
{
    public class ClampRecord
    {
        public string Name { get; set; }
        public int Index { get; set; }

        public ClampRecord(string name, int index)
        {
            Name = name;
            Index = index;
        }
    }
}
