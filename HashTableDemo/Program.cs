﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Id", "112233");
            ht.Add("Name", "Aayush_Mandal");
            ht.Add("Adress", "Manharpur");
            ht.Add("Gender", "Male");
            ht.Add("g-mail", "aayushmandal196@gmail.com");
            ht.Add("post", "Manager");
            Console.WriteLine(ht["Id"]);
            Console.ReadLine();
        }
    }
}
