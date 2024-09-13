namespace BaiTapA;

public static class CauD
{
    public static void AgeInTotal(List<Student> students)
    {
        var totalAge = students.Sum(s => s.Age);
        Console.WriteLine("Tong tuoi cua tat ca cac hoc sinh trong danh sach: " + totalAge);
    }
}