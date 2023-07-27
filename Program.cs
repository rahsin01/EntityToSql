using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityToSQL
{

    class Program
    {
        static void Main(string[] args)
        {
            Notes obj = new Notes( );
            
            obj.CATEGORY = "First Category";
            obj.SUBJECT = "Subject of the Category";
            obj.NODETEXT = "Sample text of the Node";

            Entity<Notes> entity = new Entity<Notes> ();
            entity.Add(obj);

            // Code to get the object values
            Notes note = entity.Get(typeof(System.String), "CATEGORY", "First Category");
        }
    }
}
