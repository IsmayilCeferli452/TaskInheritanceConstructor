


#region CustomMaths


using Task_Constructor_inheritance;

////1) SumOfOddNumbersInArray(CustomMath):

//CustomMath customMath1 = new CustomMath();

//int[] numbers = { 1, 2, 3, 4, 5, 6 };

//int result = customMath1.SumOfOddNumbersInArray(numbers);

//Console.WriteLine(result);


////2) OddOrEven(CustomMath):

//CustomMath customMath2 = new();

//var result = customMath2.OddOrEven(5);

//Console.WriteLine(result);


////3) SquareOfNumbers(CustomMath):

//CustomMath customMath3 = new CustomMath();

//int result = customMath3.SquareOfNumbers(1,2,3,4);

//Console.WriteLine(result);


////4) ResultOfNumbers(CustomMath):


//CustomMath customMath4 = new CustomMath();

//int result = customMath4.ResultOfNumbers(5);

//Console.WriteLine(result);


#endregion


#region Employee

Employee employee = new Employee();

Employee employee1 = new()
{
    id = 1,
    name = "Fuad",
    surname = "Seferov",
    address = "Ehmedli",
    email = "fuads123@gmail.com",
    age = 31,
};

Employee employee2 = new()
{
    id = 2,
    name = "Azad",
    surname = "Talibov",
    address = "Hezi Aslanov",
    email = "azadt123@gmail.com",
    age = 25,
};

Employee employee3 = new()
{
    id = 3,
    name = "Vusal",
    surname = "Meherremov",
    address = "Xalqlar Dostlugu",
    email = "vusal123@mail.ru",
    age = 21,
};

Employee employee4 = new()
{
    id = 4,
    name = "Seid",
    surname = "Bilalov",
    address = "Neftciler",
    email = "bilalov123@mail.ru",
    age = 27,
};


Employee[] employees = { employee1, employee2, employee3, employee4 };

////1) Yashi methoda parametr kimi gelen yashdan boyuk olan 
////employee - lerin  siyahisini qaytaran method:

//var response = employee.FindPeopleByAge(employees, 27);

//employee.ShowAllPerson(response);


////2) Yashi 20 - ve 30 arasinda olan telebelerin sayini qaytaran method.

//int result = employee.CountOfYoungStudents(employees);

//Console.WriteLine(result);


////3) Butun Employeelerin yashlarinin cemini qaytaran method.

//int result = employee.SumOfEmployeeAges(employees);

//Console.WriteLine(result);


////4) Emaili methoda parametr kimi gelen stringle bashlayan employee-lerin siyahisini qaytaran method.

//var result = employee.GetPeopleByEmail(employees, "azad");

//employee.ShowAllPerson(result);


#endregion;