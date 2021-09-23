using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessObjectLayer
{
   public class ListItem
    {
       public readonly short? Id;
       public readonly string Value;
       public ListItem(short? id, string value)
       {
           this.Id = id;
           this.Value = value;
       }
       public override string ToString()
       {
           return Value;
       }
    }
}
