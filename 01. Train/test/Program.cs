using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> grains = Console.ReadLine().Split().Select(int.Parse).ToList();


            while (true)
            {

                string command = Console.ReadLine();


                if (command == "Mort")
                {
                    Console.WriteLine(string.Join(" ", grains));
                    break;
                }


                string[] array = command.Split();


                string line = array[0];
                int value = int.Parse(array[1]);


                if (line == "Add")
                {
                    grains.Add(value);
                }
                else if (line == "Remove")
                {
                    int counter = 0;
                    for (int i = 0; i < grains.Count; i++)
                    {

                        if (grains[i] == value)
                        {
                            counter++;
                            grains.Remove(value);
                            break;
                        }
                    }

                    if (counter == 0)
                    {
                        if (value >= 0 && value <= grains.Count - 1)
                        {
                            grains.RemoveAt(value);
                        }

                    }


                }
                else if (line == "Replace")
                {
                    int replacement = int.Parse(array[2]);


                    for (int i = 0; i < grains.Count; i++)
                    {
                        if (grains[i] == value)
                        {
                            grains[i] = replacement;
                            break;
                        }
                    }

                }
                else if (line == "Increase")
                {
                    int counter = 0;
                    for (int i = 0; i < grains.Count; i++)
                    {

                        if (grains[i] >= value)
                        {
                            counter++;
                            for (int j = 0; j < grains.Count; j++)
                            {
                                grains[j] += grains[i];
                            }

                        }

                    }

                    if (counter == 0)
                    {
                        int lastElement = grains[grains.Count - 1];

                        for (int i = 0; i < grains.Count; i++)
                        {
                            grains[i] += lastElement;

                        }



                    }

                }
                else if (line == "Collapse")
                {

                    for (int i = 0; i < grains.Count; i++)
                    {
                        if (grains[i] < value)
                        {
                            grains.RemoveAt(i);
                            i = -1;
                        }
                    }
                }
            }
        }
    }
}