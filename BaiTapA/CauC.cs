namespace BaiTapA;

public static class CauC
{
    public static void StudentsNameStartingWithA(List<Student> students)
    {
        Console.WriteLine("Hoc sinh co ten bat dau bang chu cai 'A':");
        var studentsStartingWithA = students.Where(s =>
        {
            var nameParts = s.Name.Split(' '); //Tách họ và tên thành các từ
            var firstName = nameParts.Last(); //Lấy từ cuối cùng, nghĩa là lấy phần tên
            return firstName.StartsWith("A", StringComparison.OrdinalIgnoreCase);
        });
        foreach (var student in studentsStartingWithA)
        {
            Console.WriteLine(student);
        }
    }
}