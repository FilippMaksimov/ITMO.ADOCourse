using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.ADOCourse.Lab07.Linq_Student.Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> studentQuery = from student in students
                                                where student.Scores[0] > 90 && student.Scores[3] < 80
                                                //orderby student.Last ascending 
                                                orderby student.Scores[0] descending
                                                select student;

            //Using "group" the key for searching is student.Last[0]
            var studentQuery2 = from student in students group student by student.Last[0];

            var studentQuery3 = from student in students group student by student.Last[0];

            //Группировка фамилий по алфавитному порядку
            var studentQuery4 = from student in students
                                group student by student.Last[0] into studentGroup
                                orderby studentGroup.Key
                                select studentGroup;

            var studentQuery5 = from student in students
                                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                                where totalScore / 4 < student.Scores[0]
                                select student.Last + " " + student.First;

            var studentQuery6 = from student in students
                                let totalScore = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                                select totalScore;
            double avScore = studentQuery6.Average();
            Console.WriteLine("class average score = {0}", avScore + Environment.NewLine);

            IEnumerable<string> studentQuery7 = from student in students
                                                where student.Last == "Garcia"
                                                select student.First;
            IEnumerable<string> studentQuery8 = from student in students
                                                where student.Last == "Peterson"
                                                select student.First;

            var studentQuery9 = from student in students
                                let x = student.Scores[0] + student.Scores[1] + student.Scores[2] + student.Scores[3]
                                where x > avScore
                                select new { id = student.ID, score = x };

            //Группирует по первой букве фамилии
            foreach (var gropupOfStudents in studentQuery3)
            {
                Console.WriteLine(gropupOfStudents.Key);
                foreach (var student in gropupOfStudents)
                {
                    Console.WriteLine("{0},{1}", student.Last, student.First);
                }
            }
            Console.WriteLine(Environment.NewLine);

            //При выполнении этого запроса список будет идти по алфавитному порядку 
            foreach (var groupOfStudents in studentQuery4)
            {
                Console.WriteLine(groupOfStudents.Key);
                foreach (var student in groupOfStudents)
                {
                    Console.WriteLine("{0}, {1}", student.Last, student.First);
                }
            }
            Console.WriteLine(Environment.NewLine);

            foreach (string s in studentQuery5)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(Environment.NewLine);

            //Перебор строк по критерию
            Console.WriteLine("The Garcias in the class are:");
            foreach (string student in studentQuery7)
            {
                Console.WriteLine(student);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The Petersons in the class are:");
            foreach (string s in studentQuery8)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(Environment.NewLine);

            //Отображение Id учащихся, чьи баллы выше среднего 
            foreach (var item in studentQuery9)
            {
                Console.WriteLine("Student ID: {0}, Score: {1}", item.id, item.score);
            }
        }
        static List<Student> students = new List<Student>
        {
            new Student {First="Svetlana", Last="Omelchenko", ID=111, Scores = new List<int> {97,92,81,60}},
            new Student {First="Claire", Last="O’Donnell", ID=112, Scores = new List<int> {75,84,91,39}},
            new Student {First="Jacob", Last="Peterson", ID=113, Scores = new List<int> {50,85,74,89}},
            new Student {First="Max", Last="Smith", ID=114, Scores = new List<int> {70,65,85,38}},
            new Student {First="Linda", Last="Peterson", ID=115, Scores = new List<int> {90,89,91,99}},
            new Student {First="Michael", Last="Silver", ID=116, Scores = new List<int> {89,95,91,85}},
            new Student {First="Mauricio", Last="Garcia", ID=117, Scores = new List<int> {80,84,75,71}},
            new Student {First="Maria", Last="Garcia", ID=118, Scores = new List<int> {85,84,91,79}},
            new Student {First="Antonio", Last="Garcia", ID=119, Scores = new List<int> {73,90,81,79}},
            new Student {First="Alex", Last="Gromov", ID=120, Scores = new List<int> {85,70,68,79}},
            new Student {First="Alisa", Last="Petrowska", ID=121, Scores = new List<int> {89,90,91,99}},
            new Student {First="Marry", Last="O'Nill", ID=122, Scores = new List<int> {75,64,81,59}},
            new Student {First="Anton", Last="Andreev", ID=123, Scores = new List<int> {85,84,91,79}},
        };
    }
}
