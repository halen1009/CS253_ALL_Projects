using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student[] students = new Student[10];
            Random random = new Random();

            string selection = SelectItem();

            Console.WriteLine("排序前");
            for (int index = 0; index < students.Length; index++)
            {
                students[index] = new Student();
                students[index].比哪科 = selection;

                students[index].Name = string.Format("學生{0}", index + 1);
                students[index].國文 = random.Next(60, 101);
                students[index].英文 = random.Next(60, 101);
                students[index].數學 = random.Next(60, 101);
                students[index].社會 = random.Next(60, 101);
                students[index].自然 = random.Next(60, 101);
                Console.WriteLine("{0}，國文:{1}, 英文:{2}, 數學:{3}, 社會:{4}, 自然:{5}", students[index].Name, students[index].國文, students[index].英文, students[index].數學, students[index].社會, students[index].自然);
            }

            Console.WriteLine("排序後");
            Array.Sort(students);
            for (int index = 0; index < students.Length; index++)
            {
                Console.WriteLine("{0}，國文:{1}, 英文:{2}, 數學:{3}, 社會:{4}, 自然:{5}", students[index].Name, students[index].國文, students[index].英文, students[index].數學, students[index].社會, students[index].自然);
            }
        }

        public static string SelectItem()
        {
            Console.Write("請輸入排序項目:");
            return Console.ReadLine();
        }
    }
}