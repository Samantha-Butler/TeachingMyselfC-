//Intro

Console.WriteLine("Welcome to penny conversion. I will convert your pennies into different amounts!");
Console.Write("How many pennies would you like to convert? ");
string userInput = Console.ReadLine();

//Convert string to double

double amount = Convert.ToDouble(userInput);

//Coin Variables

int pound = 100;
int fiftyPence = 50;
int twentyPence = 20;
int tenPence = 10;
int fivePence = 5;
int twoPence = 2;

//Conversions
double poundCoins = Math.Floor(amount/pound);
double leftOver = amount % pound;

double fiftyCoins = Math.Floor(leftOver/fiftyPence);
double leftOverFifty = leftOver % fiftyPence;

double twentyCoins = Math.Floor(leftOverFifty/twentyPence);
double leftOverTwenty = leftOverFifty % twentyPence;

double tenCoins = Math.Floor(leftOverTwenty/tenPence);
double leftOverTen = leftOverTwenty % tenPence;

double fiveCoins = Math.Floor(leftOverTen/fivePence);
double leftOverFive = leftOverTen % fivePence;

double twoCoins = Math.Floor(leftOverFive/twoPence);
double leftOverTwo = leftOverFive % twoPence;


//Final Statement

Console.WriteLine($"{amount} is equal to... ");
Console.WriteLine($"£1 = {poundCoins}");
Console.WriteLine($"50p = {fiftyCoins} ");
Console.WriteLine($"20p = {twentyCoins}");
Console.WriteLine($"10p = {tenCoins}");
Console.WriteLine($"5p = {fiveCoins}");
Console.WriteLine($"2p = {twoCoins}");
Console.WriteLine($"1p = {leftOverTwo}");