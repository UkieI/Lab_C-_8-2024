using System.Collections;
namespace Lab4
{   
    public interface IBook
    {
        int Index { get; }

        string Title { get; set; }
        string Author { get; set; }
        string Publisher { get; set; }
        int Year { get; set; }
        string ISBN { get; set; }

        void Show();
    }

    public class Book : IBook, IComparable<Book>
    {
        private static int counter = 0; // Chỉ mục tự động
        public int Index { get; private set; }
        
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public int Year { get; set; }
        public string ISBN { get; set; }
        
        private ArrayList chapter = new ArrayList();

        public Book(){

        }
        public Book(string title, string author, string publisher, int year, string isbn)
        {
            Index = ++counter; // Tăng chỉ mục tự động
            Title = title;
            Author = author;
            Publisher = publisher;
            Year = year;
            ISBN = isbn;
        }

        public void Show()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Year:" + Year);
            Console.WriteLine("ISBN:" + ISBN);
            Console.WriteLine("Chapter: ");
            for (int i = 0 ; i < chapter.Count; i++)
                Console.WriteLine("\t{0}: {1}",  i + 1, chapter[i]);
            Console.WriteLine("-----------------------------------");
           
        }

        // Phương thức để so sánh theo tên sách
        public int CompareTo(Book other)
        {
            return Title.CompareTo(other.Title);
        }
        public void Input ()
        {
            Console.Write("Title: ");
            Title = Console.ReadLine();
            Console.Write("Author: ");
            Author = Console.ReadLine();
            Console.Write("Publisher: ");
            Publisher = Console.ReadLine();
            Console.Write("ISBN: ");
            ISBN = Console.ReadLine();
            Console.Write("Year: ");
            Year = int.Parse(Console.ReadLine());
            Console.Write("Input Chapter (finished with empty string) ");
            string str;
            do 
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                    chapter.Add(str);
                
            } while (str.Length > 0);
        }


    }
    public class CompareByAuthor : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Author.CompareTo(y.Author);
        }
    }

    public class CompareByPublisher : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Publisher.CompareTo(y.Publisher);
        }
    }

    public class CompareByYear : IComparer<Book>
    {
        public int Compare(Book x, Book y)
        {
            return x.Year.CompareTo(y.Year);
        }
    }

    class BookList
    {
        private List<Book> list = new List<Book>();

        public void AddBook()
        {
            Book b = new Book();

            b.Input();
            list.Add(b);
        }

        public void ShowList()
        {
            foreach (Book b in list)
                b.Show();
        }



        public void InputList()
        {
            int n;
            Console.WriteLine("Amount of books: ");
            n = int.Parse(Console.ReadLine());
            while ( n > 0)
            {
                AddBook();
                n--;
            }
        }

        public void SortByAuthor()
        {
            list.Sort(new CompareByAuthor());
        }

        // Sắp xếp theo nhà xuất bản
        public void SortByPublisher()
        {
            list.Sort(new CompareByPublisher());
        }

        // Sắp xếp theo năm xuất bản
        public void SortByYear()
        {
            list.Sort(new CompareByYear());
        }
    }
    class Ex2_1
    {
        public static void run()
        {
            BookList bookList = new BookList();
            bookList.InputList();
            bookList.ShowList();
            
            while (true){
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("\nDanh sách sách sắp xếp theo tên tác giả:");
                        bookList.SortByAuthor();
                        bookList.ShowList();
                        break;
                    case 2:
                        Console.WriteLine("\nDanh sách sách sắp xếp theo nhà xuất bản:");
                        bookList.SortByPublisher();
                        bookList.ShowList();
                        
                        break;
                    case 3:
                        Console.WriteLine("\nDanh sách sách sắp xếp theo năm xuất bản:");
                        bookList.SortByYear();
                        bookList.ShowList();

                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                        return;
                }
            }
    
        }
    }

}