// See https://aka.ms/new-console-template for more information
//dotnet build, build the project for the first time
//dotnet run, run the project
//dotnet new console -o ./CsharpProjects/TestProject
//create a new console project in the specified folder

//---Example of stateful and stateless (static) methods---
//Stateful methods rely on instance data (object state) to perform their operations, 
//Stateless(static) methods do not depend on any instance data and can be called without creating an instance of the class.
// Random dice = new(); //stateful method
// int roll = dice.Next(1, 7); //stateless (static) method
// Console.WriteLine(roll);

//---VOID METHODS---, which do not return a value
//Other methods return a value, the return value is typically the result of an operation. 
//Return value is the primary way for a method to communicate back to the code

//---Overloaded methods---
//Methods can be overloaded by defining multiple methods with the same name but different parameter lists (different types or number of parameters).
//The appropriate method is selected based on the arguments provided during the method call.
// int number = 7;
// string text = "seven";

// Console.WriteLine(number); //int as parameter
// Console.WriteLine(); //zero parameters
// Console.WriteLine(text); //string as parameter

// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// dice.Next(roll3);

//Math class methods challenge
//Implement a method of the Math class that returns the larger of two numbers
// int firstValue = 500;
// int secondValue = 600;
// int largerValue;

// largerValue = Math.Max(firstValue, secondValue);

// Console.WriteLine(largerValue);

/*---DECISION MAKING LOGIC---*/
// Random dice = new();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
// {
//     Console.WriteLine("You rolled triples! +6 bonus to total!");
//     total += 6;
// } else
//     {
//     Console.WriteLine("You rolled doubles! +2 bonus to total!");
//     total += 2;       
//     }
// }

// if (total >= 16)
// {
//     Console.WriteLine("You Win a Car!");
// }
// else if (total >= 10)
// {
//     Console.WriteLine("You Win a new Laptop!");
// }
// else if (total == 7)
// {
//     Console.WriteLine("You win a Trip!");
// }
// else
// {
//     Console.WriteLine("You win a kitten.");
// }

//--Challenge: Improve renewal rate of subscriptions--
// Random random = new();
// int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// if (daysUntilExpiration == 1)
// {
//     discountPercentage = 20;
// }
// else if (daysUntilExpiration <= 5)
// {
//     discountPercentage = 10;
// }

// if (daysUntilExpiration == 0)
// {
//     Console.WriteLine("Your subscription has expired.");
// }
// else if (daysUntilExpiration == 1)
//     {
//         Console.WriteLine($"Your subscription expires within a day! \nRenew now and save {discountPercentage}%!");
//     }
// else if (daysUntilExpiration <= 5)
// {
//     Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. \nRenew now and save {discountPercentage}%!");
// }
// else if (daysUntilExpiration <= 10)
// {
//     Console.WriteLine("Your subscription will expire soon. Renew now!");
// }

//---Arrays ---
//Declaring the array
//string[] fraudulentOrderIds = new string[3];

//Assigning Values
// fraudulentOrderIds[0] = "A123";
// fraudulentOrderIds[1] = "B456";
// fraudulentOrderIds[2] = "C789";

//Out of bounds Index
//fraudulentOrderIds[3] = "D000";

//Initialize an array
//string[] fraudulentOrderIds = ["A123", "B456", "C789"];

//Retrieve values
// Console.WriteLine($"First: {fraudulentOrderIds[0]}");
// Console.WriteLine($"Second: {fraudulentOrderIds[1]}");
// Console.WriteLine($"Third: {fraudulentOrderIds[2]}");

//Reassign values
// fraudulentOrderIds[0] = "F000";
// Console.WriteLine($"Reassign First: {fraudulentOrderIds[0]}");

//Lenght Property
// Console.WriteLine($"There are {fraudulentOrderIds.Length} fraudulent orders to process.");

//--foreach in arrays--
// int[] inventory = [200, 450, 700, 175, 250];
// int sum = 0;
// int bin = 0;
// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }
// Console.WriteLine($"We have {sum} items in the inventory.");

// string[] orderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];
// string[] orderStartingWithB;

// foreach (string oder in orderIDs)
// {
//     if (oder.StartsWith("B"))
//     {
//         Console.WriteLine(oder);
//     }
// }

//---Create Readable Code with Conventions, whitespace and comments ---
//1. Variable name conventions
//a. camel case e.g. thisIsCamelCase;
//b. names should be descriptive and meaningful e.g. 
// You should choose a name for your variable that represents 
// the kind of data it will hold (not the data type). 
// bool orderComplete;, NOT bool isComplete;.
//c. names should be one or more entire words appended together. 
// Don't use contractions because the name of the variable may be unclear to others 
// For example: decimal orderAmount;, NOT decimal odrAmt;.
//d. names shouldn't include the data type of the variable
// like string strMyValue;
// Variable name examples:
// char userOption;
// int gameScore;
// float particlesPerMillion;
// bool processedCustomer;

//Create and use code comments
//Block comments
/*
string firstName = "Bob";
int widgetsPurchased = 7;
Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets.");
*/

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
// Random random = new Random();
// string[] orderIDs = new string[5];

// for (int i = 0; i < orderIDs.Length; i++)
// {
//     int prefixValue = random.Next(65, 70);
//     string prefix = Convert.ToChar(prefixValue).ToString();
//     string suffix = random.Next(1, 1000).ToString("000");

//     orderIDs[i] = prefix + suffix;
// }

// foreach (var orderID in orderIDs)
// {
//     Console.WriteLine(orderID);
// }

//--Use whitespace to make your code easier to read--
// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;
// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
// {
//     if ((roll1 == roll2) && (roll2 == roll3))
//     {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         total += 6;
//     }
//     else
//     {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         total += 2;
//     }
// }

//Code readability challenge

/*This code takes in a sentance a reverse it. 
It also itterates through all the letters 
and counts the amount of o's in the sentance.
I then writes the reversed sentance and the o count to the terminal*/

// string originalMessage = "The quick brown fox jumps over the lazy dog.";

// char[] message = originalMessage.ToCharArray();
// Array.Reverse(message);

// int letterCount = 0;

// foreach (char letter in message)
// {
//     if (letter == 'o')
//     {
//         letterCount++;
//     }
// }

// string newMessage = new String(message);

// Console.WriteLine(newMessage);
// Console.WriteLine($"'o' appears {letterCount} times.");

/*---- Guided project ---- 
     - Develop foreach and if-elseif-else structures to process array data --- */

//Your goal is to update the existing code to include the following features:
// Use arrays to store student names and assignment scores.
// Use a foreach statement to iterate through the student names as an outer program loop.
// Use an if statement within the outer loop to identify the current student name and access 
//that student's assignment scores.
// Use a foreach statement within the outer loop to iterate through the assignment scores array 
//and sum the values.
// Use an updated algorithm within the outer loop to calculate the average exam score for each student.
// Use an if-elseif-else construct within the outer loop to evaluate the average exam score 
//and assign a letter grade automatically.

// initialize variables - graded assignments
// int examAssignments = 5;

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
// int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
// int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
// int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
// int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    

// // Student names
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// int[] studentScores = new int[10];

// string currentStudentLetterGrade = "";

// // Write the Report Header to the console
// Console.WriteLine("Student\t\tGrade\n");

// foreach (string name in studentNames)
// {
//     string currentStudent = name;

//     if (currentStudent == "Sophia")
//         studentScores = sophiaScores;
//     else if (currentStudent == "Andrew")
//         studentScores = andrewScores;
//     else if (currentStudent == "Emma")
//         studentScores = emmaScores;
//     else if (currentStudent == "Logan")
//         studentScores = loganScores;
//     else if (currentStudent == "Becky")
//     studentScores = beckyScores;
//     else if (currentStudent == "Chris")
//         studentScores = chrisScores;
//     else if (currentStudent == "Eric")
//         studentScores = ericScores;
//     else if (currentStudent == "Gregor")
//         studentScores = gregorScores;
//     else
//         continue;

//     // initialize/reset the sum of scored assignments
//     int sumAssignmentScores = 0;

//     // initialize/reset the calculated average of exam + extra credit scores
//     decimal currentStudentGrade = 0;

//     // initialize/reset a counter for the number of assignment 
//     int gradedAssignments = 0;

//     // loop through the scores array and complete calculations for currentStudent
//     foreach (int score in studentScores)
//     {
//         // increment the assignment counter
//         gradedAssignments += 1;

//         if (gradedAssignments <= examAssignments)
//             // add the exam score to the sum
//             sumAssignmentScores += score;

//         else
//             // add the extra credit points to the sum - bonus points equal to 10% of an exam score
//             sumAssignmentScores += score / 10;
//     }

//     currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

//     if (currentStudentGrade >= 97)
//         currentStudentLetterGrade = "A+";

//     else if (currentStudentGrade >= 93)
//         currentStudentLetterGrade = "A";

//     else if (currentStudentGrade >= 90)
//         currentStudentLetterGrade = "A-";

//     else if (currentStudentGrade >= 87)
//         currentStudentLetterGrade = "B+";

//     else if (currentStudentGrade >= 83)
//         currentStudentLetterGrade = "B";

//     else if (currentStudentGrade >= 80)
//         currentStudentLetterGrade = "B-";

//     else if (currentStudentGrade >= 77)
//         currentStudentLetterGrade = "C+";

//     else if (currentStudentGrade >= 73)
//         currentStudentLetterGrade = "C";

//     else if (currentStudentGrade >= 70)
//         currentStudentLetterGrade = "C-";

//     else if (currentStudentGrade >= 67)
//         currentStudentLetterGrade = "D+";

//     else if (currentStudentGrade >= 63)
//         currentStudentLetterGrade = "D";

//     else if (currentStudentGrade >= 60)
//         currentStudentLetterGrade = "D-";

//     else
//         currentStudentLetterGrade = "F";

//     //Console.WriteLine("Student\t\tGrade\tLetter Grade\n");
//     Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
// }

// // required for running in VS Code (keeps the Output windows open to view results)
// Console.WriteLine("\n\rPress the Enter key to continue");
// Console.ReadLine();

/*--- Work with Variable Data in C# Console Applications ---*/
// --- Choose the Correct Data Type in Your C# Code ---

// //Use the MinValue and MaxValue properties for each signed integral type
// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// //Unsigned integral types
// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// --- Exercise - Discover floating-point types ---
//Use the MinValue and MaxValue properties for each signed float type
// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// --- Exercise - Discover reference types ---
//Define a reference type variable
//Define variable
//int[] data;
//create array instace of int
//data = new int[3];
//Create and assign in one
//int[] data = new int[3];

// --- C# string data type ---
// string shortenedString = "Hellow World";
// Console.WriteLine(shortenedString);

// --- Practical concerns using value and reference types ---
//Value Type (int): In this example, val_A and val_B are integer value types.
// int val_A = 2;
// int val_B = val_A;
// val_B = 5;

// Console.WriteLine("--Value Types--");
// Console.WriteLine($"val_A: {val_A}");
// Console.WriteLine($"val_B: {val_B}");

//Reference Type (array): In this example, ref_A and ref_B are array reference types.
// int[] ref_A= new int[1];
// ref_A[0] = 2;
// int[] ref_B = ref_A;
// ref_B[0] = 5;

// Console.WriteLine("--Reference Types--");
// Console.WriteLine($"ref_A[0]: {ref_A[0]}");
// Console.WriteLine($"ref_B[0]: {ref_B[0]}");

//--- Choose the right data type ---
//When in doubt, stick with the basics
// For simplicity's sake you should prefer a subset of basic data types, including:

// int for most whole numbers
// decimal for numbers representing money
// bool for true or false values
// string for alphanumeric value

//Choose specialty complex types for special situations
// byte: working with encoded data that comes from other computer systems or using different character sets.
// double: working with geometric or scientific purposes. double is used frequently when building games involving motion.
// System.DateTime for a specific date and time value.
// System.TimeSpan for a span of years / months / days / hours / minutes / seconds / milliseconds.

/* --- Convert Data Types Using Casting and Conversion Techniques in C# --- */
// --- Exercise - Explore data type casting and conversion ---

//Write code that attempts to add an int and a string and save the result in an int
//Can not convert string to Int
// int first = 2;
// string second = "4";
// int result = first + second;
// Console.WriteLine(result);

// int first = 2;
// string second = "4";
// string result = first + second;
// Console.WriteLine(result);
//Output: 24, it concats string and number. But does not add them.

//Question: Is it possible that attempting to change the value's data type would result in a loss of information?
//Widening Conversion -  can rely on implicit conversion. The compiler handles implicit conversions.
// int myInt = 3;
// Console.WriteLine($"int: {myInt}");
// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

//Perform a cast
// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

//--- Determine if your conversion is a "widening conversion" or a "narrowing conversion" ---
//Write small tests to understand the behaviors 
// decimal myDecimal = 1.23456789m;
// float myFloat = (float)myDecimal;

// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// --- Performing Data Conversions ---
// - Use a helper method on the variable
// - Use a helper method on the data type
// - Use the Convert class' methods

//ToString() to convert a number to a string
// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

//Convert a string to an int using the Parse() helper method
// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);
//TryParse() - avoid exceptions when string can not be converted.

//Convert a string to a int using the Convert class
// string value1 = "5";
// string value2 = "7";
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result); //Convert class is best for converting fractional numbers into whole numbers (int) because it rounds up.
//rather use TryParse()

//Compare casting and converting a decimal into an int
// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

//--- Exercise - Examine the TryParse() method ---
// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//   Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//   Console.WriteLine("Unable to report the measurement.");
// }

//Use the parsed int later in code
// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// Console.WriteLine($"Measurement (w/ offset): {50 + result}");

//String variable to a value that can't be parsed
// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//    Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//    Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
//    Console.WriteLine($"Measurement (w/ offset): {50 + result}");

/* --- Exercise - Complete a challenge to combine string array values as strings and as integers --- */
// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
// double total = 0.0;
// string sentance = "";

// foreach (var item in values)
// {
//   double number = 0;
//   if (double.TryParse(item, out number))
//   {
//     total += number;
//   }
//   else
//   {
//     sentance += item;
//   }
// }
// Console.WriteLine($"Message: {sentance}");
// Console.WriteLine($"Total: {total}");

//Exercise - Complete a challenge to output math operations as specific number types
// int value1 = 11;
// decimal value2 = 6.2m;
// float value3 = 4.3f;

// // Your code here to set result1
// // Hint: You need to round the result to nearest integer (don't just truncate)
// int result1 = Convert.ToInt32(value1 / value2);
// Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// // Your code here to set result2
// decimal result2 = value2 / (decimal)value3;
// Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// // Your code here to set result3
// float result3 = value3 / value1;
// Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");


/* --- Perform Operations on Arrays Using Helper Methods in C# --- */
// Sort and reverse the order of array elements.
// string[] pallets = ["B14", "A11", "B12", "A13"];
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//   Console.WriteLine($"-- {pallet}");
// }
// Console.WriteLine();
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//   Console.WriteLine(pallet);
// }

// Clear and resize the elements of an array.
// string[] pallets = ["B14", "A11", "B12", "A13"];
// Console.WriteLine("");

// //Console.WriteLine($"Before: {pallets[0].ToLower()}");
// Array.Clear(pallets, 0, 2); //0 (starting index), 2 (amount of elements)
// //if (pallets[0] != null)  
// //  Console.WriteLine($"After: {pallets[0].ToLower()}"); // .Clear completly removes the element, null.

// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
//   Console.WriteLine($"-- {pallet}");

// Console.WriteLine();
// Array.Resize(ref pallets, 6); //Resize to add elements
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

// pallets[4] = "C01";
// pallets[5] = "C02";

// foreach (var pallet in pallets)
//   Console.WriteLine($"-- {pallet}");

// Console.WriteLine();
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

// foreach (var pallet in pallets)
//   Console.WriteLine($"-- {pallet}");


// Reverse, then combine the char array into a new string
//ToCharArray() to reverse a string
// using System.Net.Http.Headers;

// String value = "abc123";
// char[] valueArray = value.ToCharArray(); //converts string characters into an array
// Array.Reverse(valueArray);
// string result = new string(valueArray);
// Console.WriteLine(result);


// Join array elements into a string.
// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);

// // Split a string into an array of strings or characters (chars).
// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// --- Exercise - Complete a challenge to reverse words in a sentence ---
//Write code to reverse each word in a message
// string pangram = "The quick brown fox jumps over the lazy dog";
// string revPangram = "";
// string[] items = pangram.Split(" ");
// foreach (var item in items)
// {
//   char[] revWord = item.ToCharArray();
//   Array.Reverse(revWord);
//   string result = new String(revWord);
//   revPangram += result + " ";
// }
// Console.WriteLine(revPangram);

//--- Exercise - Complete a challenge to parse a string of orders, sort the orders and tag possible errors ---
// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
// String[] orderIds = orderStream.Split(",");
// Array.Sort(orderIds);

// for (int i = 0; i < orderIds.Length; i++)
// {
//   if (orderIds[i].Length == 4)
//   {
//     Console.WriteLine(orderIds[i]);
//   }
//   else
//   {
//     Console.WriteLine($"{orderIds[i]}\t- Error");  
//   }
// }

/*--- Format alphanumeric data for presentation in C# --- */
// Use character escape sequences to add tabs, new lines, and Unicode characters to our strings.
// Create verbatim string literals, and escape common characters like backslash ( \ ) and double-quotes ( "" ).
// Merge templates with variables using composite formatting and string interpolation.
// Include various format specifiers for percentages, currency, and numbers.

//--- Exercise - Investigate string formatting basics ---

// Composite Formatting?
// string first = "Hello";
// string second = "World";
//string result = string.Format("{0} {1}", first, second);
// Console.WriteLine("{1} {0}", first, second);
// Console.WriteLine("{0} {0} {0}", first, second);

//String interpolation?
// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

//Formatting currency
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

//Formatting numbers
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");
// Console.WriteLine($"Measurement: {measurement:N4} units");

//Formatting percentages
//decimal tax = .36785m;
//Console.WriteLine($"Tax rate: {tax:P2}");

//Combining formatting approaches
// decimal price = 67.55m;
// decimal salePrice = 59.99m;

// string yourDiscount = String.Format("You saved {0:C2}off the regular {1:C2} price. ", (price - salePrice), price);
// Console.WriteLine(yourDiscount);
// Console.WriteLine(yourDiscount += $"A discount of {(price - salePrice)/price:P2}!");

//--- Exercise - Explore string interpolation ---
// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Sahres: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

//--- Exercise - Discover padding and alignment ---
/*
Here's a brief list of categories of these built-in methods so you can get an idea of what's possible.

Methods that add blank spaces for formatting purposes (PadLeft(), PadRight())
Methods that compare two strings or facilitate comparison (Trim(), TrimStart(), TrimEnd(), GetHashcode(), the Length property)
Methods that help you determine what's inside of a string, or even retrieve just a part of the string (Contains(), StartsWith(), EndsWith(), Substring())
Methods that change the content of the string by replacing, inserting, or removing parts (Replace(), Insert(), Remove())
Methods that turn a string into an array of strings or characters (Split(), ToCharArray()) 
*/

//Formatting strings by adding whitespace before or after
//string input = "Pad this";
// Console.WriteLine(input.PadLeft(12));
// Console.WriteLine(input.PadRight(12));

//What is an overloaded method?
// Console.WriteLine(input.PadLeft(12, '-'));
// Console.WriteLine(input.PadRight(12, '-'));

//Working with padded strings
// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = "$5,000.00";

// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);

// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

//--- Exercise - Complete a challenge to apply string interpolation to a form letter ---
// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"{customerName}, \nAs a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.");
// Console.WriteLine($"\nCurrently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
// Console.WriteLine($"\nOur new product, Glorious Future offers a return of {newReturn:P2}.  Given your current volume, your potential profit would be {newProfit:C2}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += string.Format("{0:P}", currentReturn).PadRight(9);
// comparisonMessage += string.Format("{0:C}", currentProfit);
// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += string.Format("{0:P}", newReturn).PadRight(9);
// comparisonMessage += string.Format("{0:C}", newProfit);

// Console.WriteLine(comparisonMessage);


/* ----- Modify the Content of Strings Using Built-In String Data Type Methods in C# ----- */

//--- Exercise - Use the string's IndexOf() and Substring() helper methods---

// string message = "Find what is (inside the parentheses)";

// //Write code to find parenthesis pairs embedded in a string
// int openingPosition = message.IndexOf('(');
// int closingPosition = message.IndexOf(")");
// //Console.WriteLine(openingPosition);
// //Console.WriteLine(closingPosition);

// openingPosition += 1;

// //Add code to retrieve the value between parenthesis
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

// string message = "What is the value <span>between the tags</span>?";

// int openingPosition = message.IndexOf("<span>");
// int closingPosition = message.IndexOf("</span>");

// openingPosition += 6;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//Avoid magic values
// string message = "What is the value <span>between the tags</span>?";

// const string openSpan = "<span>";
// const string closeSpan = "</span>";

// int openingPosition = message.IndexOf(openSpan);
// int closingPosition = message.IndexOf(closeSpan);

// openingPosition += openSpan.Length;
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//--- Exercise - Use the string's IndexOf() and LastIndexOf() helper methods ---
// string message = "hello there!";

// int first_h = message.IndexOf('h');
// int last_h = message.LastIndexOf('h');

// Console.WriteLine($"For the message: '{message}', the first 'h' is at position {first_h} and the last 'h' is at position {last_h}.");

//Retrieve the last occurrence of a sub string
// string message = "(What if) I am (only interested) in the last (set of parentheses)?";
// int openingPosition = message.LastIndexOf('(');

// openingPosition += 1;
// int closingPosition = message.LastIndexOf(')');
// int length = closingPosition - openingPosition;
// Console.WriteLine(message.Substring(openingPosition, length));

//Retrieve all instances of substrings inside parentheses
// string message = "(What if) there are (more than) one (set of parentheses)?";
// while (true)
// {
//   int openingPosition = message.IndexOf("(");
//   if (openingPosition == -1) break;

//   openingPosition += 1;
//   int closingPosition = message.IndexOf(")");
//   int length = closingPosition - openingPosition;

//   Console.WriteLine(message.Substring(openingPosition, length));

//   // Note the overload of the Substring to return only the remaining 
//   // unprocessed message:
//   message = message.Substring(closingPosition + 1);
// }

//Work with different types of symbol sets with IndexOfAny()

//Example1:
// string message = "Hello, world!";
// char[] charsToFind = { 'a', 'e', 'i' };

// int index = message.IndexOfAny(charsToFind);

// Console.WriteLine($"Found '{message[index]}' in '{message}' at index: {index}.");

//Example2: Find opening symbol
// string message = "Help (find) the {opening symbols}";
// Console.WriteLine($"Searching THIS Message: {message}");
// char[] openSymbols = { '[', '{', '(' };
// int startPosition = 5;
// int openingPosition = message.IndexOfAny(openSymbols);
// Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

// openingPosition = message.IndexOfAny(openSymbols, startPosition);
// Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");

//Example3: Find closing symbol
// string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// char[] openSymbols = { '[', '{', '(' };
// int closingPosition = 0;

// while (true)
// {
//   int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

//   if (openingPosition == -1) break;

//   char closingSymbole = ' ';
//   string currentSymbole = message.Substring(openingPosition, 1);

//   switch (currentSymbole)
//   {
//     case "[":
//       closingSymbole = ']';
//       break;
//     case "{":
//       closingSymbole = '}';
//       break;
//     case "(":
//       closingSymbole = ')';
//       break;
//   }

//   openingPosition += 1;
//   closingPosition = message.IndexOf(closingSymbole, openingPosition);

//   int length = closingPosition - openingPosition;

//   Console.WriteLine(message.Substring(openingPosition, length));
// }

// --- Exercise - Use the Remove() and Replace() methods ---

//Use the Remove() method
// string data = "12345John Smith          5000  3  ";
// string updatedData = data.Remove(5, 20);
// Console.WriteLine(updatedData);

//Use the Replace() method
// string message = "This--is--ex-amp-le--da-ta";
// message = message.Replace("--", " ");
// message = message.Replace("-", "");
// Console.WriteLine(message);

//--- Exercise - Complete a challenge to extract, replace, and remove data from an input string ---

// using System.Security.Authentication.ExtendedProtection;

// const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

// string quantity = "";
// string output = "";

// //Set Quantity
// const string openSpan = "<span>";
// const string closingSpan = "</span>";

// int startQuantity = input.IndexOf(openSpan) + openSpan.Length;
// int endQuantity = input.IndexOf(closingSpan);

// int quantityLenght = endQuantity - startQuantity;

// quantity = "Quantity: " + input.Substring(startQuantity, quantityLenght);

// //Remove open div
// const string opendiv = "<div>";
// int divStart = input.IndexOf(opendiv);
// output = input.Remove(divStart, opendiv.Length);

// //Remove close div
// const string closeingDiv = "</div>";
// int divEnd = output.IndexOf(closeingDiv);
// output = output.Remove(divEnd, closeingDiv.Length);

// //Replace Symbol
// const string tradeSymbol = "&trade;";
// const string regSymbol = "&reg;";

// output = output.Replace(tradeSymbol, regSymbol);

// output = "Output: " + output;


// Console.WriteLine(quantity);
// Console.WriteLine(output);

/* ------  Write your first C# method ------ */
//--- Exercise - Create your first method ---
// void DisplayRandomNumbers()
// {
//   Random random = new Random();
//   for (int i = 0; i < 5; i++)
//   {
//     Console.WriteLine($"{random.Next(1, 100)}");
//   }
//   Console.WriteLine();
// }

// Console.WriteLine("Generating random numbers:");
// DisplayRandomNumbers();

//--- Exercise - Create reusable methods ---
//Tracks medication times across different time zones

// using System;

// int[] times = { 800, 1200, 1600, 2000 };
// int diff = 0;

// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Current Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();

// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());

// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }
// else
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));

//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }

// Console.WriteLine("New Medicine Schedule:");

// /* Format and display medicine times */
// DisplayTimes();


// //Custom Methods
// void DisplayTimes()
// {
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;

//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }

//         Console.Write($"{time} ");
//     }
// }

// void AdjustTimes()
// {
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     for (int i = 0; i < times.Length; i++)
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

/*
if apAddress consists of 4 numbers
and
if each ipAddress has not leading zero's
and
if ipAddress number is in range 0-255

then ipAddress is valid
else ipAdress is invalid 
*/
// string[] ipv4Input = {"555..0.555", "255...255", "107.31.1.5", "255.0.0.255"};
// string[] address;
// bool validLength = false;
// bool validRange = false;
// bool validZeroes = false;

// foreach (string ip in ipv4Input)
// {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     ValidateLength();
//     ValidateRange();
//     ValidateZeroes();


//     if (validLength && validZeroes && validRange)
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     }
//     else
//     {
//         Console.WriteLine($"{ip} is a invalid IPv4 address");
//     }
// }

// void ValidateLength()
// {
//     validLength = address.Length == 4;
// };

// void ValidateZeroes()
// {
//     foreach (string number in address)
//     {
//         if (number.Length > 1 && number.StartsWith("0"))
//         {
//             validZeroes = false;
//             return;
//         }
//     }
//     validZeroes = true;
// };

// void ValidateRange()
// {
//     foreach (string number in address)
//     {
//         int value = int.Parse(number);
//         if (value < 0 || value > 255)
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

// --- Exercise - Complete the challenge to create a reusable method ---
// In game fortune talling method tellFortune(){}

//     Random random = new Random();
//     int luck = random.Next(100);

//     string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
//     string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
//     string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
//     string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

// TellFortune();

// void TellFortune()
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++)
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }

/* ---  Create C# methods with parameters --- */
// --- Exercise - Use parameters in methods ---
// int[] schedule = { 800, 1200, 1600, 2000 };
// DisplayAdjustedTimes(schedule, 6, -6);

// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//   int diff = 0;
//   if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//   {
//     Console.WriteLine("Invalid GMT");
//   }
//   else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
//   {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//   }
//   else
//   {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//   }

//   for (int i = 0; i < times.Length; i++)
//   {
//     int newTime = (times[i] + diff) % 2400;
//     Console.WriteLine($"{times[i]} -> {newTime}");
//   }
// }

// --- Exercise - Understand method scope ---
//Test variable scope
//PrintCircleArea(12);

// double pi = 3.14159;
// PrintCircleInfo(12);
// PrintCircleInfo(24);


// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }

// void PrintCircleCircumference(int radius)
// {
//   double circumference = 2 * pi * radius;
//   Console.WriteLine($"Circumference = {circumference}");
// }

// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }

// --- Exercise - Use value and reference type parameters ---
// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }

//Test pass by reference
// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
//     Console.WriteLine();
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }

//Test with strings
// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(false);
// Console.WriteLine($"End: {status}");

// void SetHealth(bool isHealthy) 
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

// --- Exercise - Methods with optional parameters ---
//Create an RSVP application
// string[] guestList = { "Rebecca", "Nadia", "Noor", "Jonte" };
// string[] rsvps = new string[10];
// int count = 0;

// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// void RSVP(string name, int partySize = 1, string allergies ="none", bool inviteOnly = true)
// {
//   if (inviteOnly)
//   {
//     // search guestList before adding rsvp
//     bool found = false;
//     foreach (string guest in guestList)
//     {
//       if (guest.Equals(name))
//       {
//         found = true;
//         break;
//       }
//     }
//     if (!found)
//     {
//       Console.WriteLine($"Sorry, {name} is not on the guest list");
//       return;
//     }
//   }

//   rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//   count++;
// }

// void ShowRSVPs()
// {
//   Console.WriteLine("\nTotal RSVPs:");
//   for (int i = 0; i < count; i++)
//   {
//     Console.WriteLine(rsvps[i]);
//   }
// }

// --- Exercise - Complete the challenge to display email addresses ---
//Code challenge: Add a method to display email addresses
// string[,] corporate = 
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
// };

// string[,] external = 
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };

// string externalDomain = "hayworth.com";

// for (int i = 0; i < corporate.GetLength(0); i++)
// {
//   // display internal email addresses
//   displayEmailAddress(firstName: corporate[i,0], lastName: corporate[i,1]);
// }

// for (int i = 0; i < external.GetLength(0); i++)
// {
//   // display external email addresses
//   displayEmailAddress(firstName: external[i,0], lastName: external[i,1], domain: externalDomain);
// }

// void displayEmailAddress(string firstName, string lastName, string domain = "contoso.com")
// {
//   string email = firstName.Remove(2).ToLower() + lastName.ToLower();
//   Console.WriteLine($"{email}@{domain}");   
// }

/* ---  Create C# methods that return values --- */
// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//   total += GetDiscountedPrice(i);
// }

// if (TotalMeetsMinimum())
// {
//   total -= 5.00;
// }

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//   // Calculate the discounted price of the item
//   return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//   // Check if the total meets the minimum
//   return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//   // Format the double so only 2 decimal places are displayed
//   return input.ToString().Substring(0,5);
// }

// // --- Exercise - Return numbers from methods ---
// double usd = 23.73;
// int vnd = UsdToVnd(usd);

// Console.WriteLine($"${usd} USD = ${vnd} VND");

// int UsdToVnd(double usd)
// {
//   int rate = 23500;
//   return (int) (usd * rate);
// }

// //Create a method that returns a double
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");

// double VndToUsd(int vnd)
// {
//   double rate = 23500;
//   return vnd / rate;
// }

// // --- Create a method that returns a double ---
// //Create a method that returns a string
// string ReverseWord(string word)
// {
//   string result = "";
//   for (int i = word.Length - 1; i >= 0; i--)
//   {
//     result += word[i];
//   }
//   return result;
// }

// // Console.WriteLine(ReverseWord("Death"));

// //Create a method to reverse words in a sentence
// string ReverseSentance(string sentance)
// {
//   string[] seperateWords = sentance.Split(" ");
//   string result = "";
//   foreach (string word in seperateWords)
//   {
//     result += ReverseWord(word) + " ";
//   }
//   return result.Trim();
// }

//Console.WriteLine(ReverseSentance("Your dog is dumb"));

// // --- Exercise - Return Booleans from methods ---
// // Create a method that returns a Boolean
// string[] words = { "racecar", "talented", "deified", "tent", "tenet" };

// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words)
// {
//   Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }

// bool IsPalindrome(string word)
// {
//   int start = 0;
//   int end = word.Length - 1;

//   while (start < end)
//   {
//     if (word[start] != word[end])
//     {
//       return false;
//     }
//     start++;
//     end--;
//   }
//   return true;
// }

// //--- Exercise - Return arrays from methods ---
// //Find coins to make change
// //Find multiple pairs of coins that make change
// int target = 80;
// int[] coins = new int[] { 5, 5, 50, 25, 25, 10, 5 };
// int[,] result = TwoCoins(coins, target);

// if (result.Length == 0)
// {
//   Console.WriteLine("No two coins make change");
// }
// else
// {
//   Console.WriteLine($"Change found at posiions:");
//   for (int i = 0; i < result.GetLength(0); i++)
//   {
//     if (result[i, 0] == -1)
//     {
//       break;
//     }
//     Console.WriteLine($"{result[i, 0]}, {result[i, 1]}");
//   }
// }

// int[,] TwoCoins(int[] coins, int target)
// {
//   int[,] result = { { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 }, { -1, -1 } };
//   int count = 0;

//   for (int curr = 0; curr < coins.Length; curr++)
//   {
//     for (int next = curr + 1; next < coins.Length; next++)
//     {
//       if (coins[curr] + coins[next] == target)
//       {
//         result[count, 0] = curr;
//         result[count, 1] = next;
//         count++;
//       }
//       if (count == result.GetLength(0))
//       {
//         return result;
//       }
//     }
//   }
//   return (count == 0) ? new int[0, 0] : result;
// }

/* --- Exercise - Complete the challenge to add methods to make the game playable --- */
//Dice mini-game challenge
using Microsoft.VisualBasic;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");

if (ShouldPlay())
{
  PlayGame();
}

void PlayGame()
{
  var play = true;

  while (play)
  {
    var target = random.Next(1, 6);
    var roll = random.Next(1, 7);

    Console.WriteLine($"Roll a number greater than {target} to win!");
    Console.WriteLine($"You rolled a {roll}");
    Console.WriteLine(WinOrLose(target, roll));
    Console.WriteLine("\nPlay again? (Y/N)");
    play = ShouldPlay();
  }
}

bool ShouldPlay()
{
  string? choice = Console.ReadLine();
  return choice.ToLower().Equals("y");
}

string WinOrLose(int target, int roll)
{
  if (roll > target)
  {
    return "You Win!";
  }
    return "You Lose...";

}