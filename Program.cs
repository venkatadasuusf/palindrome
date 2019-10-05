using System;
using System.Collections.Generic;
using System.Linq;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "saippuakivxyzikauppias";
           
            string reverse = new string(input.Reverse().ToArray());

            Console.WriteLine(input);
            //Console.WriteLine(reverse);
            //Console.WriteLine(input[0]);
            //Console.WriteLine(input.Length);

            if (input == reverse)
            {
                Console.WriteLine("Initial check - they are same");
            }
            else
            {
                //Console.WriteLine("not same");
                int count = 1;
                int while_loop_count = 1;
                int i = input.Length - 1;
                int start_ind = 0;
                int end_ind = input.Length - 1;

                while (start_ind <= end_ind)
                {
                    Console.WriteLine("while loop checking count: " + while_loop_count++);
                    
                    if ((input[start_ind] == input[end_ind]))
                    {
                        
                        start_ind++;
                        end_ind--;
                    }
                    else
                    {
                        Console.WriteLine("loop checking count: " + count++);

                        string updated_input_string = new string(input.Remove(end_ind, 1));
                        Console.Write("updated_input_string: ");
                        Console.WriteLine(updated_input_string);

                        string updated_input_reverse_string = new string(updated_input_string.Reverse().ToArray());
                        Console.Write("updated_input_reverse_string: ");
                        Console.WriteLine(updated_input_reverse_string);

                        if (updated_input_string == updated_input_reverse_string)
                        {
                            //Console.WriteLine(updated_input_string);
                            //Console.WriteLine(updated_reverse_string);
                            Console.WriteLine("Deleting end item - they are same");
                            break;
                        }
                        else
                        {
                            string updated_input_string1 = new string(input.Remove(start_ind, 1));
                            Console.Write("updated_input_string1: ");
                            Console.WriteLine(updated_input_string1);

                            string updated_input_reverse_string1 = new string(updated_input_string1.Reverse().ToArray());
                            Console.Write("updated_input_reverse_string1: ");
                            Console.WriteLine(updated_input_reverse_string1);

                            if (updated_input_string1 == updated_input_reverse_string1)
                            {
                                //Console.WriteLine(updated_input_string);
                                //Console.WriteLine(updated_reverse_string);
                                Console.WriteLine("Deleting start item - they are same");
                                break;
                            }

                        }

                        start_ind++;
                        end_ind--;
                    }
                }

            }
        }
    }
}
