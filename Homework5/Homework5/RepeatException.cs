using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class RepeatException:Exception
    {
        public override string ToString()
        {
            return ("订单重复，无法进行其他操作，请检查");
        }
    }
}
