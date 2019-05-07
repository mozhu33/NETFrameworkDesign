using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerExceptionExample
{
    public class AppException : Exception
    {
        public AppException(string message)
            : base(message)
        {

        }

        public AppException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }

    public class Example
    {


        public void ThrowInner()
        {
            throw new AppException("Exception in Inner Method");
        }

        public void CatchInner()
        {
            try
            {
                this.ThrowInner();
            }
            catch (AppException ex)
            {
                //再次抛出异常时，带有上次异常的Exception，上次的异常便作为本次抛出异常的innerException存在
                //innerException可以带出最初抛出异常的位置信息
                throw new AppException("Error in CatchInner caused by calling the ThrowInner method", ex);
            }
        }
    }
}
