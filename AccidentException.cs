namespace ConsoleApp20
{
    public class AccidentException : Exception
    {
        public string Location { get; set; }

        public AccidentException(string location,string message):base(message)
        {
            Location = location;
        }
    }
    public class WrongAddressException : Exception
    {
        

        public WrongAddressException(string message) : base(message)
        {
           
        }
    }
}

