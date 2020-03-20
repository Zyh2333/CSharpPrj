using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class UpdateException:Exception
    {
        public override string ToString()
        {
            return ("更新失败，订单号不存在");
        }
    }
}
