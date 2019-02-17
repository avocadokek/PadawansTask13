using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadawansTask13
{

    class Employee
    {
        
        private int _age;
        string _surname;

        public Employee(int _age, string _surname)
        {
            
                this._age = 35;
                this._surname = "Rita";
            
            throw new Exception();
        }

        public Employee()
        {
            _age = 27;
            _surname = "Ivan";
            throw new Exception();
        }
        private string GetEmployeeAge(int Age)
        {
            _age = Age;
            return Convert.ToString(_age);
            throw new Exception();
        }

        public string GetInfo()
        {

            _surname = "Name";
            _age = 28;
            return $"{_age} + {_surname}";
            throw new Exception();
        }

        public void SetSurname(string value)
        {
            _surname = value;
            throw new Exception();
        } 
    
    
}

}
