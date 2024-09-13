namespace BaiTapA;

public static class CauE
{
    public static void ShowStudentsByOldest(List<Student> students)
    {
        var oldest = students.Max(s => s.Age); // Tìm tuổi lớn nhất
        // Lấy ra các học sinh có tuổi bằng tuổi lớn nhất
        var oldestStudents = students.Where(s => s.Age == oldest).ToList();
        Console.WriteLine("Hoc sinh co tuoi lon nhat:");
        foreach (var student in oldestStudents)
        {
            Console.WriteLine(student);
        }
    }
}