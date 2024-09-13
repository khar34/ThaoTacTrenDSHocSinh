namespace BaiTapA;

public static class CauB
{
    public static void ShowAllStudentsFromAge15To18 (List<Student> students)
    {
        Console.WriteLine("Nhung hoc sinh co tuoi tu 15 den 18 la:");
        var studentAge = students.Where(s => s.Age >= 15 && s.Age <= 18);
        foreach (var student in studentAge)
        {
            Console.WriteLine(student);
        }
    }
}