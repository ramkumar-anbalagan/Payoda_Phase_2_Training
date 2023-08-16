namespace JWTAuth.GlobalExceptions
{
    public class StudentDetailsException : Exception
    {
        public static List<string> StudentDetailExceptions { get; set; } =

        new List<string>
            {
                "Student Not Found" ,
                "" ,
                ""
            };



    }
    public class UserException : Exception
    {
        public static List<string> UserDetailExceptions { get; set; } =

        new List<string>
            {
                "User Not Found" ,
                
            };



    }
}
