using System.Text;
namespace Lab4
{
    class Program
    {
        static List<Student> ReadData(string fileName)
        {
            List<Student> students = [];
            try
            {
                StreamReader reader = new(fileName);
                string? line;
                while ((line = reader.ReadLine()) != null)
                    students.Add(new(line));
            }
            catch (IOException e) { Console.WriteLine($"Error: {e.Message}"); }
            return students;
        }

        static void Var4(List<Student> students)
        {
            Console.WriteLine("Імена студентів жінок з відмінними оцінками з інформатики:");
            foreach (var student in students)
            {
                if (student.Marks[2] == '5' && (student.sex == 'F' || student.sex == 'Ж'))
                {
                    Console.WriteLine($"{student.surName} {student.firstName} {student.patronymic}");
                }
            }

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = UTF8Encoding.UTF8;
            List<Student> students = ReadData("../../../input.txt");
            Var4(students);
        }
    }
}
