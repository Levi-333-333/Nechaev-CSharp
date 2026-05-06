using System;
using System.Diagnostics;
using System.Numerics;

class College
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public College(int id, string? name)
    {  
        Id = id; 
        Name = name; 
    }
}
class Student
{
    public int Id { get; set; }
    public int CollegeId { get; set; }
    public int VoenkomatId { get; set; }
    public string Name { get; set; }
    public uint Score { get; set; }

    public Student(int id, int collegeId, int voenkomatId, string name, uint score)
    {
        Id = id;
        CollegeId = collegeId;
        VoenkomatId = voenkomatId;
        Name = name;
        Score = score;
    }
}
class Voenkomat
{
    public string? Name { get; set; }
    public int Id { get; set; }
    public Voenkomat(int id, string? name)
    {
        Id = id;
        Name = name;
    }
}

class Source
{
    static void Main(string[] args)
    {
        List<College> colleges = new List<College>
        {
            new College(0, "IT TOP"),
            new College(1, "VOLSU"),
            new College(2, "VSPU"),
            new College(3, "ALABUGA")
        };
        List<Voenkomat> voenkomats = new List<Voenkomat>
        {
            new Voenkomat(0, "IT TOP Voenkomat"),
            new Voenkomat(1, "Военный Комиссариат Советского, Ворошиловского и Кировского райнов"),
            new Voenkomat(2, "Военкомат"),
            new Voenkomat(3, "Военный Комиссариат Волгоградской Области"),
            new Voenkomat(4, "Военкомат г. Волжский Волгоградской Области")
        };

        List<Student> students = new List<Student>
        {
            new Student(1, colleges[0].Id, voenkomats[2].Id, "Андрей", 10),
            new Student(2, colleges[2].Id, voenkomats[0].Id, "Давид", 1),
            new Student(3, colleges[1].Id, voenkomats[4].Id, "Рия", 5),
            new Student(4, colleges[3].Id, voenkomats[1].Id, "Расул", 120000),
            new Student(5, colleges[3].Id, voenkomats[4].Id, "Лев", 5),
            new Student(6, colleges[2].Id, voenkomats[2].Id, "Алексей", 5),
            new Student(7, colleges[1].Id, voenkomats[2].Id, "Максим", 0),
            new Student(8, colleges[1].Id, voenkomats[3].Id, "Тимур", 4),
            new Student(9, colleges[0].Id, voenkomats[1].Id, "Александр", 365),
            new Student(10, colleges[0].Id, voenkomats[1].Id, "Филипп", 8),
            new Student(11, colleges[0].Id, voenkomats[2].Id, "Тимур", 3),
            new Student(12, colleges[3].Id, voenkomats[1].Id, "Владислав", 4),
            new Student(13, colleges[2].Id, voenkomats[2].Id, "Максим", 3),
            new Student(14, colleges[0].Id, voenkomats[1].Id, "Дмитрий", 6)
        };

        var voikomsJoinLINQ = from student in students join voenkomatJoin in voenkomats on student.VoenkomatId equals voenkomatJoin.Id select new { name = student.Name, voenkomatName = voenkomatJoin.Name };
        foreach (var item in voikomsJoinLINQ)
        {
            Console.WriteLine($"Имя студента: {item.name}, привязан к военкомату {item.voenkomatName}");
            
        }
    }
}