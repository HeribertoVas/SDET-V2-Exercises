using System;
using System.Collections.Generic;

namespace Exercise_3_Development
{
    class A
    {

        public void strSameLength(String str, String str2)
        {
            if (str.Length == str2.Length)
            {
                Console.WriteLine("Both strings have same length");
            }
            else
            {
                Console.WriteLine("Strings have different length");
            }
        }

        public void listsSameLength(List<Object> lst1, List<Object> lst2)
        {
            if (lst1.Count == lst2.Count)
            {
                Console.WriteLine("Both lists have same length");
            }
            else
            {
                Console.WriteLine("Lists have different length");
            }
        }


    }

    interface Interface
    {
        void Hello();

    }
    class B : A,Interface 
    {        
        public void Hello()
        {
            Console.WriteLine("Hello Interface");
        }   
        public List<String> orderList(List<String> lst, String typeOfOrder)
        {
            List<String> returned = new List<String>();
            if (typeOfOrder == "asc")
            {
                String min = lst[0];
                returned.Insert(0, min);
                for (int i = 1; i < lst.Count; i++)
                {                    
                    //next element is smaller
                    if (min.Length > lst[i].Length)
                    {
                        min = lst[i];
                        returned.Insert(0, lst[i]);
                    }
                    //next element is bigger or equals min
                    else
                    {
                        //Validate returned list from start to insert small elements in the correct position considering the other elements of list
                        Boolean singleOrLastElement = true; 
                        for (int j = 1; j < returned.Count; j++)
                        {
                            //if element i is less or equal to element j insert in the position j
                            if (returned[j].Length >= lst[i].Length)
                            {
                                returned.Insert(j, lst[i]);
                                singleOrLastElement = false;
                                break;
                            }
                        }
                        if (singleOrLastElement)//if returned has just one element or is last insert next.
                        {
                            returned.Insert(i, lst[i]);
                        }
                    }
                }
            }
            else if(typeOfOrder == "desc")
            {
                String max = lst[0];
                returned.Insert(0, max);
                for (int i = 1; i < lst.Count; i++)
                {
                    //next element is bigger
                    if (max.Length < lst[i].Length)
                    {
                        max = lst[i];
                        returned.Insert(0, lst[i]);
                    }
                    //next element is smaller or equals max
                    else
                    {
                        //Validate returned list from start to insert bigger elements in the correct position considering the other elements of list
                        Boolean singleOrLastElement = true;
                        for (int j = 1; j < returned.Count; j++)
                        {
                            //if element i is more or equal to element j insert in the position j 
                            if (returned[j].Length <= lst[i].Length )
                            {
                                returned.Insert(j, lst[i]);
                                singleOrLastElement = false;
                                break;
                            }
                        }
                        if (singleOrLastElement)//if returned has just one element or is last insert next.
                        {
                            returned.Insert(i, lst[i]);
                        }
                    }
                }
            }
            return returned;
        }

        public List<String> filterList(List<String> list)
        {
            List<String> returned = new List<String>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i]!=" ")
                {
                    returned.Add(list[i]);
                }
                
            }

            return returned;
        }

        public List<int> removeDuplicates(List<int> list)
        {
            List<int> returned = new List<int>();
            returned.Insert(0, list[0]); //Insert first element
            for (int i = 1; i < list.Count; i++)
            {
                if (returned.Count > 1) // Returned has more than 1 then validate previous elements
                {
                    Boolean inList = false;
                    for (int j = 0; j < returned.Count; j++) // review all returned elements
                    {
                        if (list[i] == returned[j])
                        {
                            inList = true;
                            break; //if element i is already on lst break
                        }
                    }
                    if (!inList) //is not duplicated add
                    {
                        returned.Add(list[i]);
                    }
                }
                else //Returned has just one element
                {
                    if (list[i] == list[0])//if its same continue
                    {
                        continue;
                    }
                    else //different then insert
                    {
                        returned.Add(list[i]);
                    }
                }
            }
            return returned;
        }

        static void Main(string[] args)
        {
            B b = new B();
            b.strSameLength("otr", "max");
            b.Hello();
            List<String> list = new List<String>() { "Text", "Computer", "Automation", "Visual Studio", "Auto Parts", " " };
            List<int> integers = new List<int>() { 1, 1, 2, 3, 4, 4, 5, 6, 7, 8, 10 };
            List <String> returned = (b.orderList(list, "asc"));

            for (int i = 0; i < returned.Count; i++)
            {
                Console.WriteLine(returned[i]);
            }
        
            List<String> filtered = (b.filterList(list));
            for (int i = 0; i < filtered.Count; i++)
            {
                Console.WriteLine(filtered[i]);
            }

            List<int> duplicateFree = (b.removeDuplicates(integers));
            for (int i = 0; i < duplicateFree.Count; i++)
            {
                Console.WriteLine(duplicateFree[i]);
            }
        }
    }

    
}
