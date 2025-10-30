//---> Use the equality operator
// string value1 = " a";
// string value2 = "A ";
// Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

// Console.WriteLine("a" != "a");
// Console.WriteLine("a" != "A");
// Console.WriteLine(1 != 2);

// string myValue = "a";
// Console.WriteLine(myValue != "a");

//---> Evaluating comparisons
// Console.WriteLine(1 > 2);
// Console.WriteLine(1 < 2);
// Console.WriteLine(1 >= 1);
// Console.WriteLine(1 <= 1);

//---> Methods that return a Boolean value
//string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

//---> Logical negation
// string pangram = "The quick brown fox jumps over the lazy dog.";
// Console.WriteLine(!pangram.Contains("fox"));
// Console.WriteLine(!pangram.Contains("cow"));

//---> Inequality operator versus logical negation
// int a = 7;
// int b = 6;
// Console.WriteLine(a != b); // output: True
// string s1 = "Hello";
// string s2 = "Hello";
// Console.WriteLine(s1 != s2); // output: False

//---> Conditional operators
// int saleAmount = 1001;
// //int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Total discount: {(saleAmount > 1000 ? 100 : 50)}");

//---> Code challenge: write code to display the result of a coin flip <---
// Random coin = new Random();
// int flip = coin.Next(0, 2);
// Console.WriteLine((flip == 0) ? "Heads" : "Tails");

//<--- Exercise --->
// string permission = "Admin|Manager";
// int level = 55;
// string adminAccess;

//Implement business rules
// If the user is an Admin with a level greater than 55, output the message:
// Output:
// Welcome, Super Admin user.
// If the user is an Admin with a level less than or equal to 55, output the message:
// Output:
// Welcome, Admin user.
// If the user is a Manager with a level 20 or greater, output the message:
// Output:
// Contact an Admin for access.
// If the user is a Manager with a level less than 20, output the message:
// Output:
// You do not have sufficient privileges.
// If the user isn't an Admin or a Manager, output the message:
// Output:
// You do not have sufficient privileges.

// if (permission.Contains("Admin"))
// {
//     Console.WriteLine(adminAccess = (level > 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.");
// }
// else if (permission.Contains("Manager"))
// {
//     Console.WriteLine(adminAccess = (level >= 20) ? "Contact an Admin for access." : "You do not have sufficient privileges.");
// }
// else
// {
//     Console.WriteLine(adminAccess = "You do not have sufficient privileges.");
// }

//<--- Exercise - Code blocks and variable scope --->

// Code sample 1
// bool flag = true;
// int value;

// if (flag)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");

// Code sample 2
// int value;

// if (true)
// {
//     value = 10;
//     Console.WriteLine($"Inside the code block: {value}");
// }

// Console.WriteLine($"Outside the code block: {value}");

// <--- Create an example of an if statement that uses a code block --->
//Bad convention and hard to read
// string name = "steve";
// if (name == "bob") Console.WriteLine("Found Bob");
// else if (name == "steve") Console.WriteLine("Found Steve");
// else Console.WriteLine("Found Chuck");

//Good convention - easier to read
// string name = "steve";

// if (name == "bob")
//     Console.WriteLine("Found Bob");
// else if (name == "steve") 
//     Console.WriteLine("Found Steve");
// else
//     Console.WriteLine("Found Chuck");

//<--- Exercise - Complete a challenge activity using variable scope --->
// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;
// bool found = false;

// foreach (int number in numbers)
// {
//     total += number;
//     if (number == 42)
//         found = true;
// }

// if (found) 
//     Console.WriteLine("Set contains 42");

// Console.WriteLine($"Total: {total}");

//<--- Branch the flow of code using the switch-case construct in C# --->
//<--- Exercise - Implement a switch statement --->
// int employeeLevel = 201;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }
// Console.WriteLine($"{employeeName}, {title}");

//<--- Modify a switch section to include multiple labels --->
// int employeeLevel = 100;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }
// Console.WriteLine($"{employeeName}, {title}");

//<--- Exercise - Complete a challenge activity using switch statements --->
//<-- Code challenge: rewrite if-elseif-else using a switch statement -->
// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;
// }

// Console.WriteLine($"Product: {size} {color} {type}");

//<--- Iterate through a code block using for statement in C# --->
// skip past certain values
// for (int i = 0; i < 10; i += 3)
// {
//     Console.WriteLine(i);
// }

//break keyword to break the iteration statement
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
//     if (i == 7) break;
// }

//Loop through each element of an array
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
// {
//     Console.WriteLine(names[i]);
// }

//Overcoming the limitation of the foreach statement using the for statement - allows reassignment
// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = 0; i < names.Length; i++)
//     if (names[i] == "David") 
//         names[i] = "Sammy";

// foreach (var name in names) Console.WriteLine(name);

//<--- Exercise - Complete a challenge activity using for and if statements --->
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//         Console.WriteLine($"{i} - FizzBuzz");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else
//         Console.WriteLine($"{i}");
// }

//<--- Add Looping Logic to Your Code Using the do-while and while Statements --->
//<-- Exercise - Create do and while iteration loops -->
// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

//<-- Write a while statement that iterates only while a random number is greater than some value -->
// Random random = new Random();
// int current = random.Next(1, 11);

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

//<-- Use the continue statement to step directly to the Boolean expression -->
// Random random = new Random();
// int current = random.Next(1, 11);

// do
// {
//     current = random.Next(1, 11);

//     if (current >= 8) continue;

//     Console.WriteLine(current);
// } while (current != 7);

// <-- Exercise - Complete a challenge activity using do and while iteration statements -->
//<-- Role playing game battle challenge -->
// Random random = new Random();
// int heroHealth = 10;
// int monsterHealth = 10;
// int diceRoll = 0;
// string winner = "";

// do
// {
//     diceRoll = random.Next(1, 11);
//     monsterHealth -= diceRoll;
//     Console.WriteLine($"Monster was damaged and lost {diceRoll} health and now has {monsterHealth} health.");

//     if (monsterHealth <= 0) continue;

//     diceRoll = random.Next(1, 11);
//     heroHealth -= diceRoll;
//     Console.WriteLine($"Hero was damaged and lost {diceRoll} health and now has {heroHealth} health.");

//     if (heroHealth <= 0) continue;

// } while (monsterHealth > 0 && heroHealth > 0);

// if (monsterHealth <= 0)
// {
//     winner = "Hero";
// } else if (heroHealth <= 0)
// {
//     winner = "Monster";
// }
// Console.WriteLine($"{winner} wins!");

//<-- Exercise - Complete a challenge activity to differentiate between do and while iteration statements -->
//-- Manage user input during this challenge
//nulable type (string?)
// string? readResult;
// Console.WriteLine("Enter a string:");
// do
// {
//     readResult = Console.ReadLine();
// } while (readResult == null);

//Input meats specific requirements
//string? readResult;
// bool validEntry = false;
// Console.WriteLine("Enter a string at least three characters:");
// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null)
//     {
//         if (readResult.Length > 3)
//         {
//             validEntry = true;
//         }
//         else
//         {
//             Console.WriteLine("Your input is not valid. Try again.");
//         }
//     }
// } while (validEntry == false);

//.TryParse() -- method can be used to convert a string value to an integer.
// int numericValue = 0;
// bool validNumber = false;

// validNumber = int.TryParse(readResult, out numericValue);

// <--- Code project 1 - write code that validates integer input --->
/* ---------------MY ATTEMP -----------------
string? readResult;
int numericValue = 0;
bool validInput = false;

Console.WriteLine("Enter an integer value between 5 and 10:");

do
{
    readResult = Console.ReadLine();
    validInput = int.TryParse(readResult, out numericValue);

    while (validInput == false)
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again:");
        readResult = Console.ReadLine();
        validInput = int.TryParse(readResult, out numericValue);
    }

    while ((numericValue <= 5) || (numericValue >= 10))
        {
            Console.WriteLine($"You entered {numericValue}. Please enter a number between 5 and 10.");
            readResult = Console.ReadLine();
            validInput = int.TryParse(readResult, out numericValue);

            if (!validInput)
            {
                Console.WriteLine("Sorry, you entered an invalid number, please try again:");
                readResult = Console.ReadLine();
                validInput = int.TryParse(readResult, out numericValue);
            }
        }

} while (validInput == false);
Console.WriteLine($"Your input value ({numericValue}) has been accepted."); */
/*--------MS give results-------------
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        valueEntered = readResult;
    }

    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true)
    {
        if (numValue <= 5 || numValue >= 10)
        {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
        }
    }
    else 
    {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");

readResult = Console.ReadLine(); */

//<--- Code project 2 - write code that validates string input --->\
/*-------------My ATTEMPT--------------
string roleName;
bool validentry = false;

Console.WriteLine("Enter your role name (Administrator, Manager, or User):");
do
{
    roleName = Console.ReadLine().ToLower().Trim();
    while (!validentry)
    {
        if (roleName == "administrator" || roleName == "manager" || roleName == "user")
        {
            validentry = true;
        }
        else
        {
            Console.WriteLine($"The role name that you entered, \"{roleName}\" is not valid. Enter your role name (Administrator, Manager, or User):");
            roleName = Console.ReadLine().ToLower().Trim();
        }
    }

} while (!validentry);
Console.WriteLine($"Your input value ({roleName}) has been accepted."); */
/*--------------GIVEN RESULT------------
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine(); */

//<--- Code project 3 - Write code that processes the contents of a string array --->
/*------------MY ATTEMPT------------
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringLength = myStrings.Length;
int periodLocation = 0;

for (int i = 0; i < stringLength; i++)
{
    string myString = myStrings[i];
    periodLocation = myString.IndexOf(".");
    while (periodLocation != -1)
    {
        Console.WriteLine(myString.Remove(periodLocation));
        myString = myString.Substring(periodLocation + 1);
        myString = myString.Trim();
        periodLocation = myString.IndexOf(".");
    }

    myString = myString.Trim();
    Console.WriteLine(myString);
} */
/*----------- GIVEN RESULT ------------
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int stringsCount = myStrings.Length;

string myString = "";
int periodLocation = 0;

for (int i = 0; i < stringsCount; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    // extract sentences from each string and display them one at a time
    while (periodLocation != -1)
    {

        // first sentence is the string value to the left of the period location
        mySentence = myString.Remove(periodLocation);

        // the remainder of myString is the string value to the right of the location
        myString = myString.Substring(periodLocation + 1);

        // remove any leading white-space from myString
        myString = myString.TrimStart();

        // update the comma location and increment the counter
        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    }
 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
} */