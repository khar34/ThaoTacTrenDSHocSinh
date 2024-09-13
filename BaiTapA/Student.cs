namespace BaiTapA;

public class Student
{
    private int _id;
    private string _name = string.Empty;
    private int _age;

    public int Id
    {
        get => _id;
        set => _id = value;
    }

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }


    public Student(int id, string name,int age)
    {
        Id = id;
        Name = name;
        Age = age;
    }

    public override string ToString()
    {
        return $"ID: {Id}, Ten: {Name}, Tuoi: {Age}.";
    }
}