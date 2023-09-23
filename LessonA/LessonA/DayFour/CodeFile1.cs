public enum MovieRating
{
    VeryBad = 0, // version number for enum numbers
    Bad = 1,
    Average = 2,
    Good = 3,
    Excellant = 4
}
public enum CarColor
{
    Black = 0, White = 1, Red = 2, Green = 3
}



public enum Desserts
{
    Icecream, Cake, MysorePak //default value 0,1,2
}
//public enum Desserts
//{
//    Icecream=5, sweet = 6, Cake=10, MysorePak=15 //default value 
//}
class TestEnum
{

    public static void TestMovieRating()
    {
        Type t1 = typeof(MovieRating);// typeof instance. can be used with classes,interface,deligates
        String[] enumNames = Enum.GetNames(t1); // t1 reference to ,metadata of enum of movie rating
        String name = String.Empty;
        int len = enumNames.Length;
        for (int i = 0; i < len; i++)
        {
            name = enumNames[i];
            MovieRating movies = (MovieRating)Enum.Parse(t1, name);
            Console.WriteLine(name + " " + (int)movies);
        }
    }

}