namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool i = true;
            while (i == true) 
                {
                DateTime now = DateTime.Now;
                System.Threading.Thread.Sleep(1000);
                Console.WriteLine("current date is: " + now);

                }
        }
    }
}