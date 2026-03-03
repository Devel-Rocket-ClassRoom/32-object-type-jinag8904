using System;

object[] data = { 42, 3.14, "Hello", true, 100, "World", false, 2.718 };

DataPrinter dp = new DataPrinter();
dp.PrintAll(data);

Console.WriteLine("\n[타입별 통계]");

Console.WriteLine($"정수: {dp.intCount}개");
Console.WriteLine($"실수: {dp.doubleCount}개");
Console.WriteLine($"문자열: {dp.stringCount}개");
Console.WriteLine($"논리값: {dp.boolCount}개");