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
for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    else
    {
        Console.WriteLine($"{i}");
    }
}