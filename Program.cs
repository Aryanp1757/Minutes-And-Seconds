namespace Minutesandseconds
{
    internal class Program
    {   /// <summary>
    /// demostartes integer data types
    /// </summary>
    /// <param name="args">command-line args</param>
        static void Main(string[] args)
        {
            int totalsecondsplayed = 100;
            const int secondspermiute = 60;
            // calculated minutes and seconds 

            int minutesplayed= totalsecondsplayed/secondspermiute;
            int secondsplayed = totalsecondsplayed % secondspermiute;

            // print minutes and seconds 
            Console.WriteLine("total minutes : " + minutesplayed);
            Console.WriteLine("seconds played : " + secondsplayed); 
        }
    }
}