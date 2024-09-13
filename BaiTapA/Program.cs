namespace BaiTapA
{
    static class ChuongTrinh
    {
        public static void Main(String[] args)
        {
            List<Student> studentsList = new List<Student>
            {
            new Student(1001,"Nguyen Van Mot",19),
            new Student(1002, "Hoang Viet Anh", 15),
            new Student(1003, "Nguyen Van Ban", 16),
            new Student(1004, "Nguyen Van Bon", 17),
            new Student(1005, "Nguyen Van Anh", 18),
            new Student(1006, "Nguyen Van Sau", 14),
            new Student(1007, "Nguyen Van Bay", 19),
            };

            //Menu
            while (true)
            {
                Console.WriteLine("=====================Thao tac tren danh sach hoc sinh==============================");
                Console.WriteLine("1.In ra danh sach toan bo hoc sinh");
                Console.WriteLine("2.Tim va in ra danh sach cac hoc sinh co tuoi tu 15 den 18");
                Console.WriteLine("3.Tim va in ra hoc sinh co ten bat dau bang chu 'A'");
                Console.WriteLine("4.Tinh tong tuoi cua tat ca cac hoc sinh co trong danh sach");
                Console.WriteLine("5.Tim va in ra hoc sinh co tuoi lon nhat");
                Console.WriteLine("6.Sap xep hoc sinh theo tuoi tang dan va in ra danh sach sau khi sap xep");
                Console.WriteLine("0.Thoat.");
                Console.WriteLine("===================================================================================");
                Console.WriteLine("Nhap lua chon: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        CauA.ShowAllStudents(studentsList);
                        break;

                    case "2":
                        CauB.ShowAllStudentsFromAge15To18(studentsList);
                        break;

                    case "3":
                        CauC.StudentsNameStartingWithA(studentsList);
                        break;

                    case "4":
                        CauD.AgeInTotal(studentsList);
                        break;

                    case "5":
                        CauE.ShowStudentsByOldest(studentsList);
                        break;

                    case "6":
                        CauF.SortStudentsByAge(studentsList);
                        break;
                    case "0":
                        return;

                    default:
                        Console.WriteLine("Lua chon khong hop le, vui long nhap lai.");
                        break;
                }
            }

        }
    }
}