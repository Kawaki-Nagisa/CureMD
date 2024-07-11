using System;
using System.ComponentModel.Design;
using System.Xml.Linq;

namespace KyouKan
{
    class Book
    {

        private string title;
        private string author;
        private int id;
        private static int id_counter = 1;

        public Book()
        {
            title = string.Empty;
            author = string.Empty;
            id = id_counter++;
        }

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            id = id_counter++;
        }


        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public void display_info()
        {
            Console.WriteLine($"\nBook Title: {title}\nAuthor Name: {author}\nBook ID: {id}\n");
        }
    }

    class Person
    {

        private string name;
        private int age;
        private int id;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        
            

    }

    class Library
    {

        private string name;
        private int id;
        private List<Book> books;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public void add_book(Book book)
        { 
        
        }
        public void remove_book(int book_id)
        {
        
        }

        public void view_books()
        {
            Console.WriteLine(string.Join("\n", books));
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}