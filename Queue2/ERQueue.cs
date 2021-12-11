using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue2
{
    internal class ERQueue
    {
        private string _name;
        private int _condition;
        public ERQueue(string Name, int Condition) 
        {
        _name = Name;
        _condition = Condition;
        }

        public string Name
        {
            get { return _name; }
        }

       

        public int Condition
        {
            get { return _condition; }
        }

        





        public override string ToString()
        {
          return base.ToString();
        }

        





    }
}
