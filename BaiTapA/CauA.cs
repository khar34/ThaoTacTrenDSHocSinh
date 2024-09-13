namespace BaiTapA;

public static class CauA
{
    public static void ShowAllStudents(List<Student> students)
    {
        Console.WriteLine("Danh sach hoc sinh:");
        students.ForEach(student => Console.WriteLine(student));
    }
}