using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceDataBase
{
    public class TableZlecenia
    {
        private List<RowZlecenia> table = null;

        public TableZlecenia()
        {
            table = new List<RowZlecenia>();
        }

        public TableZlecenia(List<RowZlecenia> rows)
        {
            table = rows;
        }

        public void setTable(List<RowZlecenia> val) { table = val; }
        public List<RowZlecenia> getTable () { return table; }

        public void Clear()
        {
            table = null;
        }

        public RowZlecenia getRow(int number)
        {
            return table[number];
        }

        


    }
}
