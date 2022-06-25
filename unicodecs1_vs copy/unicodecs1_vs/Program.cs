
string heroName = "Eula Lawrence";
int heroAge = 21;
int    heroHeight = 170 + 5;
string heroElement = "Cryo";
string heroWeapon = "Claymore";

Console.WriteLine("Hello, I'm Captian " + heroName + " of the Knights of Favonius." + " I'm " + heroAge + " and " +
    heroHeight + " tall, my element is " + heroElement + " using a " + heroWeapon + " !"); // prints Eula dialoge 

string villianName = "Tartaglia";
int    villianAge = 25;
int    villianHeight = 185;
string villianElement = "Hydro";
string villianWeapon = "Bow";

Console.WriteLine("Hey, I'm " + villianName + " No. 11 of the Fatui Harbingers, codename Childe. I'm " + villianAge +
    " and my height is " + villianHeight + ", " + villianElement + " is my element using a " + villianWeapon + "."); // prints Childe dialoge

int ageDifference = villianAge - heroAge;
Console.WriteLine("The age differnece between Eula and Tartaglia is : " + ageDifference);