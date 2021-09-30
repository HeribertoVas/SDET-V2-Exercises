using System;
using System.Collections.Generic;

namespace Development_C_
{
    class Class1
    {

        string StringComparison(string string1,string string2){
            if(string1.Equals(string2)){
                return "Both strings are equal";
            }
            return "Strings are not equal";
        }
        
        void VerifyBiggestNumber(int[] numbers){
            int max = numbers[0];
            for (int i = 1; i < numbers.Length; i++){
                if (numbers[i] > max){
                    max = numbers[i];
                }
            }
            
            Console.WriteLine(max);
        }
        
        void SortList(List<string> strs){
            var words = strs;
            words.Sort();
            Console.WriteLine(string.Join(",",words));
            words.Reverse();
            Console.WriteLine(string.Join(",",words));
        }

        
        int CountStringLength(string str){

            return str.Length;
        } 
        
        static void Main(string[] args)
        {

            Class1 obj1 = new Class1();
            Console.WriteLine(obj1.StringComparison("abc","cb"));
            obj1.VerifyBiggestNumber(new int[] {10,2,3,4,5,8,7});
            obj1.SortList(new List<string> {"ghi","abc","def","abc"});
            Console.WriteLine(obj1.CountStringLength("Beto"));

        }
    }

    
}
