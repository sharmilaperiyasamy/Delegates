using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_DS
{
    internal class Delegates
    {
        delegate void DelegateOperation(int a, int b);
        public static void DelegateImplementation()
        {
            DelegateOperation[] obj =
            {
                new DelegateOperation(Delegates_DS.Arithmetic_Operation.Addition),
                new DelegateOperation(Delegates_DS.Arithmetic_Operation.Multiplication)
            };
            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](3, 8);
                obj[i](4, 10);
                obj[i](6, 7);
            }

        }
    }
}
