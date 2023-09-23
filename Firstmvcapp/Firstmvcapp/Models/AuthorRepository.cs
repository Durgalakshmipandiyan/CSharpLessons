using System.Security.Policy;
using System.Text;

namespace Firstmvcapp.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            String fName = @"c:\temp\author.txt";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExists = System.IO.File.Exists(fName);
            if (isFileExists)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(','); // sometimes there is empty lines 
                    Author author = null;
                    if (data.Length == 5) //no .of values should be this
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author); //ensure uniqueness
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(",");
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.AuthorID, author);
                            }
                        }

                    }
                }
            }
            return list;

        }
        //key and value to uniquely identify author objects

        private static Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];

            author.Dob = DateTime.Parse(data[2]);
            author.BooksPublished = int.Parse(data[3]);
            author.Royalty = data[4];
            return author;

        }

        public static void SaveToFile(Author pauthor)
        {
            String fName = @"c:\temp\author.txt";
            string strAuthor = $"{pauthor.AuthorID},{pauthor.AuthorName},{pauthor.Dob},{pauthor.BooksPublished},{pauthor.Royalty}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
        }
        public static Author FindAuthorById(int id)
        {
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            Author author = null;
            if (list != null)
                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            return author;
        }

        public static void UpdateAuthorToFile(Author pAuthor)
        {
            string fName = @"c:\temp\author.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);
            foreach (Author author in list.Values)
            {
                if (author.AuthorID != pAuthor.AuthorID)
                {
                    sbAuthors.Append($"{author.AuthorID}, {author.AuthorName}, {author.Dob}, {author.BooksPublished}, {author.Royalty} {Environment.NewLine}");
                }
                else
                {
                    sbAuthors.Append($"{pAuthor.AuthorID}, {pAuthor.AuthorName}, {pAuthor.Dob}, {pAuthor.BooksPublished}, {pAuthor.Royalty} {Environment.NewLine}");
                }
            }
            File.WriteAllText(fName, sbAuthors.ToString());
        }
        public static void RemoveAuthor(int id)
        {
            String fName = @"c:\temp\author.txt";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictionary();
            StringBuilder sbAuthors = new StringBuilder(list.Count + 100);
            foreach (Author author in list.Values)
            {
                if (author.AuthorID != id)
                {
                    sbAuthors.Append($"{author.AuthorID}, {author.AuthorName}, {author.Dob}, {author.BooksPublished}, {author.Royalty} {Environment.NewLine}");



                }
            }
            File.WriteAllText(fName, sbAuthors.ToString());
        }

    }
}
