namespace Exeption;

class Program
{
    private static List<Exception> exceptions = new List<Exception>();

    static void Main(string[] args)
    {
        CreateExceptionList();
        WriteExceptionMessage();
    }

    static void CreateExceptionList()
    {
        exceptions.Add(new Exception("Исключение Exception"));
        exceptions.Add(new FormatException("Исключение FormatException"));
        exceptions.Add(new NotSupportedException("Исключение NotSupportedException"));
        exceptions.Add(new KeyNotFoundException("Исключение KeyNotFoundException"));
        exceptions.Add(new LearnException("Исключение LearnException"));
    }

    static void WriteExceptionMessage()
    {
        foreach (var exception in exceptions)
        {
            try
            {
                throw exception;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}