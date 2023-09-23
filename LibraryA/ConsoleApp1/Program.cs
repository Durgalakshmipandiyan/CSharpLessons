//to accss multiple files

using LibraryA;

Book book = new Book();
book.Title = "Twisted love";
book.Author = "Ana huang";
book.Genre = "social";
book.BookPrice = 300;
book.DateOfPublish = new DateTime(1995, 08, 01);
book.BookMarkPage(124);
Console.WriteLine( book.GetCurrentPage());
Calculator cal = new Calculator();
int addresult = cal.add(10, 40);

Console.WriteLine(addresult);

int multiplyResult = cal.mutiply(100, 20);

Console.WriteLine(multiplyResult);

int divideResult = cal.divide(100, 50);

Console.WriteLine(divideResult);


