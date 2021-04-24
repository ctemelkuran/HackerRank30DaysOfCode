﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Day13_AbstractClasses
{
    abstract class Book
    {

        protected String title;
        protected String author;

        public Book(String t, String a)
        {
            title = t;
            author = a;
        }
        public abstract void display();

    }

    class MyBook : Book
    {
        int price;
        public MyBook(string title, string author, int price)
        {
            this.title = title;
            this.author = author;
            
        }
        public override void display()
        {
            Console.WriteLine("Title: ", title);
            Console.WriteLine("Author: ", author);
            Console.WriteLine("Price: ", price);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String title = Console.ReadLine();
            String author = Console.ReadLine();
            int price = Int32.Parse(Console.ReadLine());
            Book new_novel = new MyBook(title, author, price);
            new_novel.display();
        }
    }
}
