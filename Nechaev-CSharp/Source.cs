using System;
using System.Diagnostics;
 
class Source
{
    string whoIsMe = "я редиска";
    static void Main(string[] args)
    {
        Queue<string> nameQueue = new Queue<string>(new[] { "Давид", "Лев", "Рия", "Тимур", "Филипп", "Расул", "Андрей", "Тимур Тимурович" });
        nameQueue.Enqueue("Родин");
        nameQueue.Dequeue(); // Давид убрался

        Stack<string> nameStack = new Stack<string>(new[] { "Давид", "Лев", "Рия", "Тимур", "Филипп", "Расул", "Андрей", "Тимур Тимурович" });
        nameStack.Push("Родин");
        string poppedItem = nameStack.Pop();
        Console.WriteLine(poppedItem); // Родин
        string tryPoppedItem = "";
        if (nameStack.TryPop(out tryPoppedItem)) Console.WriteLine("Элемент успешно изъятирован.");
        else Console.WriteLine("Провал изъятирования.");

        Dictionary<string, uint> studentsDict = new Dictionary<string, uint>();
        studentsDict.Add("Давид", 2);
        studentsDict.Add("Рия", 5);
        studentsDict.Add("Лев", 2);
        studentsDict.Add("Тимур", 16);
        studentsDict.Add("Филипп", 21);
        studentsDict.Add("Расул", 7);
        studentsDict.Add("Андрей", 0);
        studentsDict.Add("Тимур Тимурович", 67);
        studentsDict["Родин"] = 666;

        foreach (KeyValuePair<string, uint> item in studentsDict)
        {
            Console.WriteLine($"Студент {item.Key} с оценкой {item.Value}");
        }
    }
}