﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expressions
{
    class Program
    {    
        static void Main(string[] args)
        {
            List<Person> list = new List<Person>(); //list           
            // AddingDetails(list); //call method
            // RetriveTop2Record(list);
            // RetriveRecordAge13to18(list);
            // RetriveAverageAgeRecord(list);
            // RecordNamePersonPresentOrNot(list);
           //  RemoveSpecificName(list);
            Console.ReadLine();
        }
        public static void AddingDetails(List<Person> list) //create Adding Detialaccess method 
        {  /* UC1:- Person Data Management 
                    - Create Person class with SSN, Name, Address and Age fields.
                    - Create variable for List of Person class in Main method. 
                    - Add default values in created list.
            */
            
            String input = Console.ReadLine();
            list.Add(new Person() { SNN = 1, Age = 23, Name = "Omprakash", Address = "Nagpur" }); //Adding item in list
            list.Add(new Person() { SNN = 2, Age = 17, Name = "Vishal", Address = "Mumbai" }); //Adding item in list
            list.Add(new Person() { SNN = 3, Age = 23, Name = "Ekta", Address = "Pune,Aund" }); //Adding item in list
            list.Add(new Person() { SNN = 4, Age = 16, Name = "Ram", Address = "Aund" });  //Adding item in list
            list.Add(new Person() { SNN = 5, Age = 85, Name = "Sham", Address = "Pimpri" });  //Adding item in list
            list.Add(new Person() { SNN = 6, Age = 75, Name = "Rag", Address = "Wadi" }); //Adding item in list

            foreach (Person List in list) //iterate list
            {
                Console.WriteLine($"SSN:- {List.SNN} Age:- {List.Age} Name:- {List.Name} Address:- {List.Address} "); //Print Record of the list
            }


        }
        public static void RetriveTop2Record(List<Person> list) //create Retrive Method 
        {  /* UC2:- Person Data Management
                    - Retrieve top 2 records from the list for age is less than 60
            */
            Console.WriteLine("\n\n");
            var Result = list.FindAll(x => x.Age < 60).OrderBy(x => x.Age).Take(2); //using Lambda Expression find age is less than and print top 2 Record
            foreach (var List in Result) //iterate list
            {
                Console.WriteLine($"SNN:- {List.SNN} Age:- {List.Age} Name:- {List.Name} Address:- {List.Address}"); //Print Top 2 Record
            }
        }

        


    }
}
