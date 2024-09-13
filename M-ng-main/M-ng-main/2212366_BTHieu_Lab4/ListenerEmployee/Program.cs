using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListenerEmployee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employ = new Employee();
            employ.IDEmployee = 6174;
            employ.LastName = "Hieu";
            employ.FirstName = "Bui";
            employ.YearService = 5;
            employ.Salary = 123.45;
        }
    }
}
