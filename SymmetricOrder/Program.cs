using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> outputs = new List<string>();
            int set = 1;
            while (true)
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }

                string[] inputs = new string[n];
                string[] order = new string[n];

                for (int i = 0; i < n; i++)
                {
                    inputs[i] = Console.ReadLine();

                }
                int p = 0;

                if (n % 2 == 0)
                {
                    for (int i = 0; i <= n / 2; i++)
                    {
                        order[i] = inputs[p];

                        order[(n - 1) - i] = inputs[p + 1];
                        p += 2;

                        if ((p + 1) > (order.Length - 1))
                        {
                            break;
                        }

                    }
                }
                else
                {
                    for (int i = 0; i <= n / 2; i++)
                    {
                        order[i] = inputs[p];

                        
                        if ((p + 1) > (order.Length - 1))
                        {
                            break;
                        }
                        else
                        {
                            order[(n - 1) - i] = inputs[p + 1];
                            p += 2;
                        }

                    }
                }
                

                outputs.Add($"SET {set}");

                foreach (var s in order)
                {
                    outputs.Add(s);
                }
                set++;
            }

            foreach (var s in outputs)
            {
                Console.WriteLine(s);
            }
        }
    }
}
