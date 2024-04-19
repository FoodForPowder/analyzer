namespace Analyzer
{
    public static class Program
    {

        static void Main()
        {
            try
            {
                Supervisior.Analyse();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}

