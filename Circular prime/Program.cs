using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circular_prime {
    class Program {
        static void Main(string[] args) {
            
            int array_size = 1000000;
            int[] Array = new int[array_size + 1];
            int circular_prime = 0;

            for(int i = 2; i < array_size + 1; i++) {
                Array[i] = i;
            }

            for(int i = 2; i < array_size;) {
                if (Array[i] == 0) {
                    i++;
                }
                if (Array[i] != 0) {
                    for (int j = Array[i]; j < array_size - Array[i] + 1;) {
                        Array[j + Array[i]] = 0;
                        j = j + Array[i];
                    }
                    i++;
                }
            }

            for (int i = 2; i < array_size; i++) {
                if(Array[i] != 0) {
                    if (Array[i] <= 10) {
                        circular_prime++;
                        //Console.WriteLine(Array[i]);
                    }
                    if (Array[i] > 10 && Array[i] <= 100) {
                        if (Array[(Array[i] % 10) * 10 + Array[i] / 10] != 0) {
                            circular_prime++;
                            //Console.WriteLine(Array[i]);
                        }
                    }
                    if (Array[i] > 100 && Array[i] <= 1000) {
                        if (Array[(Array[i] - Array[i] / 100 * 100) * 10 + Array[i] / 100] != 0 &&
                            Array[(Array[i] % 10) * 100 + Array[i] / 10] != 0) {
                            circular_prime++;
                            //Console.WriteLine(Array[i]);
                        }
                    }
                    if (Array[i] > 1000 && Array[i] <= 10000) {
                        if (Array[(Array[i] - Array[i] / 1000 * 1000) * 10 + Array[i] / 1000] != 0 &&
                            Array[(Array[i] % 10) * 1000 + Array[i] / 10] != 0 &&
                            Array[(Array[i] % 100) * 100 + Array[i] / 100] != 0) {
                            circular_prime++;
                            //Console.WriteLine(Array[i]);
                        }
                    }
                    if (Array[i] > 10000 && Array[i] <= 100000) {
                        if (Array[(Array[i] - Array[i] / 10000 * 10000) * 10 + Array[i] / 10000] != 0 &&
                            Array[(Array[i] % 10) * 10000 + Array[i] / 10] != 0 && 
                            Array[(Array[i] % 1000) * 100 + Array[i] / 1000] != 0 &&
                            Array[(Array[i] % 100) * 1000 + Array[i] / 100] != 0) {
                            circular_prime++;
                            //Console.WriteLine(Array[i]);
                        }
                    }
                    if (Array[i] > 100000 && Array[i] <= 1000000) {
                        if (Array[(Array[i] - Array[i] / 100000 * 100000) * 10 + Array[i] / 100000] != 0 &&
                            Array[(Array[i] % 10) * 100000 + Array[i] / 10] != 0 && 
                            Array[(Array[i] % 10000) * 100 + Array[i] / 10000] != 0 &&
                            Array[(Array[i] % 100) * 10000 + Array[i] / 100] != 0 &&
                            Array[(Array[i] % 1000) * 1000 + Array[i] / 1000] != 0) {
                            circular_prime++;
                            //Console.WriteLine(Array[i]);
                        }
                    }
                }
            }
            Console.WriteLine(circular_prime);
            Console.Read();
        }
    }
}
