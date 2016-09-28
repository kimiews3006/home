using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDSLK
{
    class Element<D>
    {
        private D data;

        public D Data
        {
            get { return data; }
            set { data = value; }
        }

        Element<D> next;

        internal Element<D> Next
        {
            get { return next; }
            set { next = value; }
        }
        public Element(D data)
        {
            this.data = data;
        }
    }
}
