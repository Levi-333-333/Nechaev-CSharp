using System;
using System.Diagnostics;
using System.Numerics;
using System.Text;

class Source
{
    public static string BuildReportv2(List<int> numbers)
    {
        StringBuilder sb = new StringBuilder();

        var linq = from item in numbers where item % 2 == 0 select item;

        foreach (int item in linq)
        {
            sb.Append(item).Append(';');
        }

        return sb.ToString();
    }
    static void Main(string[] args)
    {
        List<int> arr = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        Console.WriteLine(BuildReportv2(arr));
    }
}