//Intro to Madlibs story game
Console.WriteLine("Welcome, time to start the Mad Libs Story.");

string title = "Madmad Libs";

Console.WriteLine(title);


//User inputs and variables for the story

Console.Write("Enter a name: ");
string name = Console.ReadLine();

Console.Write("Enter your first adjective: ");
string adjectiveOne = Console.ReadLine();

Console.Write("Enter a second adjective: ");
string adjectiveTwo = Console.ReadLine();

Console.Write("Enter a third adjective: ");
string adjectiveThree = Console.ReadLine();

Console.Write("Enter a verb: ");
string verb = Console.ReadLine();

Console.Write("Enter your first noun: ");
string nounOne = Console.ReadLine();

Console.Write("Enter your second noun: ");
string nounTwo = Console.ReadLine();

Console.Write("Enter an animal: ");
string animal = Console.ReadLine();

Console.Write("Enter a food: ");
string food = Console.ReadLine();

Console.Write("Enter a fruit: ");
string fruit = Console.ReadLine();

Console.Write("Enter a superhero: ");
string superhero = Console.ReadLine();

Console.Write("Enter a country: ");
string country = Console.ReadLine();

Console.Write("Enter a dessert: ");
string dessert = Console.ReadLine();

Console.Write("Enter a year: ");
string year = Console.ReadLine();

//Story layout with string interpolation
string story = $"This morning {name} woke up feeling {adjectiveOne}. \n'It is going to be a {adjectiveTwo} day!'\nOutside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. \nConcerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. \n{name} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";

//Print to console
Console.WriteLine(story);