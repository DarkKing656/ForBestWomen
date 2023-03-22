using System;

namespace project
{
    class Man
    {
        static void Main()
        {
            Console.WriteLine("Введите количество участников");
            int count = Convert.ToInt32(Console.ReadLine());
            Student[] allst = new Student[count];
            for (int i = 0; i < count; i++) 
            {
                allst[i] = new Student();
            }

            
            GetStudents(count, allst);
            SortStudents(count, allst);
            ReversePrintStudents(count, allst);



        }
        static Student[] GetStudents(int a, Student[] array)
        {
            for (int i = 0; i < a; i++)
            {
                string namevr;
                int ballvr;
                Console.WriteLine("Введите фамилию участника");
                namevr = Console.ReadLine();

                if (namevr != null)
                {
                    Console.WriteLine("Введите балл участника");
                    ballvr = Convert.ToInt32(Console.ReadLine());
                    
                    array[i].ball = (int)(ballvr);
                    

                }
                array[i].surname = (string)(namevr);
                



            }
            return array;
        }
        static Student[] SortStudents(int a, Student[] array)
        {
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Student save = new Student();
                    if (array[i].ball > array[j].ball)
                    {
                        save = array[i];
                        array[i] = array[j];
                        array[j] = save;
                    }
                }
            }
            return array;
        }
        static void ReversePrintStudents(int a, Student[] array)
        {
            for (int i = 0; i <a; i++)
            {
                Console.WriteLine($"Фамилия:{array[i].surname}      Балл:{array[i].ball}");
            }
        }
    }
}
