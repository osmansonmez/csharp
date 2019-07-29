using System;
using System.Collections.Generic;
using System.Text;

namespace csharpbasicsstandart
{
   public  class ExceptionSample
    {
        public void Method1()
        {
            try
            {
                object obj = null;
                Console.WriteLine(obj.ToString());
            }catch(NullReferenceException ex)
            {
                throw ex;
            }
        }

        public void Method2()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Exception ex1 =  new Exception("Hata Alındı", ex);
                throw ex1;
            }
        }
    }
}
