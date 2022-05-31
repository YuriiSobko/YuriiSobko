using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_Net_module1_2_1_lab
{

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
  
     public interface ILibraryUser 
    {
        void ShowInfo();
        
    }
    public class LibraryUser : ILibraryUser
    {
       
        
        private string FirstName;
        private string LastName;
        private string Id;
        private string Phone { get; set; }
        private string BookLimit;
        string[] bookList = new string[10];
        public string this[string bookList]        
        {
            get
            {
                return bookList;
            }
        }


        public LibraryUser(string first, string second, string id, string limit, string number)
        {
            this.FirstName = first;
            this.LastName = second;
            this.Id = id;
            this.BookLimit = limit;
            this.Phone = number;
        }
        public void ShowInfo()
        {

        }
        public void AddBook()

        {
            while(true)
            {
                Console.WriteLine("Input name of book ");
                string name = Console.ReadLine();
                Console.WriteLine("Input index of book from 0 to 9");
                int index = int.Parse(Console.ReadLine());
                bookList[index] = name;
                if (index >= 10)
                {
                    Console.WriteLine("Cannot use this number");

                }
                else
                    Console.WriteLine($"The book {name} has been added ");
            }
           

    }
        public void RemoveBook() 

        {
          
            Console.WriteLine("Input index of book from 0 to 9");
            int index = int.Parse(Console.ReadLine());
            bookList[index] = null;
            if (index >= 10)
            {
                Console.WriteLine("There is no this book");

            }
            else
                Console.WriteLine($"The book {index} has been added ");

        }
        public void BookInfo() 
        {

       
        }
        public void BooksCout() 
        {

        }

    }


}




// 2) declare class LibraryUser, it implements ILibraryUser


    // 3) declare properties: FirstName (read only), LastName (read only), 
    // Id (read only), Phone (get and set), BookLimit (read only)


    // 4) declare field (bookList) as a string array


    // 5) declare indexer BookList for array bookList

    // 6) declare constructors: default and parameter

    // 7) declare methods: 

    //AddBook() – add new book to array bookList

    //RemoveBook() – remove book from array bookList

    //BookInfo() – returns book info by index

    //BooksCout() – returns current count of books



