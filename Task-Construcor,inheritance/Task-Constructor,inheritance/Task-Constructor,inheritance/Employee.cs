
using System;

namespace Task_Constructor_inheritance
{
    public class Employee
    {

        public int id;
        public string name;
        public string surname;
        public string address;
        public string email;
        public int age;


        //// ==========Employee gostermek ucun method(Program.cs-de lazim olacaq):================

        public void ShowAllPerson(Employee[] employees)
        {
            foreach (Employee employee in employees)
            {
                var showText = $"Id:" + employee.id + " " + "Name:" + employee.name + " " + "Surname:"  + employee.surname + "Address:" + employee.address + "Email:" + employee.email + "Age:" + employee.age;
                Console.WriteLine(showText);
            }
        }


        ////1) Yashi methoda parametr kimi gelen yashdan boyuk olan 
        ////employee-lerin siyahisini qaytaran method.


        public Employee[] FindPeopleByAge(Employee[] people, int age)
        {
            return people.Where(x => x.age > age).ToArray();
        }


        ////2)  Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.

 
        public int CountOfYoungStudents(Employee[] employees)
        {
            int count = 0;

            int result = employees.Count(x => x.age > 20 && x.age < 30);

            //foreach (Employee employee in employees)
            //{
            //    if (employee.age > 20 && employee.age < 30)
            //    {
            //        count++;
            //    }
            //}
            //return count;
            return result;
        }


        ////3)  Butun Employeelerin yashlarinin cemini qaytaran method.


        public int SumOfEmployeeAges(Employee[] employees)
        {
            int sum = 0;
            int result = employees.Sum(x => x.age); 
            //foreach (Employee employee in employees)
            //{
            //    sum += employee.age;
            //}
            return result;
        }


        ////4) Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method:

        public Employee[] GetPeopleByEmail(Employee[] employees, string email)
        {
            var result = employees.Where(x => x.email.Contains(email)).ToArray();
            return result;
        }
    }
}
