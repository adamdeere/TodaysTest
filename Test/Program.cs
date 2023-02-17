// See https://aka.ms/new-console-template for more information

 


using System.ComponentModel;
using Test;

//Write a C# Sharp program to remove the character in a given position of a given string. 
    //The given position will be in the range 0.. string length -1 inclusive. 
CheckForMultiple check = new CheckForMultiple();
check.DoCheck(20);

Console.WriteLine("---------------");

RemoveChracterInString remove = new RemoveChracterInString();
string word = remove.RemoveChracterInStringArray("python", 1);
Console.WriteLine(word);

Console.WriteLine("-----------------");

DateTimeChecker checker = new DateTimeChecker();

string date = checker.ReturnTodaysDate();
Console.WriteLine(date);

string yesterday = checker.ReturnYesterdaysDate();
Console.WriteLine(yesterday);
