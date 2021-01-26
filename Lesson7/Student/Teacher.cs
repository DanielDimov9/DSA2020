using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson7.Student
{
    public class Teacher
    {
        public static void Test()
        {
            Student[] students = GenerateStudentsArray(100);

            students[77].StudentNumber = 777777;
            var student77name = students[77].Name;

            Student[] orderedStudents = SelectionSortStudents(students);

            Student student = BynarySearchStudent(777777, orderedStudents);

            Console.ReadLine();
        }

        private static Student[] GenerateStudentsArray(int size)
        {
            Student[] students = new Student[size];

            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                int r = rnd.Next(1, 10000);

                students[i] = new Student
                {
                    Name = $"Student {r}",
                    StudentNumber = r
                };
            }
            return students;
        }

        public static Student[] SelectionSortStudents(Student[] unsortedArray)
        {
            Student[] arrayToSort = (Student[])unsortedArray.Clone();

            for (int outer = 0; outer < arrayToSort.Length - 1; outer++)
            {
                int min = outer;
                for (int inner = outer + 1; inner < arrayToSort.Length; inner++)
                {
                    if (arrayToSort[inner].StudentNumber < arrayToSort[min].StudentNumber)
                    {
                        min = inner;
                    }
                }

                Student temp = arrayToSort[outer];
                arrayToSort[outer] = arrayToSort[min];
                arrayToSort[min] = temp;
            }

            return arrayToSort;
        }

        public static Student BynarySearchStudent(int studentNumber, Student[] students)
        {
            int low = 0;
            int high = students.Length;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (students[mid].StudentNumber < studentNumber)
                {
                    low = mid + 1;
                }
                else if (students[mid].StudentNumber > studentNumber)
                {
                    high = mid - 1;
                }
                else
                {
                    return students[mid];
                }
            }
            return null;
        }
    }
}
