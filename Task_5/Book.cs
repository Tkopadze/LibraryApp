namespace Task_5
{
    public class Book
    {
        private string _title;
        private string _author;
        private string _isbn;
        private int _copiesAvailable;

        public string Title
        {
            get { return _title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("სახელი არავალიდურია");
                _title = value;
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ავტორი არავალიდურია");
                _author = value;
            }
        }

        public string Isbn
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ISBN არავალიდურია.");
                if (value.Length != 13 || !long.TryParse(value, out _))
                    throw new ArgumentException("ISBN არავალიდურია");
                _isbn = value;
            }
        }

        public int CopiesAvailable
        {
            get { return _copiesAvailable; }
            set
            {
                if (value >0)
                    throw new ArgumentException("არ არის ვალიდური");
                _copiesAvailable = value;
            }
        }

        public Book(string author, string title, string isbn, int copiesAvailable)
        {
            _author = author;
            _title = title;
            _isbn = isbn;
            _copiesAvailable = copiesAvailable;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"სახელი: {Title}");
            Console.WriteLine($"ISBN: {_isbn}");
            Console.WriteLine($"ავტორი: {Author}");
            Console.WriteLine($"მარაგში: {CopiesAvailable}");
        }

        public void BorrowBook()
        {

            if (_copiesAvailable > 0)
            {
                _copiesAvailable--;
                Console.WriteLine($"წარმატებით გაიტანეთ წიგნი: {Title}. დარჩა {_copiesAvailable} მარაგში.");
            }
            else
            {
                Console.WriteLine($" {Title} არ არის მარაგში");
            }

        }

        public void ReturnBook()
        {
            if (true)
            {
                _copiesAvailable++;
                Console.WriteLine($"{Title} წარმატებით დაბრუნდა");
            }
            
        }
    }

}



