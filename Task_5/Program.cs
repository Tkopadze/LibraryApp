using Task_5;
bool isTrue = true;
while (isTrue)
{
    Console.OutputEncoding = System.Text.Encoding.UTF8;
    Library library = new Library();
    Book book = new Book("", "", "", 1);
    Console.WriteLine("აირჩიეთ სასურველი მოქმედება:");
    Console.WriteLine("1. წიგნის გატანა ");
    Console.WriteLine("2. წიგნის დაბრუნება ");
    Console.WriteLine("3. წიგნის მოძებნა");
    Console.WriteLine("4. წიგნების წაშლა");
    Console.WriteLine("5.  წიგნების დამატება ");
    Console.WriteLine("6. წიგნების სიის ნახვა ");
    Console.WriteLine("7. ინფორმაციის ჩვენება");
    Console.WriteLine("8. გამოსვლა");



    string option = Console.ReadLine();
    switch (option)
    {
        case "1":
            book.BorrowBook();
            break;
        case "2":
            book.ReturnBook();
            break;
        case "3":
            Console.WriteLine("შეიყვანეთ მოსაძებნი წიგნის სახელი");
            var bookToSearch = Console.ReadLine();
            library.SearchBook(bookToSearch);
            break;
        case "4":
            Console.WriteLine("შეიყვანეთ წასაშლელი წიგნის სახელი");
            var bookToRemove = Console.ReadLine();
            library.RemoveBook(bookToRemove);
            break;
        case "5":
            Console.WriteLine("შეიყვანეთ დასამატებელი წიგნის სახელი");
            var bookToAdd = AddBook();
            library.AddBook(bookToAdd);
            break;
        case "6":
            library.DisplayAllBooks();
            break;

        case "7":
            book.DisplayInfo();
            break;
        case "8":
            isTrue = false;
            break;

        default:
            Console.WriteLine("შეიყვანეთ ვალიდური სიმბოლო");
            break;

    }


}
Book AddBook()
{
    System.Console.WriteLine("შეიყვანეთ სახელი"); var title = Console.ReadLine();
    System.Console.WriteLine("შეიყვანეთ ავტორი"); var author = Console.ReadLine();
    System.Console.WriteLine("შეიყვანეთ isbn"); var isbn = Console.ReadLine();
    System.Console.WriteLine("შეიყვანეთ ეგზემპლარების რაოდენობა"); var copies = int.Parse(Console.ReadLine());
    Book book = new Book(title, author, isbn, copies);
    return book;
}