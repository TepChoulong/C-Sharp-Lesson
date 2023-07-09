using System.Collections.Generic;

/*
    List = data structure that represents a list of objects that
           can be accessed by index. Similar to array, but can
           dynamically increase/decrease in size using System.Collection.Generic;
*/

int index;

List<String> Cars = new List<string>();

Cars.Add("Ford Mustang");
Cars.Add("Toyota Camry");
Cars.Add("Toyota Prius");
Cars.Add("Toyota Innova C");

Cars.Remove("Toyota Innova C");
Cars.Insert(3, "Ford Eco Sport");



foreach(String car in Cars)
{
    index = Cars.IndexOf(car);

    Console.WriteLine($"{index}. {car}");
}
