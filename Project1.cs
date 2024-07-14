using System;

namespace KyouKan
{

    public abstract class Book
    {
        //Attribute defualts, setters and getters
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public int ID { get; set; } = -1;
        //flag to mark issue status
        public bool IsIssued { set; get; } = false;
        //Constructors
        public Book(int id)
        {
            ID = id;
        }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public Book(string title, string author, int id)
        {
            Title = title;
            Author = author;
            ID = id;
        }

        //Abstract Displaqy Info
        public abstract void display_info();
    }

    public class FictionBook : Book
    {
        public string Genre { set; get; } = string.Empty;
        public FictionBook(int id) : base(id) { }
        public FictionBook(string title, string author) : base(title, author) { }

        public FictionBook(string title, string author, int id, string genre) : base(title, author, id) 
        {
        
           Genre = genre;

        }

        public override void display_info()
        {
            Console.WriteLine($"\nFiction Book Title: {Title}\nAuthor Name: {Author}\nGenre: {Genre}\nBook ID: {ID}\n");
        }
    }

    public class NonFictionBook : Book
    {

        public string Subject { set; get; } = string.Empty;
        public NonFictionBook(int id) : base(id) { }
        public NonFictionBook(string title, string author) : base(title, author) { }
        public NonFictionBook(string title, string author, int id, string subject) : base(title, author, id) 
        {
        
            Subject= subject;
        
        }
        public override void display_info()
        {
            Console.WriteLine($"\nFiction Book Title: {Title}\nAuthor Name: {Author}\nSubject: {Subject}\nBook ID: {ID}\n");
        }
    }

    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; } = -1;
        public int PersonID { get; set; } = -1;


        public Person(int id, string name, int age)
        {
            Name = name;
            Age = age;
            PersonID = id;
        }

    }

    public class Librarian : Person
    {
        public int EmployeeID { set; get; } = -1;

        public Librarian(int id, string name, int age, int emp_id) : base(id, name, age)
        { 
            EmployeeID= emp_id;
        }

        public void issue_book(Person user, Book book)
        {
            if(book.IsIssued == false)
            {
                book.IsIssued = true;
                Console.WriteLine($"Book : {book.Title} has been successfully issued to User : {user.Name}");
            }
            else
            {
                Console.WriteLine($"Book : {book.Title} has already been issued and is thus not avialable");
            }
            
        }

        public void return_book(Person user, Book book)
        {

            if (book.IsIssued == true)
            {
                book.IsIssued = false;
                Console.WriteLine($"Book : {book.Title} has been successfully recieved from User : {user.Name}");
            }
            else
            {
                Console.WriteLine($"Book : {book.Title} was never issued so can not be returned");
            }

        }
    }

    public class Library
    {
        public string Name { get; set; } = string.Empty;
        public int LibraryID { get; set; } = -1;
        public List<Book> books;
        public Librarian Librarian { set; get; }

        public Library(string name, int id, Librarian librarian)
        {
            Name = name;
            LibraryID = id;
            Librarian = librarian;
            books = new List<Book>();
        }


        public void add_book(Book book)
        {
            books.Add(book);
        }

        public void remove_book(int book_id)
        {
            books.RemoveAll(b => b.ID == book_id);
        }

        public void view_books()
        {
            foreach (var book in books)
            {
                book.display_info();
            }
        }

        public Book search_book(string title)
        {
            try
            {
                Book result = books.Find(b => b.Title == title);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n Book Not Found!");
                return null;
            }
            
        }
        
        public void list_issued_books()
        {
            foreach (var book in books.FindAll(b => b.IsIssued == true))
            {
                book.display_info();
            }
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Librarian librarian = new Librarian(1,"Sara", 28, 1);

            Library library = new Library("Olympian Library", 1, librarian);

            FictionBook book_1 = new FictionBook("The Great Gatsby", "F. Scott Fitzgerald", 1, "Novel");
            NonFictionBook book_2 = new NonFictionBook("A Brief History of Time", "Stephen Hawking", 2, "Science");
            FictionBook book_3 = new FictionBook("1984", "George Orwell", 3, "Dystopian");
            NonFictionBook book_4 = new NonFictionBook("A Life Beyond Time", "Alex Bertley", 4, "History");
            FictionBook book_5 = new FictionBook("Illiad and The Odyssey", "Homer", 5, "Mythology");

            library.add_book(book_1);
            library.add_book(book_2);
            library.add_book(book_3);
            library.add_book(book_4);
            library.add_book(book_5);

            Person user = new Person(1, "Jin", 22);

            while (true)
            {
                Console.WriteLine("\nLibrary de Olympia\n");
                Console.WriteLine("1. View Books");
                Console.WriteLine("2. Add Book");
                Console.WriteLine("3. Remove Book");
                Console.WriteLine("4. Issue Book");
                Console.WriteLine("5. Return Book");
                Console.WriteLine("6. Search Book");
                Console.WriteLine("7. List Issued Books");
                Console.WriteLine("8. Exit");
                Console.Write("\n\nChoose an option: ");
                
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        library.view_books();
                        break;
                    case "2":
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter book ID: ");
                        int bookID = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter genre/subject for (fiction/non-fiction): ");
                        string detail = Console.ReadLine();

                        Console.Write("Is this a fiction book? (Y/N): ");
                        string isFiction = Console.ReadLine();

                        if (isFiction.ToUpper() == "Y")
                        {
                            library.add_book(new FictionBook(title, author, bookID, detail));
                        }
                        else
                        {
                            library.add_book(new NonFictionBook(title, author, bookID, detail));
                        }
                        break;
                    case "3":
                        Console.Write("Enter book ID to remove: ");
                        int removeID = Convert.ToInt32(Console.ReadLine());
                        library.remove_book(removeID);
                        break;
                    case "4":
                        Console.Write("Enter book ID to issue: ");
                        string issueID = Console.ReadLine();
                        Book bookIssue = library.search_book(issueID);
                        if (bookIssue != null)
                        {
                            librarian.issue_book(user, bookIssue);
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;
                    case "5":
                        Console.Write("Enter book ID to return: ");
                        string returnID = Console.ReadLine();
                        Book bookReturn = library.search_book(returnID);
                        if (bookReturn != null)
                        {
                            librarian.return_book(user, bookReturn);
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;
                    case "6":
                        Console.Write("Enter title to search: ");
                        string searchTitle = Console.ReadLine();
                        Book searchResult = library.search_book(searchTitle);
                        if (searchResult != null)
                        {
                            searchResult.display_info();
                        }
                        break;
                    case "7":
                        library.list_issued_books();
                        break;
                    case "8":
                        Console.WriteLine($"\n\n Hope you had a good experience at {library.Name}! Hope to see you againqq");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
