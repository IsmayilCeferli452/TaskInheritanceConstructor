


using Practice_Constructor_inheritance;

////a) Constructor-suz:

//Person person1 = new()
//{
//    id = 1,
//    fullName = "Azad Talibov",
//    age = 25,
//    role = "Dancer",
//};

//Console.WriteLine(person1.role);

////b) Melumatlari Constructor-dan daxil etmek:

//Person person2 = new(2,"Vusal Meherremov",26,"Accounter");

//Console.WriteLine(person2.fullName);


////3) Constructor overloading with "this":

//Person person1 = new()
//{
//    id = 1,
//    fullName = "Azad Talibov",
//    age = 25,
//    role = "Dancer",
//};

//Console.WriteLine(person1.fullName);


/////4) Id-ye gore tapmaq methodu:


Person person1 = new()
{
    id = 1,
    fullName = "Azad Talibov",
    age = 24,
    role = "Dancer",
};

Person person2 = new()
{
    id = 2,
    fullName = "Vusal Meherremov",
    age = 26,
    role = "Footballer",
};

Person person3 = new()
{
    id = 3,
    fullName = "Resad Seferov",
    age = 32,
    role = "Accounter",
};


Person[] people = { person1, person2, person3 };



////a) FirstOrDefault ile:


Person[] GetAllPerson(Person[] people)
{
    return people;
}

Person FindPersonById(Person[] people, int id)
{
    Person person = people.FirstOrDefault(x => x.id == id);
    return person;
}

var foundPerson = FindPersonById(people, 1);

void ShowPersonById(Person person)
{
    if (foundPerson != null)
    {
        Console.WriteLine(foundPerson.fullName);
    }
    else
    {
        Console.WriteLine("Not found");
    }
}

ShowPersonById(foundPerson);

void ShowAllPerson(Person[] people)
{
    foreach (Person person in people)
    {
        var showText = $"Id:" + person.id + " " + "Full Name:" + person.fullName + " " + "Age:" + person.age + " " + "Role:" + person.role;
        Console.WriteLine(showText);
    }
}

ShowAllPerson(GetAllPerson(people));

////En son hali:
ShowPersonById(FindPersonById(GetAllPerson(people), 1));


////b)For ile FindPersonById:
//void FindPersonById(Person[] people, int id)
//{
//    for (int i = 0; i < people.Length; i++)
//    {
//        if (people[i].id == id)
//        {
//            Console.WriteLine(people[i].fullName);
//        }
//    }
//}

//FindPersonById(people, 1);










////========================================INHERITANCE==================================================


Bird bird = new()
{
    name = "Sparrow",
    id = 1,
};

Console.WriteLine(bird.name);


Mammals mammal = new()
{
    name = "Elephant",
    id = 1,
    color = "Blue"
};

Console.WriteLine(mammal.color);


bird.ShowText();

