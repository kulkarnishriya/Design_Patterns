using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public class AdapterClient
    {
        public static void CallAdapter()
        {
            ITarget Itarget = new EmployeeAdapter();
            ClientBillingSystem client = new ClientBillingSystem(Itarget);
            client.ShowEmployeeList();
        }
    }
}
