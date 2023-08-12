namespace StudentDetails.Global_Exception
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
}
