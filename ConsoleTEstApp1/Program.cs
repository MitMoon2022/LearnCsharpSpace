using System.Collections;

namespace ConsoleTEstApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start of Program!");
            CStudent[] students = new CStudent[5];

            Hashtable hashtable = new Hashtable();


            students[0] = new CStudent(1, "Denis", 88);
            students[1] = new CStudent(2, "Olaf", 97);
            students[2] = new CStudent(6, "Ragner", 66);
            students[3] = new CStudent(1, "Luise", 73);
            students[4] = new CStudent(4, "Levi", 58);
          
            Console.WriteLine("There are a total of {0} students.",students.Length);

            foreach(CStudent s in students)
            {
                if(!hashtable.ContainsKey(s.Id))
                {
                    hashtable.Add(s.Id, s);
                    Console.WriteLine("Student with ID{0} was added!",s.Id);    

                }else
                {
                    Console.WriteLine("Sorry, A student with the same ID already exist {0}!", s.Id);

                }

            }


        }
    }
}