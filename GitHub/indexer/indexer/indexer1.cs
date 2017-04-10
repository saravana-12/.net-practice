using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer
{
    public class indexer1
    {
        int id;
        string name;
        int age;
        string quote;
        public indexer1 (int id, string name, int age, string quote)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.quote = quote;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return id;
                else if (index == 1)
                    return name;
                else if (index == 2)
                    return age;
                else if (index == 3)
                    return quote;
                return null;
            }
            set
            {
                if (index == 0)
                     id=(int)value ;
                else if (index == 1)
                    name=(string)value;
                else if (index == 2)
                     age=(int)value;
                else if (index == 3)
                     quote=(string)value;
            }
        }
    }
     
}
