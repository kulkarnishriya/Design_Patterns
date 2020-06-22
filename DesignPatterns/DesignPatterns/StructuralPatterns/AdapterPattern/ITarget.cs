using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.AdapterPattern
{
    public interface ITarget
    {
        List<string> GetEmployeeList();
    }
}