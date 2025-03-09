// See https://aka.ms/new-console-template for more information


using System.Diagnostics;

int number = 10;  

Console.WriteLine($"number1: {number}");

number = 20;

Console.WriteLine($"number2: {number}");


float floatNumber = 123.456f;

Console.WriteLine($"floatNumber: {floatNumber}");


string name = "John";

Console.WriteLine($"name: {name}");

bool isTrue = true;

Console.WriteLine($"isTrue: {isTrue}");

var number2 = 10;

Console.WriteLine($"number2: {number2}");


// 배열
// 선언 방법 1. 배열 초기화   
string[] names = { "John", "Jane", "Jim" };

Console.WriteLine($"names: {names[0]}, {names[1]}, {names[2]}");

int[] numbers3 = [ 1, 2, 3 ];

Console.WriteLine($"numbers3: {numbers3[0]}, {numbers3[1]}, {numbers3[2]}");


// 선언 방법 2. 배열 선언
int[] numbers = new int[3]  ;

numbers[0] = 1;
numbers[1] = 2;
numbers[2] = 3;

Console.WriteLine($"numbers: {numbers[0]}, {numbers[1]}, {numbers[2]}");


// 선언 방법 3. 배열 초기화
int[] numbers2 = new int[3] { 1, 2, 3 };

Console.WriteLine($"numbers2: {numbers2[0]}, {numbers2[1]}, {numbers2[2]}");

// 리스트
// 선언 방법 1. 리스트 초기화
List<int> numbersList = new List<int>();

numbersList.Add(1);
numbersList.Add(2);
numbersList.Add(3);

Console.WriteLine($"numbersList: {numbersList[0]}, {numbersList[1]}, {numbersList[2]}");

numbersList.RemoveAt(0);

// 선언 방법 2. 리스트 초기화
List<string> namesList = [ "John", "Jane", "Jim" ];

Console.WriteLine($"Before namesList: {namesList[0]}, {namesList[1]}, {namesList[2]}");

namesList.RemoveAt(0);
namesList.Remove("Jane");
namesList.RemoveAll(name => name == "Jim");





const int maxCount = 100;

Console.WriteLine($"maxCount1: {maxCount}"); 

// maxCount = 200; // 오류 발생

// Console.WriteLine($"maxCount2: {maxCount}"); 









// Console.WriteLine("Hello, World!");
