// See https://aka.ms/new-console-template for more information
int age;
Console.WriteLine("How old are you?");
age = Convert.ToInt32(Console.ReadLine());
if (age >= 13 && age <= 19)
    Console.WriteLine("You are a teenager.");
else
    Console.WriteLine("You are not a teenager.");
Console.WriteLine();

string working;
double money;
Console.WriteLine("How much money do you have?");
money = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Are you working (yes/no)?");
working = Console.ReadLine().ToLower();
if (working == "no" && money >= 20)
    Console.WriteLine("You can go to the movie");
else
    Console.WriteLine("Sorry, you can't go to the movie.");
Console.WriteLine();

string password;
int guesses;
Console.WriteLine("How many guesses did you take?");
guesses = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the password?");
password = Console.ReadLine();
if (guesses < 5 && password == "santa")
    Console.WriteLine("Open Sesame.");
else
    Console.WriteLine("Access Denied.");
Console.WriteLine();

string topping;
Console.WriteLine("What is the pizza topping?");
topping = Console.ReadLine().ToLower();
if (topping == "pepperoni" || topping == "bacon")
    Console.WriteLine("I would eat this.");
else
    Console.WriteLine("No thanks.");
Console.WriteLine();

Console.WriteLine("How old are you?");
age = Convert.ToInt32(Console.ReadLine());
if (age <= 12 || age >= 60)
    Console.WriteLine("The pass is $2.00");
else
    Console.WriteLine("The pass is $3.50");
Console.WriteLine();

string animal;
Console.WriteLine("What is your favourite type of animal");
animal = Console.ReadLine().ToLower();
if (animal == "cat" || animal == "dog")
    Console.WriteLine("Me Too!");
else
    Console.WriteLine("To each their own.");
Console.WriteLine();

string weather;
int temperature;
Console.WriteLine("What is the temperature outside?");
temperature = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("What is the weather like (sunny/cloudy)?");
weather = Console.ReadLine().ToLower();
if (weather == "sunny" || temperature > 25)
    Console.WriteLine("Swim Time!");
else
    Console.WriteLine("Nap Time!");