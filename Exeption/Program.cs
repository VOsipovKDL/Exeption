using System;

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
        exceptions =
        [
            new Exception("Исключение Exception"),
            new FormatException("Исключение FormatException"),
            new NotSupportedException("Исключение NotSupportedException"),
            new KeyNotFoundException("Исключение KeyNotFoundException"),
            new LearnException("Исключение LearnException"),
        ];
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