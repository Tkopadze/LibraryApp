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
                    throw new ArgumentException("Title cannot be empty or whitespace.");
                _title = value;
            }
        }

        public string Author
        {
            get { return _author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Author cannot be empty or whitespace.");
                _author = value;
            }
        }

        public string Isbn
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("ISBN cannot be empty or whitespace.");
                if (value.Length != 13 || !long.TryParse(value, out _))
                    throw new ArgumentException("ISBN must be a 13-digit number.");
                _isbn = value;
            }
        }

        public int CopiesAvailable
        {
            get { return _copiesAvailable; }
            set
            {
                if (value >0)
                    throw new ArgumentException("Copies available cannot be negative.");
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

        }
        public void BorrowBook()
        {

        }
        public void ReturnBook()
        {

        }
    }
}



