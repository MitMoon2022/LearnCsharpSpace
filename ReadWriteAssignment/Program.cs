using System;
using System.IO;
using System.Text;
using static System.Net.WebRequestMethods;

namespace ReadWriteAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Start!");

            // File name  
            string fileName = @"D:\jftMit1\Master_C#\input.txt";
            try
            {
                // Create a StreamReader  
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    // Read line by line  
                    while ((line = reader.ReadLine()) != null)
                    {
                        //Console.WriteLine(line);
                        //Modifier start here!
                        using (StreamWriter file = new StreamWriter(@"D:\jftMit1\Master_C#\output.txt",true))
                        {
                            if(line.Contains("split"))
                            {
                                //file.WriteLine("T");
                                Console.Write(line.Split()[4] + " ");
                                file.Write(line.Split()[4] + " ");

                                //string[] subs = line.Split("split");        //s.Split(' ', '.');
                                //for(int i = 0; i<subs.Length; i++)          //foreach (var sub in subs)
                                //{
                                //    Console.WriteLine($"Substring[]" + i +" : " +subs[i]);
                                //    file.WriteLine(subs[i]);
                                //}
                                //Console.WriteLine("=================================");


                            }
                           
                        }       
                    }//endof_while
                    Console.WriteLine("==================================================");
                    
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }

            Console.ReadKey();
        }






    }//end_class_program
}
