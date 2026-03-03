using System;

class DataPrinter
{
    public int intCount = 0;
    public int doubleCount = 0;
    public int stringCount = 0;
    public int boolCount = 0;

    public void PrintData(object data)
    {
        switch (data.GetType().Name)
        {
            case "Int32":
                Console.WriteLine($"정수: {data}");
                intCount++;
                break;
            case "Double":
                Console.WriteLine($"실수: {data:F2}");
                doubleCount++;
                break;
            case "String":
                Console.WriteLine($"문자열: \"{data}\" (길이: {data.ToString().Length})");
                stringCount++;
                break;
            case "Boolean":
                Console.WriteLine($"논리값: {data} -> {(data.ToString() == "True"? "참":"거짓")}");
                boolCount++;
                break;
            default:
                Console.WriteLine($"알 수 없는 타입: {data.GetType().Name} - {data}");
                break;
        }
    }

    public void PrintAll(object[] data)
    {
        foreach (object item in data) PrintData(item);
    }
}