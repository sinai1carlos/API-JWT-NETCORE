using jwt.Models;

namespace jwt.Constants
{
    public class EmployeeConstants
    {
        public static List<EmployeeModel> Employees = new List<EmployeeModel> 
        { 
            new EmployeeModel() {FirstName="Tomas", LastName="Aliaga", Email="taliaga@gmail.com" } ,
            new EmployeeModel() {FirstName="Marcos", LastName="Gonzales", Email="mgonzales@gmail.com" } 
        };
    }
}
