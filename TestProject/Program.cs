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
int[] ref_A= new int[1];
ref_A[0] = 2;
int[] ref_B = ref_A;
ref_B[0] = 5;

Console.WriteLine("--Reference Types--");
Console.WriteLine($"ref_A[0]: {ref_A[0]}");
Console.WriteLine($"ref_B[0]: {ref_B[0]}");