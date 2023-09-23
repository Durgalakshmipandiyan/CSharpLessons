using Microsoft.Data.SqlClient;
using System.Data;

namespace Firstmvcapp.Models
{
    public class MovieRepository
    {
        public static List<MovieDemo> GetMovieList()
        {
            
            List<MovieDemo> movielist = new List<MovieDemo>();
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmoviecmd = cn.CreateCommand();
                String selectMovie = "select * from Movies";
                selectmoviecmd.CommandText = selectMovie; //query assigned
                SqlDataReader moviedr = selectmoviecmd.ExecuteReader();
                while (moviedr.Read())
                {
                    MovieDemo mov = new MovieDemo
                    {
                        Id = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate=moviedr.GetDateTime(6),
                        Cost=moviedr.GetDecimal(7),
                        Collection=moviedr.GetDecimal(8),
                        Review=moviedr.GetString(9)
                    };
                    movielist.Add(mov);
                }
            }
            return movielist;
        }
        public static MovieDemo GetMoviebyId(int id)
        {
            MovieDemo movieFound = null;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand selectmovcmd = cn.CreateCommand();
                String selectAllMovs = "select * from Movies where ID=@id"; //@id runtime we can pass the value
                //query can have more than one parameter
                selectmovcmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                selectmovcmd.CommandText = selectAllMovs;
                SqlDataReader moviedr = selectmovcmd.ExecuteReader();
                while (moviedr.Read())
                {
                    movieFound = new MovieDemo
                    {
                        Id = moviedr.GetInt32(0),
                        Title = moviedr.GetString(1),
                        Language = moviedr.GetString(2),
                        Hero = moviedr.GetString(3),
                        Director = moviedr.GetString(4),
                        MusicDirector = moviedr.GetString(5),
                        ReleaseDate = moviedr.GetDateTime(6),
                        Cost = moviedr.GetDecimal(7),
                        Collection = moviedr.GetDecimal(8),
                        Review = moviedr.GetString(9)
                    };
                   
                }
            }
            return movieFound;
        }
        public static int AddNewMovie(MovieDemo newMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand insertMoviecmd = cn.CreateCommand();
                String insertNewMovieQuery = "insert into Movies values( @id,@title,@language,@hero,@director,@musicdirector,@releasedate,@cost,@collection,@review )";
                insertMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = newMovie.Id; //id doesnt need to same with table column
                insertMoviecmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = newMovie.Title;
                insertMoviecmd.Parameters.Add("@language", SqlDbType.NVarChar).Value = newMovie.Language;
                insertMoviecmd.Parameters.Add("@hero", SqlDbType.NVarChar).Value = newMovie.Hero;
                insertMoviecmd.Parameters.Add("@director", SqlDbType.NVarChar).Value = newMovie.Director;
                insertMoviecmd.Parameters.Add("@musicdirector", SqlDbType.NVarChar).Value = newMovie.MusicDirector;
                insertMoviecmd.Parameters.Add("@releasedate", SqlDbType.DateTime).Value = newMovie.ReleaseDate;
                insertMoviecmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = newMovie.Cost;
                insertMoviecmd.Parameters.Add("@collection", SqlDbType.Decimal).Value = newMovie.Collection;
                insertMoviecmd.Parameters.Add("@review", SqlDbType.NVarChar).Value = newMovie.Review;

                insertMoviecmd.CommandText = insertNewMovieQuery;
                query_result = insertMoviecmd.ExecuteNonQuery(); //not executing . tells how many records got inserted
            }
            return query_result;

        }
        public static int UpdateMovie(MovieDemo modifiedMovie)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand updateMoviecmd = cn.CreateCommand();
                String insertNewMovieQuery = "Update Movies set Id=@id,Title=@title,Language=@language,Hero=@hero,Director=@director,MusicDirector=@musicdirector,ReleaseDate=@releasedate,Cost=@cost,Collection=@collection,Review=@review where Id=@id ";
                updateMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = modifiedMovie.Id; //id doesnt need to same with table column
                updateMoviecmd.Parameters.Add("@title", SqlDbType.NVarChar).Value = modifiedMovie.Title;
                updateMoviecmd.Parameters.Add("@language", SqlDbType.NVarChar).Value = modifiedMovie.Language;
                updateMoviecmd.Parameters.Add("@hero", SqlDbType.NVarChar).Value = modifiedMovie.Hero;
                updateMoviecmd.Parameters.Add("@director", SqlDbType.NVarChar).Value = modifiedMovie.Director;
                updateMoviecmd.Parameters.Add("@musicdirector", SqlDbType.NVarChar).Value = modifiedMovie.MusicDirector;
                updateMoviecmd.Parameters.Add("@releasedate", SqlDbType.NVarChar).Value = modifiedMovie.ReleaseDate;
                updateMoviecmd.Parameters.Add("@cost", SqlDbType.Decimal).Value = modifiedMovie.Cost;
                updateMoviecmd.Parameters.Add("@collection", SqlDbType.Decimal).Value = modifiedMovie.Collection;
                updateMoviecmd.Parameters.Add("@review", SqlDbType.NVarChar).Value = modifiedMovie.Review;
                updateMoviecmd.CommandText = insertNewMovieQuery;
                query_result = updateMoviecmd.ExecuteNonQuery();
            }
            return query_result;


        }
        public static int DeleteMovie(int id)
        {
            int query_result = 0;
            using (SqlConnection cn = SqlHelper.CreateConnection())
            {
                if (cn.State != ConnectionState.Open)
                {
                    cn.Open();
                }
                SqlCommand deleteMoviecmd = cn.CreateCommand();
                String deleteMovieQuery = "Delete from Movies where ID=@id";
                deleteMoviecmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                deleteMoviecmd.CommandText = deleteMovieQuery;
                query_result = deleteMoviecmd.ExecuteNonQuery();
            }
            return query_result;
        }
    }
}
