namespace ccc336_FINAL_KARIMBABA.Filters
{
    public class UnauthorizedAccessException : Exception
    {
        public UnauthorizedAccessException(string message) : base(message) { }
    }
}
