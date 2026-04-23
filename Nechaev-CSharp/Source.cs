using System;
using System.Diagnostics;
 
class Student
{
    public string Name { get; set; }
    public int Id { get; set; }
    public uint Score { get; set; }
    public Student(string name, int id, uint score)
    {
        Name = name;
        Id = id;
        Score = score;
    }
}

class StudentPerformance
{
    public string Name { get; set; }
    public uint Score { get; set; }
    public StudentPerformance(string name, uint score)
    {
        Name = name;
        Score = score;
    }
}

class Source
{
    string whoIsMe = "я редиска";
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>(new[] { new Student ( "Давид", 0, 2 ), new Student ( "Лев", 1, 1 ), new Student ("Рия", 2, 5), new Student ("Андрей", 3, 3), new Student ( "Максим", 4, 5 ), new Student ( "Алексей", 5, 5 ), new Student ( "Тимур", 6, 0 ), new Student ( "Дмитрий", 7, 3 ), new Student ( "Ираклий", 8, 3 ), new Student ( "Расул", 9, 4 ), new Student ( "Тимур Тимурович", 10, 2 ), new Student ( "Филипп", 11, 2 ) });

        var names = from student in students select student.Name;
        foreach (string item in names)
        {
            Console.WriteLine(item);
        }

        var sudentPerformances = from student in students select new StudentPerformance(student.Name, student.Score);
        foreach (var item in sudentPerformances)
        {
            Console.WriteLine($"Студент {item.Name} с оценкой {item.Score}");
        }
    }
}