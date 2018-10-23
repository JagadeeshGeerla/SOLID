using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{

    /// <summary>
    ///A: High level modules should not depend upon low level modules. Both should depend upon abstractions.
    ///B: Abstractions should not depend upon details.Details should depend upon abstractions.
    /// </summary>
    /// 

    //new Customer1(new EmailLogger());
   

    class Customer1
    {
        //private FileLogger obj = new FileLogger();
        private ILogger obj;
        //public ILogger ilog { get; set; }
        //public Customer1(ILogger i)
        //{
        //    obj = i;
        //}
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

    interface ILogger
    {
        void Handle(string error);
    }

    class FileLogger1 : ILogger
    {
        public void Handle(string error)
        {
            System.IO.File.WriteAllText(@"c:\Error.txt", error);
        }
    }

    class EverViewerLogger : ILogger
    {
        public void Handle(string error)
        {
            // log errors to event viewer
        }
    }

    class EmailLogger : ILogger
    {
        public void Handle(string error)
        {
            // send errors in email
        }
    }
}
