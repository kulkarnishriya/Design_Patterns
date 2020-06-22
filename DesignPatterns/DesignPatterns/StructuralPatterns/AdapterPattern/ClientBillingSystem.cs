using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    //This is a client class which expects employees to be printed in certain format.
   public class ClientBillingSystem
    {
        private ITarget employeeSource;

        public ClientBillingSystem(ITarget employeeSource)
        {
            this.employeeSource = employeeSource;
        }


        public void ShowEmployeeList()
        {
            List<string> employee = employeeSource.GetEmployeeList();
            //To DO: Implement you business logic

            Console.WriteLine("######### Employee List ##########");
            foreach (var item in employee)
            {
                Console.Write(item);
            }

        }
    }
}
