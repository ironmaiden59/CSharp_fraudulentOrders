﻿/*
string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";
*/

/*
string[] fraudulentOrderIDs = {"A123", "B456", "C789"};
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
*/

/*
int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;

foreach(int items in inventory)
{
  sum += items;
  bin++;
  Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory");
*/


//Exercise - Complete a challenge activity for nested iteration and selection statements
//Fraudulent order challenge

//Code challenge - Report the Order IDs that need further investigation

/*
string[] orders = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach(string items in orders)
{
  if (items.StartsWith("B"))
  {
    Console.WriteLine(items);
  }
}
*/

Random random = new();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
  // Get a random value that equates to ASCII letters A through E
  int prefixValue = random.Next(65, 70);
  // Convert the random value into a char, then a string
  string prefix = Convert.ToChar(prefixValue).ToString();
  // Create a random number, pad with zeroes
  string suffix = random.Next(1, 1000).ToString("000");
  // Combine the prefix and suffix together, then assign to current OrderID
  orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach(var orderID in orderIDs)
{
  Console.WriteLine(orderID);
}


