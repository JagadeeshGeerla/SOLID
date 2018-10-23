using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    #region SRP
    /// <summary>
    /// A class should have one, and only one, reason to change.
    /// </summary>
    //class Customer
    //{
    //    public void Add()
    //    {
    //        try
    //        {
    //            // Database code goes here
    //        }
    //        catch (Exception ex)
    //        {
    //            System.IO.File.WriteAllText(@"c:\Error.txt", ex.ToString());
    //        }
    //    }
    //}

    class Customer
    {
        private FileLogger obj = new FileLogger();
        public virtual void Add()
        {
            try
            {
                // Database code goes here
            }
            catch (Exception ex)
            {
                obj.Handle(ex.ToString());
            }
        }
    }
    class FileLogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }
    #endregion

}
