using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    // Icomparible is used to provid a Default sort order for your obj(object).
    public class FindMaxGeneric<T> where T : IComparable
    {
        public T GenericValue(T firstNum, T secondNum, T thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0)
            {
                return firstNum;
            }
                
           else if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0)
            {
                return secondNum;
            }
            else
            {
                return thirdNum;
            }
               
        }
    }
}

