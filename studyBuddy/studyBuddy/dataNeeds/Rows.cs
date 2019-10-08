using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyBuddy.dataNeeds
{
    class Rows : IEnumerable
    {
        private string[][] row;

        Rows(int amount)
        {
            row = new string[amount][];
        }

        public string[] this[int i] //^indexed
        {
            get { return row[i];  }
            set { row[i] = value; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return null;
        }
    }

    class RowsEnumerator : IEnumerator
    {
        public string[][] row;

        int pos = -1;

        public RowsEnumerator(string[][] rows)
        {
            row = rows;
        }

        public bool MoveNext()
        {
            pos++;
            return (pos < row.Length);
        }

        public void Reset()
        {
            pos = -1;
        }

        object IEnumerator.Current
        {
            get
            {
                return row[pos]; //string[][] row;
            }
        }

        
    }

}
