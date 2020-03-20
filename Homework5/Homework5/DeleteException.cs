using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework5
{
    class DeleteException:Exception
    {
        public override string ToString()
        {
            return ("删除错误，订单号不存在");
        }
    }
}
