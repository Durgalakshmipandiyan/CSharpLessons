namespace LibraryA

{ 
    //internal only within the same assembly  public to all
    public class Book
    {
        public string Title = string.Empty;
        public string Author = string.Empty;
        public string Genre = string.Empty;
        public DateTime DateOfPublish;
        public int BookPrice;
        public int TotalPages=300;
        public void OpenBook()
        {
            Console.WriteLine( "Book is open");
        }
        public void BookMarkPage(int pageNo)
        {
            Console.WriteLine( $"Page No: {pageNo}Bookmarked");
        }
        public int GetCurrentPage()
        {
            Random r = new Random();
            return r.Next(TotalPages);
        }
    }
}