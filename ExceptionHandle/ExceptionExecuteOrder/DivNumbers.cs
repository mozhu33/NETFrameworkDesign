using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExecuteOrder
{
    public class IsZeroException : SystemException
    {
        public IsZeroException(string message)
            : base(message)
        {

        }
    }

    public class ArgsIsNullException : SystemException
    {
        public ArgsIsNullException(string message)
            : base(message)
        {

        }
    }

    public class DivNumbers
    {
        public int? arg1 { get; set; }

        public int arg2 { get; set; }

        public int result { get; set; }

        public DivNumbers()
        {
            result = 0;
        }

        public void division()
        {
            if (string.IsNullOrEmpty(Convert.ToString(arg1)))
            {
                throw (new ArgsIsNullException("参数不能为空！！"));
            }

            if (arg2 == 0)
            {
                throw (new IsZeroException("被除数不能为零!!!"));
            }
        }
    }
}
