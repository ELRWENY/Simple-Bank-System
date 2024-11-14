using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBank
{
    interface CheckInput
    { 
        public abstract void CheckInput(string input, ref int choice);
    }
}
