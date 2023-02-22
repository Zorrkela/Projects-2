using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1
{
    class DBRecord
    {
        private Dictionary<string, object> columns = new Dictionary<string, object>();
        public void addColumn(string name, object value)
        {
            //dodavanje nove kolone u bazu
            columns.Add(name, value);
        }
        public Dictionary<string, object> getColumns()
        {
            return columns;
        }
    }
}
