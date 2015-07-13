using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    /// <summary>
    /// Business Logic for Math operations
    /// </summary>
    public class MathService
    {
        /// <summary>
        /// Make an addition for two numbers
        /// </summary>
        /// <param name="value1">number 1</param>
        /// <param name="value2">number 2</param>
        /// <returns></returns>
        public int Addition(int value1, int value2)
        {
            return value1 + value2;
        }
    }
}
