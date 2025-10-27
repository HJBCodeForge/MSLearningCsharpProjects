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
string permission = "Admin|Manager";
int level = 55;
string adminAccess;

//Implement business rules
// If the user is an Admin with a level greater than 55, output the message:
// Output:
// Welcome, Super Admin user.
// If the user is an Admin with a level less than or equal to 55, output the message:
// Output:
// Welcome, Admin user.
if (permission.Contains("Admin"))
{
    Console.WriteLine(adminAccess = (level > 55) ? "Welcome, Super Admin user." : "Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    Console.WriteLine(adminAccess = (level >= 20) ? "Contact an Admin for access." : "You do not have sufficient privileges.");
} 
else
{
    Console.WriteLine(adminAccess = "You do not have sufficient privileges.");
}


    // If the user is a Manager with a level 20 or greater, output the message:
        // Output:
        // Contact an Admin for access.
    // If the user is a Manager with a level less than 20, output the message:
        // Output:
        // You do not have sufficient privileges.
    // If the user isn't an Admin or a Manager, output the message:
        // Output:
        // You do not have sufficient privileges.
