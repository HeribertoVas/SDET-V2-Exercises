using System;
using System.Collections.Generic;

namespace Development_C_
{
    class Class2
        {
            void PrintFirstFiveValues(List<int> listI){
                for (int i = 0; i < 5; i++){
                    Console.WriteLine(listI[i]);
                }
            }
            
            void PrintSmallestNumber(int[] numbers){
                int min = numbers[0];
                for (int i = 1; i < numbers.Length; i++){
                    if (numbers[i] < min){
                        min = numbers[i];
                    }
                }
                
                Console.WriteLine(min);
            }
            
            void PrintDictionaryByKey(){
                Dictionary<string, string> dictionary =new Dictionary<string, string>();
                dictionary.Add("txt", "notepad.exe");
                dictionary.Add("bmp", "paint.exe");
                dictionary.Add("dib", "paint.exe");
                dictionary.Add("rtf", "wordpad.exe");

                foreach(KeyValuePair<string, string> entry in dictionary){
                    Console.WriteLine(entry.Value);
                }
            }

            
            static void Main(string[] args)
            {

                Class2 obj2 = new Class2();
                obj2.PrintFirstFiveValues(new List<int>{1,2,3,4,5,6,7,8});
                obj2.PrintSmallestNumber(new int[] {2,10,11,9,8});
                obj2.PrintDictionaryByKey();

            }
        }
}