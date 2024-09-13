namespace BaiTapA;

public static class CauF
{
    public static void SortStudentsByAge(List<Student> students)
    {
        Console.WriteLine("Danh sach hoc sinh theo tuoi tang dan:");
        var sortedStudents = students.OrderBy(s => s.Age);
        foreach (var student in sortedStudents)
        {
            Console.WriteLine(student);
        }
    }
}